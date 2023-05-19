using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class KhoaLop : Form
    {
        private int vitri;
        Dictionary<String, Boolean> themSuaMap = new Dictionary<String, Boolean>();
        public KhoaLop()
        {
            InitializeComponent();
        }

        private void PhanQuyen()
        {
            if (Program.mGroup == "TRUONG")
            {
                cmbCoSo.Enabled = true;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = btnHuy.Enabled = false;
                menuItermThem.Enabled = menuItermXoa.Enabled = menuItermSua.Enabled = false;
            }
            else
           if (Program.mGroup == "GIANGVIEN")
            {

                cmbCoSo.Enabled = false;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = false;
                menuItermThem.Enabled = menuItermXoa.Enabled = menuItermSua.Enabled = false;
                btnHuy.Enabled = false;
            }
            else//CS
            {
                cmbCoSo.Enabled = false;
                btnReload.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
                btnPhucHoi.Enabled = btnGhi.Enabled = btnHuy.Enabled = false;
                menuItermThem.Enabled = menuItermXoa.Enabled = menuItermSua.Enabled = true;
                if (bdsKhoa.Count == 0)
                    btnXoa.Enabled = btnSua.Enabled = menuLop.Enabled = false;
                else
                {
                    btnXoa.Enabled = btnSua.Enabled = menuLop.Enabled = true;
                    if (bdsLop.Count == 0)
                        menuItermXoa.Enabled = menuItermSua.Enabled = false;
                    else
                        menuItermXoa.Enabled = menuItermSua.Enabled = true;
                }
            }
            cmbTenKhoa.Visible = panelEdt.Enabled = edtKHOA_LOP.Visible = false;
            gcKhoa.Enabled = gcLop.Enabled = btnThoat.Enabled = true;
        }

        private void KhoaLop_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;

            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.dS.KHOA);

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);

            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);

            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);

            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);

            themSuaMap.Add("ThemLop", false);
            themSuaMap.Add("SuaLop", false);
            themSuaMap.Add("ThemKhoa", false);
            themSuaMap.Add("SuaKhoa", false);

            cmbCoSo.DataSource = Program.bds_dspm;
            cmbCoSo.DisplayMember = "TENCS";
            cmbCoSo.ValueMember = "TENSERVER";
            cmbCoSo.SelectedIndex = Program.mCoso;
            Program.servername = cmbCoSo.SelectedValue.ToString();

            PhanQuyen();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsKhoa.Position;
            panelEdt.Enabled = true;
            edtMaCS.Enabled = edtMaKH.Enabled = edtMaLop.Enabled = edtTenLop.Enabled = false;
            edtTenKhoa.Enabled = true;

            bdsKhoa.AddNew(); //them sp mới vào ds

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            menuItermThem.Enabled = menuItermXoa.Enabled = menuItermSua.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = btnPhucHoi.Enabled = btnHoanTac.Enabled = true;

            gcKhoa.Enabled = gcLop.Enabled = false;
            themSuaMap["ThemKhoa"] = true;
            themSuaMap["ThemLop"] = themSuaMap["ThemLop"] = themSuaMap["SuaLop"] = false;
        }

        private void menuItermThem_Click(object sender, EventArgs e)
        {
            vitri = bdsLop.Position;
            panelEdt.Enabled = true;
            edtMaCS.Enabled = edtMaKH.Enabled = edtMaLop.Enabled = edtTenKhoa.Enabled = false;
            edtTenLop.Enabled = cmbTenKhoa.Visible = true;
            bdsLop.AddNew(); //them sp mới vào ds

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            menuItermThem.Enabled = menuItermXoa.Enabled = menuItermSua.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = btnPhucHoi.Enabled = btnHoanTac.Enabled = true;

            gcKhoa.Enabled = gcLop.Enabled = false;

            themSuaMap["ThemLop"] = true;
            themSuaMap["ThemKhoa"] = themSuaMap["SuaLop"] = themSuaMap["SuaKhoa"] = false;

            string sql = "SELECT MAKH ,TENKH FROM KHOA";
            cmbTenKhoa.DataSource = Program.ExecSqlDataTable(sql);
            cmbTenKhoa.DisplayMember = "TENKH"; cmbTenKhoa.ValueMember = "MAKH";
            foreach (var item in cmbTenKhoa.Items)
            {
                if (((DataRowView)item)[cmbTenKhoa.ValueMember].ToString() == edtMaKH.Text)
                {
                    cmbTenKhoa.SelectedItem = item;
                    break;
                }
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsKhoa.Position;
            // UndoStack.Push("exec[dbo].[SP_UndoSuaMH] '" + txtMaMH.Text + "', N'"
            //   + txtTen.Text + "'");
            panelEdt.Enabled = true;
            gcKhoa.Enabled = gcLop.Enabled = false;
            edtMaCS.Enabled = edtMaKH.Enabled = edtMaLop.Enabled = edtTenLop.Enabled = false;

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            menuItermThem.Enabled = menuItermXoa.Enabled = menuItermSua.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = btnPhucHoi.Enabled = btnHoanTac.Enabled = true;

            themSuaMap["SuaKhoa"] = true;
            themSuaMap["SuaLop"] = themSuaMap["ThemKhoa"] = themSuaMap["ThemLop"] = false;

            edtTenKhoa.Enabled = true;
        }

        private void menuItermSua_Click(object sender, EventArgs e)
        {
            vitri = bdsLop.Position;
            // UndoStack.Push("exec[dbo].[SP_UndoSuaMH] '" + txtMaMH.Text + "', N'"
            //   + txtTen.Text + "'");
            panelEdt.Enabled = edtTenLop.Enabled = true;
            gcKhoa.Enabled = gcLop.Enabled = false;
            edtMaCS.Enabled = edtMaKH.Enabled = edtMaLop.Enabled = edtTenKhoa.Enabled = false;

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            menuItermThem.Enabled = menuItermXoa.Enabled = menuItermSua.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = btnPhucHoi.Enabled = btnHoanTac.Enabled = true;

            themSuaMap["SuaLop"] = true;
            themSuaMap["SuaKhoa"] = themSuaMap["ThemKhoa"] = themSuaMap["ThemLop"] = false;

            cmbTenKhoa.Visible = true;
            string sql = "SELECT MAKH ,TENKH FROM KHOA";
            cmbTenKhoa.DataSource = Program.ExecSqlDataTable(sql);
            cmbTenKhoa.DisplayMember = "TENKH"; cmbTenKhoa.ValueMember = "MAKH";
            foreach (var item in cmbTenKhoa.Items)
            {
                if (((DataRowView)item)[cmbTenKhoa.ValueMember].ToString() == edtMaKH.Text)
                {
                    cmbTenKhoa.SelectedItem = item;
                    break;
                }
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsGV.Count != 0)
            {
                MessageBox.Show("Khoa đã có giáo viên, không thể xoá!", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }

            if (bdsLop.Count != 0)
            {
                MessageBox.Show("Khoa đã có lớp , không thể xoá!", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa Khoa: " + cmbTenKhoa.Text + " ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    vitri = bdsKhoa.Position;
                    // UndoStack.Push("exec[dbo].[SP_UndoXoaMH] '" + txtMaMH.Text + "', N'"
                    //     + txtTen.Text + "'");
                    bdsKhoa.RemoveCurrent();//xóa trên máy ht trc mới xóa trên data
                    this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                    this.kHOATableAdapter.Update(this.dS.KHOA);
                    btnPhucHoi.Enabled = true;
                }
                catch (Exception ex)
                {
                    //UndoStack.Pop();
                    MessageBox.Show("Lỗi xóa Khoa \n" + ex.Message, "", MessageBoxButtons.OK);
                    this.kHOATableAdapter.Fill(this.dS.KHOA);
                    bdsKhoa.Position = vitri;
                    return;
                }
                if (bdsKhoa.Count == 0)
                    btnXoa.Enabled = btnSua.Enabled = menuLop.Enabled = false;
            }
        }

        private void menuItermXoa_Click(object sender, EventArgs e)
        {
            if (bdsGVDK.Count != 0)
            {
                MessageBox.Show("Lớp đã có giáo viên đăng ký, không thể xoá!", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }

            if (bdsSV.Count != 0)
            {
                MessageBox.Show("Lớp đã có sinh viên , không thể xoá!", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa Lớp: " + edtTenLop.Text + " ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    vitri = bdsLop.Position;
                    // UndoStack.Push("exec[dbo].[SP_UndoXoaMH] '" + txtMaMH.Text + "', N'"
                    //     + txtTen.Text + "'");
                    bdsLop.RemoveCurrent();//xóa trên máy ht trc mới xóa trên data
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Update(this.dS.LOP);
                    btnPhucHoi.Enabled = true;
                }
                catch (Exception ex)
                {
                    //UndoStack.Pop();
                    MessageBox.Show("Lỗi xóa Lớp \n" + ex.Message, "", MessageBoxButtons.OK);
                    this.lOPTableAdapter.Fill(this.dS.LOP);
                    bdsLop.Position = vitri;
                    return;
                }
                if (bdsLop.Count == 0)
                    menuItermXoa.Enabled = menuItermSua.Enabled = false;
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (edtTenLop.Enabled && edtTenLop.Text == "")
            {
                MessageBox.Show("Tên lớp không được trống!", "Lỗi", MessageBoxButtons.OK);
                edtTenLop.Focus();
                return;
            }
            if (edtTenKhoa.Enabled && edtTenKhoa.Text == "")
            {
                MessageBox.Show("Tên khoa không được trống!", "Lỗi", MessageBoxButtons.OK);
                edtTenKhoa.Focus();
                return;
            }

            try
            {
                if (themSuaMap["ThemLop"])
                {
                    if (Program.ExecSqlNonQuery("exec [dbo].[SP_CheckTenLop] N'" + edtTenLop.Text + "'") != 0)
                    {
                        edtTenLop.Focus();
                        return;
                    }
                    string sql = "exec [dbo].[SP_ThemMaLop] @TENLOP";
                    Hashtable paras = new Hashtable();
                    paras.Add("@TENLOP", edtTenLop.Text);
                    DataTable dt = new DataTable();
                    dt = Program.ExecSqlDataTable(sql, paras);
                    edtMaLop.Text = dt.Rows[0][0].ToString();

                    edtKHOA_LOP.Text = cmbTenKhoa.SelectedValue.ToString();

                    bdsLop.EndEdit();
                    // cập nhật lại dữ liệu đang được hiển thị
                    bdsLop.ResetCurrentItem();
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Update(this.dS.LOP);

                    // UndoStack.Push("exec [dbo].[SP_UndoThemMH] '" + txtMaMH.Text + "'");
                }

                else if (themSuaMap["ThemKhoa"])
                {
                    if (Program.ExecSqlNonQuery("exec [dbo].[SP_CheckTenKhoa] N'" + edtTenKhoa.Text + "'") != 0)
                    {
                        edtTenKhoa.Focus();
                        return;
                    }
                    string sql = "exec [dbo].[SP_ThemMaKhoa] @TENKHOA";
                    Hashtable paras = new Hashtable();
                    paras.Add("@TENKHOA", edtTenKhoa.Text);
                    DataTable dt = new DataTable();
                    dt = Program.ExecSqlDataTable(sql, paras);
                    edtMaKH.Text = dt.Rows[0][0].ToString();

                    edtMaCS.Text = (Program.mCoso == 0) ? "CS1" : "CS2";

                    bdsKhoa.EndEdit();
                    // cập nhật lại dữ liệu đang được hiển thị
                    bdsKhoa.ResetCurrentItem();
                    this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                    this.kHOATableAdapter.Update(this.dS.KHOA);
                }

                else if (themSuaMap["SuaLop"])
                {
                    if (Program.ExecSqlNonQuery("exec [dbo].[SP_CheckTenLop] N'" + edtTenLop.Text + "'") != 0)
                    {
                        edtTenLop.Focus();
                        return;
                    }
                    edtKHOA_LOP.Text = cmbTenKhoa.SelectedValue.ToString();
                    bdsLop.EndEdit();
                    // cập nhật lại dữ liệu đang được hiển thị
                    bdsLop.ResetCurrentItem();
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Update(this.dS.LOP);
                }

                else if (themSuaMap["SuaKhoa"])
                {
                    if (Program.ExecSqlNonQuery("exec [dbo].[SP_CheckTenKhoa] N'" + edtTenKhoa.Text + "'") != 0)
                    {
                        edtTenKhoa.Focus();
                        return;
                    }
                    bdsKhoa.EndEdit();
                    // cập nhật lại dữ liệu đang được hiển thị
                    bdsKhoa.ResetCurrentItem();
                    this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                    this.kHOATableAdapter.Update(this.dS.KHOA);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi Lớp và Khoa\n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
                return;
            }
            PhanQuyen();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.kHOATableAdapter.Fill(this.dS.KHOA);
                this.lOPTableAdapter.Fill(this.dS.LOP);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            PhanQuyen();
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (themSuaMap["ThemKhoa"])     
                bdsKhoa.RemoveCurrent();
            else            
                bdsKhoa.CancelEdit();

            if (themSuaMap["ThemLop"])      
                bdsLop.RemoveCurrent();
            else                
                bdsLop.CancelEdit();

            if (themSuaMap["SuaLop"] == false)
                bdsLop.Position = vitri;

            if (themSuaMap["SuaKhoa"] == false)
                bdsKhoa.Position = vitri;

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
                dS.EnforceConstraints = false;
                this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                this.kHOATableAdapter.Fill(this.dS.KHOA);
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.dS.LOP);
                Program.mCoso = cmbCoSo.SelectedIndex;
            }
        }

        private void gridViewKhoa_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (bdsLop.Count == 0)
                menuItermXoa.Enabled = menuItermSua.Enabled = false;
            else
                menuItermXoa.Enabled = menuItermSua.Enabled = true;
        }
    }
}
