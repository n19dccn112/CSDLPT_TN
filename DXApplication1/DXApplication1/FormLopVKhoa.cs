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
    public partial class FormLopVKhoa : Form
    {
        private int vitri;
        Dictionary<String, Boolean> themSuaMap = new Dictionary<String, Boolean>();
       
        public FormLopVKhoa()
        {
            InitializeComponent();
        }
        private void FormLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.V_KhoaAddLop' table. You can move, or remove it, as needed.
            this.v_KhoaAddLopTableAdapter.Fill(this.dS.V_KhoaAddLop);
            themSuaMap.Add("ThemLop", false);
            themSuaMap.Add("SuaLop", false);
            themSuaMap.Add("ThemKhoa", false);
            themSuaMap.Add("SuaKhoa", false);

            dS.EnforceConstraints = false;
            this.v_KhoaAddLopTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_KhoaAddLopTableAdapter.Fill(this.dS.V_KhoaAddLop);

            cmbCoSo.DataSource = Program.bds_dspm;
            cmbCoSo.DisplayMember = "TENCS";
            cmbCoSo.ValueMember = "TENSERVER";
            cmbCoSo.SelectedIndex = Program.mCoso;

            if (Program.mGroup == "TRUONG")
            {
                cmbCoSo.Enabled = true;
                btnThemKhoa.Enabled = btnXoaKhoa.Enabled = btnSuaKhoa.Enabled = btnGhiKhoa.Enabled = btnPhucHoi.Enabled = btnHuy.Enabled = false;
                btnThemLop.Enabled = btnSuaLop.Enabled = btnXoaLop.Enabled = false;
            }
            else
            if (Program.mGroup == "GIANGVIEN")
            {

                cmbCoSo.Enabled = false;
                btnThemKhoa.Enabled = btnXoaKhoa.Enabled = btnSuaKhoa.Enabled = btnGhiKhoa.Enabled = btnPhucHoi.Enabled = false;
                btnThemLop.Enabled = btnSuaLop.Enabled = btnXoaLop.Enabled = false;
                btnHuy.Enabled = false;
            }
            else//CS
            {
                cmbCoSo.Enabled = false;
                btnReload.Enabled = btnThem.Enabled = btnXoaKhoa.Enabled = btnSuaKhoa.Enabled = true;
                btnPhucHoi.Enabled = btnGhiKhoa.Enabled = btnHuy.Enabled = false;
                btnThemLop.Enabled = btnSuaLop.Enabled = btnXoaLop.Enabled = true;
                if (bdsVKhoaVaLop.Count == 0)
                {
                    btnXoaKhoa.Enabled = false;
                    btnSuaKhoa.Enabled = false;
                }
                else
                {
                    btnXoaKhoa.Enabled = true;
                    btnSuaKhoa.Enabled = true;
                }
            }
            cmbTenKhoa.Visible = labelTenKhoa.Visible = false;
            btn_XacNhanXoa.Visible = txtAddTenKhoa.Visible = false;
        }
        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtTenLop.Enabled && txtTenLop.Text == "")
            {
                MessageBox.Show("Tên lớp không được trống!", "Lỗi", MessageBoxButtons.OK);
                txtTenLop.Focus();
                return;
            }
            if (txtTenKhoa.Enabled && txtTenKhoa.Text == "")
            {
                MessageBox.Show("Tên khoa không được trống!", "Lỗi", MessageBoxButtons.OK);
                txtTenKhoa.Focus();
                return;
            }

            try
            {
                if (themSuaMap["ThemLop"])
                {
                    if (Program.ExecSqlNonQuery("exec [dbo].[SP_CheckTenLop] N'" + txtTenLop.Text + "'") != 0)
                    {
                        txtMaLop.Focus();
                        return;
                    }
                    string sql = "exec [dbo].[SP_ThemMaLop] @TENLOP";
                    Hashtable paras = new Hashtable();
                    paras.Add("@TENLOP", txtTenLop.Text);
                    DataTable dt = new DataTable();
                    dt = Program.ExecSqlDataTable(sql, paras);
                    txtMaLop.Text = dt.Rows[0][0].ToString();

                    txtMaKhoa.Text = cmbTenKhoa.SelectedValue.ToString();
                    txtTenKhoa.Text = cmbTenKhoa.Text;
                    txtMaCS.Text = Program.ExecSqlDataTable("SELECT MACS FROM KHOA WHERE MAKH=N'" + txtMaKhoa.Text + "'").Rows[0][0].ToString();

                    bdsVKhoaVaLop.EndEdit();
                    bdsVKhoaVaLop.ResetCurrentItem();
                    this.v_KhoaAddLopTableAdapter.Connection.ConnectionString = Program.connstr;
                    string sqlInsertLop = "INSERT INTO LOP(MALOP, TENLOP, MAKH) VALUES(N'" + txtMaLop.Text + "' , N'" + txtTenLop.Text + "' , N'" + txtMaKhoa.Text + "')";
                    if (Program.ExecSqlNonQuery(sqlInsertLop) != 0)
                    {
                        MessageBox.Show("thêm Lớp thất bại ", "", MessageBoxButtons.OK);
                        return;
                    }
                    MessageBox.Show("Đã thêm Lớp thành công", "", MessageBoxButtons.OK);
                  
                    // UndoStack.Push("exec [dbo].[SP_UndoThemMH] '" + txtMaMH.Text + "'");
                }

                else if (themSuaMap["ThemKhoa"])
                {
                    if (Program.ExecSqlNonQuery("exec [dbo].[SP_CheckTenKhoa] N'" + txtAddTenKhoa.Text + "'") != 0)
                    {
                        txtMaKhoa.Focus();
                        return;
                    }
                    string sql = "exec [dbo].[SP_ThemMaKhoa] @TENKHOA";
                    Hashtable paras = new Hashtable();
                    paras.Add("@TENKHOA", txtAddTenKhoa.Text);
                    DataTable dt = new DataTable();
                    dt = Program.ExecSqlDataTable(sql, paras);
                    String maKhoa = dt.Rows[0][0].ToString();

                    txtMaCS.Text = (Program.mCoso == 0) ? "CS1" : "CS2";

                    //bdsVKhoaVaLop.EndEdit();
                    //bdsVKhoaVaLop.ResetCurrentItem();
                    this.v_KhoaAddLopTableAdapter.Connection.ConnectionString = Program.connstr;
                    string sqlInsertKhoa = "INSERT INTO KHOA(MAKH, TENKH, MACS) VALUES(N'" + maKhoa + "' , N'" + txtAddTenKhoa.Text + "' , N'" + txtMaCS.Text + "')";
                    if (Program.ExecSqlNonQuery(sqlInsertKhoa) != 0)
                    {
                        MessageBox.Show("Update Khoa thất bại", "", MessageBoxButtons.OK);
                        return;
                    }

                    MessageBox.Show("Đã thêm Khoa thành công", "", MessageBoxButtons.OK);
                }

                else if (themSuaMap["SuaLop"])
                {
                    if (Program.ExecSqlNonQuery("exec [dbo].[SP_CheckTenLop] N'" + txtTenLop.Text + "'") != 0)
                    {
                        txtMaLop.Focus();
                        return;
                    }
                    txtMaKhoa.Text = cmbTenKhoa.SelectedValue.ToString();
                    txtTenKhoa.Text = cmbTenKhoa.Text;
                    txtMaCS.Text = Program.ExecSqlDataTable("SELECT MACS FROM KHOA WHERE MAKH=N'" + txtMaKhoa.Text + "'").Rows[0][0].ToString();

                    bdsVKhoaVaLop.EndEdit();
                    bdsVKhoaVaLop.ResetCurrentItem();
                    this.v_KhoaAddLopTableAdapter.Connection.ConnectionString = Program.connstr;
                    string sqlUpdateLop = "UPDATE LOP SET TENLOP = N'" + txtTenLop.Text + "' , MAKH = N'" + txtMaKhoa.Text + "' WHERE MALOP = N'" + txtMaLop.Text + "'";
                    if (Program.ExecSqlNonQuery(sqlUpdateLop) != 0)
                    {
                        MessageBox.Show("Update Lớp thất bại ", "", MessageBoxButtons.OK);
                        return;
                    }
                     MessageBox.Show("Đã sửa Lớp thành công thành công", "", MessageBoxButtons.OK);
                }

                else if (themSuaMap["SuaKhoa"])
                {
                    if (Program.ExecSqlNonQuery("exec [dbo].[SP_CheckTenKhoa] N'" + txtTenKhoa.Text + "'") != 0)
                    {
                        txtMaKhoa.Focus();
                        return;
                    }

                    //bdsVKhoaVaLop.EndEdit();
                    //bdsVKhoaVaLop.ResetCurrentItem();
                    this.v_KhoaAddLopTableAdapter.Connection.ConnectionString = Program.connstr;

                    string sqlUpdateKhoa = "UPDATE KHOA \nSET TENKH = N'" + txtTenKhoa.Text + "' \nWHERE MAKH = N'" + txtMaKhoa.Text + "'";
                    if (Program.ExecSqlNonQuery(sqlUpdateKhoa) != 0)
                    {
                        MessageBox.Show("Update Khoa thất bại", "", MessageBoxButtons.OK);
                        return;
                    }
                    this.v_KhoaAddLopTableAdapter.Fill(this.dS.V_KhoaAddLop);
                    MessageBox.Show("Đã sửa Khoa thành công thành công", "", MessageBoxButtons.OK);
                }        
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi Lớp và Khoa\n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
                return;
            }

            btnThemKhoa.Enabled = btnXoaKhoa.Enabled = btnSuaKhoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnPhucHoi.Enabled = btnThemLop.Enabled = btnSuaLop.Enabled = btnXoaLop.Enabled = true;
            btnHuy.Enabled = btnGhiKhoa.Enabled = false;
            gbKhoaVaLop.Enabled = false;
            gcVLopVaKhoa.Enabled = true;
            txtAddTenKhoa.Visible = cmbTenKhoa.Visible = labelTenKhoa.Visible = btn_XacNhanXoa.Visible = false;
        }
        private void btnThemLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsVKhoaVaLop.Position;
            gbKhoaVaLop.Enabled = true;
            txtMaCS.Enabled = txtMaKhoa.Enabled = txtMaLop.Enabled = txtTenKhoa.Enabled = false;
            txtTenLop.Enabled = true;
            bdsVKhoaVaLop.AddNew(); //them sp mới vào ds

            btnThemKhoa.Enabled = btnSuaKhoa.Enabled = btnXoaKhoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnThemLop.Enabled = btnSuaLop.Enabled = btnXoaLop.Enabled = false;
            btnGhiKhoa.Enabled = btnHuy.Enabled = btnPhucHoi.Enabled = btnHoanTac.Enabled = true;

            gcVLopVaKhoa.Enabled = false;

            themSuaMap["ThemLop"] = true;
            themSuaMap["ThemKhoa"] = themSuaMap["SuaLop"] = themSuaMap["SuaKhoa"] = false;

            cmbTenKhoa.Visible = labelTenKhoa.Visible = true;
            string sql = "SELECT MAKH ,TENKH FROM KHOA";
            cmbTenKhoa.DataSource = Program.ExecSqlDataTable(sql);
            cmbTenKhoa.DisplayMember = "TENKH"; cmbTenKhoa.ValueMember = "MAKH";
        }
        private void btnThemKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsVKhoaVaLop.Position;
            gbKhoaVaLop.Enabled = true;
            txtMaCS.Enabled = txtMaKhoa.Enabled = txtMaLop.Enabled = txtTenLop.Enabled = txtTenKhoa.Enabled =  false;
            txtAddTenKhoa.Visible = true;

            //bdsVKhoaVaLop.AddNew(); //them sp mới vào ds

            btnThemKhoa.Enabled = btnSuaKhoa.Enabled = btnXoaKhoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnThemLop.Enabled = btnSuaLop.Enabled = btnXoaLop.Enabled = false;
            btnGhiKhoa.Enabled = btnHuy.Enabled = btnPhucHoi.Enabled = btnHoanTac.Enabled = true;

            gcVLopVaKhoa.Enabled = false;
            themSuaMap["ThemKhoa"] = true;
            themSuaMap["ThemLop"] = themSuaMap["ThemLop"] = themSuaMap["SuaLop"] = false;
        }
        private void btnSuaLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsVKhoaVaLop.Position;
            // UndoStack.Push("exec[dbo].[SP_UndoSuaMH] '" + txtMaMH.Text + "', N'"
            //   + txtTen.Text + "'");
            gbKhoaVaLop.Enabled = txtTenLop.Enabled = true;
            gcVLopVaKhoa.Enabled = false;
            txtMaCS.Enabled = txtMaKhoa.Enabled = txtMaLop.Enabled = txtTenKhoa.Enabled = false;

            btnThemKhoa.Enabled = btnSuaKhoa.Enabled = btnXoaKhoa.Enabled = btnThoat.Enabled = btnReload.Enabled = false;
            btnThemLop.Enabled = btnSuaLop.Enabled = btnXoaLop.Enabled = false;
            btnGhiKhoa.Enabled = btnHuy.Enabled = btnPhucHoi.Enabled = btnHoanTac.Enabled = true;

            themSuaMap["SuaLop"] = true;
            themSuaMap["SuaKhoa"] = themSuaMap["ThemKhoa"] = themSuaMap["ThemLop"] = false;

            cmbTenKhoa.Visible = labelTenKhoa.Visible = true;
            string sql = "SELECT MAKH ,TENKH FROM KHOA";
            cmbTenKhoa.DataSource = Program.ExecSqlDataTable(sql);
            cmbTenKhoa.DisplayMember = "TENKH"; cmbTenKhoa.ValueMember = "MAKH";
        }
        private void btnSuaKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsVKhoaVaLop.Position;
            // UndoStack.Push("exec[dbo].[SP_UndoSuaMH] '" + txtMaMH.Text + "', N'"
            //   + txtTen.Text + "'");
            gbKhoaVaLop.Enabled = true;
            gcVLopVaKhoa.Enabled = false;
            txtMaCS.Enabled = txtMaKhoa.Enabled = txtMaLop.Enabled = txtTenLop.Enabled = false;

            btnThemKhoa.Enabled = btnSuaKhoa.Enabled = btnXoaKhoa.Enabled = btnThoat.Enabled = btnReload.Enabled = false;
            btnThemLop.Enabled = btnSuaLop.Enabled = btnXoaLop.Enabled = false;
            btnGhiKhoa.Enabled = btnHuy.Enabled = btnPhucHoi.Enabled = btnHoanTac.Enabled = true;
            
            themSuaMap["SuaKhoa"] = true;
            themSuaMap["SuaLop"] = themSuaMap["ThemKhoa"] = themSuaMap["ThemLop"] = false;

            txtTenKhoa.Enabled = true;
        }
        private void btnXoaLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string sqlGvdk = "SELECT COUNT(MALOP) FROM  dbo.GIAOVIEN_DANGKY WHERE MALOP = N'" + txtMaLop.Text + "'";
            if ((int)Program.ExecSqlDataTable(sqlGvdk).Rows[0][0] != 0)
            {
                MessageBox.Show("Lớp đã có giáo viên đăng kí, không thể xoá!", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }

            string sqlSV = "SELECT COUNT(MALOP) FROM  dbo.SINHVIEN WHERE MALOP = N'" + txtMaLop.Text + "'";
            if ((int)Program.ExecSqlDataTable(sqlSV).Rows[0][0] != 0)
            {
                MessageBox.Show("Lớp đã có sinh viên, không thể xoá!", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa Lớp học: " + txtTenLop.Text + " ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    vitri = bdsVKhoaVaLop.Position;
                    // UndoStack.Push("exec[dbo].[SP_UndoXoaMH] '" + txtMaMH.Text + "', N'"
                    //     + txtTen.Text + "'");
                    bdsVKhoaVaLop.RemoveCurrent();//xóa trên máy ht trc mới xóa trên data
                    this.v_KhoaAddLopTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.v_KhoaAddLopTableAdapter.Connection.ConnectionString = Program.connstr;
                    if (Program.ExecSqlNonQuery("DELETE FROM LOP WHERE MALOP= N'" + txtMaLop.Text + "'") != 0)
                    {
                        MessageBox.Show("Xóa Lớp thất bại", "", MessageBoxButtons.OK);
                        return;
                    }
                    //this.v_KhoaAddLopTableAdapter.Update(this.dS.MONHOC);
                    btnPhucHoi.Enabled = true;

                }
                catch (Exception ex)
                {
                    //UndoStack.Pop();
                    MessageBox.Show("Lỗi xóa Lớp học \n" + ex.Message, "", MessageBoxButtons.OK);
                    this.v_KhoaAddLopTableAdapter.Fill(this.dS.V_KhoaAddLop);
                    bdsVKhoaVaLop.Position = vitri;
                    return;
                }

            }
            if (bdsVKhoaVaLop.Count == 0)
            {
                btnXoaKhoa.Enabled = btnSuaKhoa.Enabled = btnSuaLop.Enabled = btnXoaLop.Enabled = false;
            }
        }
        private void btnXoaKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cmbTenKhoa.Visible = labelTenKhoa.Visible = btn_XacNhanXoa.Visible = gbKhoaVaLop.Enabled = true;
            string sql = "SELECT MAKH ,TENKH FROM KHOA";
            cmbTenKhoa.DataSource = Program.ExecSqlDataTable(sql);
            cmbTenKhoa.DisplayMember = "TENKH"; cmbTenKhoa.ValueMember = "MAKH";
            txtMaCS.Enabled = txtMaKhoa.Enabled = txtMaLop.Enabled = txtTenLop.Enabled = txtTenKhoa.Enabled = false;

            gcVLopVaKhoa.Enabled = false;
            btnThemKhoa.Enabled = btnSuaKhoa.Enabled = btnXoaKhoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnThemLop.Enabled = btnSuaLop.Enabled = btnXoaLop.Enabled = btnGhiKhoa.Enabled = false;
            btnHuy.Enabled = btnPhucHoi.Enabled = btnHoanTac.Enabled = btnThem.Enabled = true;
        }
        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.v_KhoaAddLopTableAdapter.Fill(this.dS.V_KhoaAddLop);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            if (bdsVKhoaVaLop.Count == 0)
                btnXoaKhoa.Enabled = btnSuaKhoa.Enabled = btnSuaLop.Enabled = btnXoaLop.Enabled = false;
        }
        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (themSuaMap["ThemKhoa"] || themSuaMap["ThemLop"]) 
                bdsVKhoaVaLop.RemoveCurrent();
            else bdsVKhoaVaLop.CancelEdit();
            if (themSuaMap["SuaLop"] == false || themSuaMap["SuaKhoa"] == false)
                bdsVKhoaVaLop.Position = vitri;
            btnThemKhoa.Enabled = btnSuaKhoa.Enabled = btnXoaKhoa.Enabled = btnThoat.Enabled = btnReload.Enabled = true;
            btnThemLop.Enabled = btnSuaLop.Enabled = btnXoaLop.Enabled = true;
            gbKhoaVaLop.Enabled = false;
            txtAddTenKhoa.Visible = cmbTenKhoa.Visible = labelTenKhoa.Visible = btn_XacNhanXoa.Visible = false;
            gcVLopVaKhoa.Enabled = true;
            //if (UndoStack.Count > 0) { UndoStack.Pop(); btnPhucHoi.Enabled = true; }
        }
        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát khỏi form?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }
        private void btn_XacNhanXoa_Click(object sender, EventArgs e)
        {
            String cmbKhoa  = cmbTenKhoa.SelectedValue.ToString();
            string sqlGvdk = "SELECT COUNT(MAKH) FROM  dbo.GIAOVIEN WHERE MAKH = N'" + cmbKhoa + "'";
            if ((int)Program.ExecSqlDataTable(sqlGvdk).Rows[0][0] != 0)
            {
                MessageBox.Show("Khoa đã có giáo viên, không thể xoá!", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }

            string sqlLop = "SELECT COUNT(MAKH) FROM  dbo.LOP WHERE MAKH = N'" + cmbKhoa + "'";
            if ((int)Program.ExecSqlDataTable(sqlLop).Rows[0][0] != 0)
            {
                MessageBox.Show("Khoa đã có lớp , không thể xoá!", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa Khoa: " + cmbTenKhoa.Text + " ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    vitri = bdsVKhoaVaLop.Position;
                    // UndoStack.Push("exec[dbo].[SP_UndoXoaMH] '" + txtMaMH.Text + "', N'"
                    //     + txtTen.Text + "'");
                    bdsVKhoaVaLop.RemoveCurrent();//xóa trên máy ht trc mới xóa trên data
                    this.v_KhoaAddLopTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.v_KhoaAddLopTableAdapter.Connection.ConnectionString = Program.connstr;
                    if (Program.ExecSqlNonQuery("DELETE FROM KHOA WHERE MAKH = N'" + cmbKhoa + "'") != 0)
                    {
                        MessageBox.Show("Xóa Khoa thất bại", "", MessageBoxButtons.OK);
                        return;
                    }
                    //this.v_KhoaAddLopTableAdapter.Update(this.dS.MONHOC);
                    btnPhucHoi.Enabled = true;

                }
                catch (Exception ex)
                {
                    //UndoStack.Pop();
                    MessageBox.Show("Lỗi xóa Khoa \n" + ex.Message, "", MessageBoxButtons.OK);
                    this.v_KhoaAddLopTableAdapter.Fill(this.dS.V_KhoaAddLop);
                    bdsVKhoaVaLop.Position = vitri;
                    return;
                }

            }

            cmbTenKhoa.Visible = labelTenKhoa.Visible = btn_XacNhanXoa.Visible = gbKhoaVaLop.Enabled = false;

            gcVLopVaKhoa.Enabled = true;
            btnThemKhoa.Enabled = btnSuaKhoa.Enabled = btnXoaKhoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnThemLop.Enabled = btnSuaLop.Enabled = btnXoaLop.Enabled = btnGhiKhoa.Enabled = true;
            btnHuy.Enabled = btnPhucHoi.Enabled = btnHoanTac.Enabled = btnThem.Enabled = true;

            if (bdsVKhoaVaLop.Count == 0)
            {
                btnXoaKhoa.Enabled = btnSuaKhoa.Enabled = btnSuaLop.Enabled = btnXoaLop.Enabled = false;
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

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("mlogin: " + cmbCoSo.SelectedIndex + ", pass: " + Program.mCoso);
                MessageBox.Show("Lỗi kết nối về cơ sở mới!");
            }
            else
            {

                dS.EnforceConstraints = false;
                dS.EnforceConstraints = false;
                this.v_KhoaAddLopTableAdapter.Connection.ConnectionString = Program.connstr;
                this.v_KhoaAddLopTableAdapter.Fill(this.dS.V_KhoaAddLop);
            }
        }


        private void gcVKhoaVaLop_Click(object sender, EventArgs e)
        {
            if (bdsVKhoaVaLop.Count == 0 || Program.mGroup == "TRUONG" || Program.mGroup == "GIANGVIEN")
            {
                btnXoaKhoa.Enabled = btnXoaLop.Enabled = btnSuaKhoa.Enabled = btnXoaKhoa.Enabled = false;
            }
            else
            {
                btnXoaKhoa.Enabled = btnXoaLop.Enabled = btnSuaKhoa.Enabled = btnXoaKhoa.Enabled = true;
            }
        }
    }
}
