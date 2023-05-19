using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class FormTaoTaiKhoan : Form
    {
        public FormTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void PhanQuyen()
        {
            if (Program.mGroup == "TRUONG")
            {
                if (label_NHOM.Text == "TRUONG")
                    btnXoa.Enabled = btnThem.Enabled = cmbCoSo.Enabled = true;
            }
            else if (Program.mGroup == "COSO")
            {
                cmbCoSo.Enabled = false;
                if (label_NHOM.Text == "COSO" || label_NHOM.Text == "GIANGVIEN")
                    btnXoa.Enabled = btnThem.Enabled = true;
            }
            else
                btnXoa.Enabled = btnThem.Enabled = cmbCoSo.Enabled = false;

            labelLoginName.Visible = btnGhi.Enabled = btnHuy.Enabled = labelNhom.Visible = label_NHOM.Visible = false;
            cmbNhom.Visible = cmbLoginName.Visible = textBoxMK.Visible = labelMK.Visible = false;
        }

        private void FormTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);

            cmbCoSo.DataSource = Program.bds_dspm;
            cmbCoSo.DisplayMember = "TENCS";
            cmbCoSo.ValueMember = "TENSERVER";
            cmbCoSo.SelectedIndex = Program.mCoso;
            Program.servername = cmbCoSo.SelectedValue.ToString();

            string[] dsNhom = new string[2];
            dsNhom[0] = "COSO";
            dsNhom[1] = "GIANGVIEN";

            cmbNhom.Items.Clear();
            cmbNhom.Items.AddRange(dsNhom);
            cmbNhom.SelectedIndex = 0;

            PhanQuyen();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            labelNhom.Visible = label_NHOM.Visible = cmbNhom.Visible = labelLoginName.Visible = true;
            btnHuy.Enabled = cmbLoginName.Visible = textBoxMK.Visible = labelMK.Visible = true;
            gcGiaoVien.Enabled = false;

            String sql = "EXEC SP_TaoLoginName @HO, @TEN";

            Hashtable paras = new Hashtable();
            paras.Add("@HO", label_HO.Text);
            paras.Add("@TEN", label_TEN.Text);

            DataTable dataTable = new DataTable();
            string[] danhSach = new string[3];
            DataTable dt = Program.ExecSqlDataTable(sql, paras);
            danhSach[0] = dt.Rows[0][0].ToString();
            danhSach[1] = dt.Rows[1][0].ToString();
            danhSach[2] = dt.Rows[2][0].ToString();

            cmbLoginName.Items.Clear();
            cmbLoginName.Items.AddRange(danhSach);
            cmbLoginName.SelectedIndex = 0;

            btnThem.Enabled = btnXoa.Enabled = btnThoat.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa quyền của : " + label_HO.Text + "  " + label_TEN.Text, "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "exec XoaLogin @USERNAME";
                Hashtable paras = new Hashtable();
                paras.Add("@USERNAME", label_MAGV.Text);
                Reload();
                if (Program.ExecSqlNonQuery(sql, paras) != 0)
                    return;
            }
        }

        private void gvGiaoVien_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            string sql = "EXEC SP_NhomGV'" + label_MAGV.Text + "'";
            try
            {
                DataTable dt = new DataTable();
                dt = Program.ExecSqlDataTable(sql);
                label_NHOM.Text = dt.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                label_NHOM.Text = "";
            }
            label_NHOM.Enabled = true;
            PhanQuyen();

            if (label_NHOM.Text.Equals(""))
            {
                btnThem.Enabled = true;
                btnXoa.Enabled = false;
            }
                
            else
            {
                btnXoa.Enabled = true;
                btnThem.Enabled = false;
            }    
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(textBoxMK.Text.Equals(""))
            {
                MessageBox.Show("Mật khẩu không được trống", "");
                return;
            }
            string sql = "EXEC SP_TAOLOGIN @LGNAME, @PASS, @USERNAME, @ROLE";

            Hashtable paras = new Hashtable();
            paras.Add("@LGNAME", cmbLoginName.SelectedItem.ToString());
            paras.Add("@PASS", textBoxMK.Text);
            paras.Add("@USERNAME", label_MAGV.Text);
            if (Program.mGroup == "TRUONG")               paras.Add("@ROLE", "TRUONG");
            else if (Program.mGroup == "COSO")            paras.Add("@ROLE", cmbNhom.SelectedItem.ToString());

            Reload();
            gcGiaoVien.Enabled = btnXoa.Enabled = btnThoat.Enabled = btnReload.Enabled = true;
            if (Program.ExecSqlNonQuery(sql, paras) != 0)
            {
                MessageBox.Show("Lỗi ghi tài khoản", "");
                return;
            }
        }

        private void Reload()
        {
            try
            {
                dS.EnforceConstraints = false;
                this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);
                labelLoginName.Visible = cmbNhom.Visible = cmbLoginName.Visible = textBoxMK.Visible = labelMK.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            PhanQuyen();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Reload();
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsGV.CancelEdit();
            labelNhom.Enabled = cmbNhom.Visible = labelLoginName.Visible = cmbLoginName.Visible = textBoxMK.Visible = labelMK.Visible = false;
            gcGiaoVien.Enabled = true;
            Reload();
            PhanQuyen();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát khỏi form?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void cmbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCoSo.SelectedValue == null)
            {
                return;
            }

            if (cmbCoSo.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cmbCoSo.SelectedValue.ToString();

            if (cmbCoSo.SelectedIndex != Program.mCoso)
            {
                Program.mlogin = Program.remoteLogin;
                Program.password = Program.remotePassword;
            }
            else
            {
                Program.mlogin = Program.loginDN;
                Program.password = Program.passwordDN;
            }

            if (Program.dangXuat == false && Program.KetNoi() == 0)
                MessageBox.Show("Lỗi kết nối về cơ sở mới!: mlogin: " + cmbCoSo.SelectedIndex + ", pass: " + Program.mCoso);
             
            else
            {
                dS.EnforceConstraints = false;
                this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);
                Program.mCoso = cmbCoSo.SelectedIndex;
            }
        }
    }
}
