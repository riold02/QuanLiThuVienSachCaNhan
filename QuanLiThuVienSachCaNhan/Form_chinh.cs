using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace QuanLiThuVienSachCaNhan
{
    public partial class Form_chinh : Form
    {

        string connectstring = @"Data Source = Rio ;Initial Catalog = QLSachCaNhan; Integrated Security = True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dtbook = new DataTable();
        DataTable dtDSMuon = new DataTable();

        public Form_chinh()
        {
            InitializeComponent();

        }
        private void LoadBook()
        {
            dtbook = new DataTable();
            dtDSMuon = new DataTable();
            con = new SqlConnection(connectstring);
            try
            {
                con.Open();
                cmd = new SqlCommand("select * from Book", con);
                adt = new SqlDataAdapter(cmd);
                adt.Fill(dtbook);
                dataGridView1.DataSource = dtbook;

                cmd = new SqlCommand("select * from DanhSachMuon", con);
                adt = new SqlDataAdapter(cmd);
                adt.Fill(dtDSMuon);
                dataGridView2.DataSource = dtDSMuon;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Form_chinh_Load(object sender, EventArgs e)
        {
            LoadBook();
        }


        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {

        }


        private void báoCáoThốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_thongke frm = new frm_thongke();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemSach addBookForm = new ThemSach();

            addBookForm.ShowDialog();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listVSach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string filterValue = cbbTimKiem.SelectedItem.ToString();
            string query = "";

            if (filterValue == "TatCa")
            {
                query = $"SELECT * FROM Book WHERE TenSach LIKE N'%{txt_timkiem.Text}%' OR TacGia LIKE N'%{txt_timkiem.Text}%' OR MaSach LIKE N'%{txt_timkiem.Text}%' OR ChuDe LIKE N'%{txt_timkiem.Text}%' OR ViTri LIKE N'%{txt_timkiem.Text}%'";

            }
            else
            {
                query = $"SELECT * From book where {filterValue} LIKE N'%{txt_timkiem.Text}%' ";
            }


            try
            {
                using (SqlConnection con = new SqlConnection(connectstring))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataAdapter adt = new SqlDataAdapter(cmd);
                        DataTable dtFiltered = new DataTable();
                        adt.Fill(dtFiltered);
                        dataGridView1.DataSource = dtFiltered;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cbbTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cậpNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadBook();

        }
        private void DeleteBook(string maSach)
        {
            string query = "DELETE FROM Book WHERE maSach = @maSach";

            try
            {
                using (SqlConnection con = new SqlConnection(connectstring))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@maSach", maSach);
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa sách thành công!");
                            LoadBook();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy sách với mã đã cho.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa sách: " + ex.Message);
            }
        }
        private void xóaSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string maSach = selectedRow.Cells["maSach"].Value.ToString();


                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sách này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DeleteBook(maSach);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hàng cần xóa.");
            }
        }

        private void btnLoc2_Click(object sender, EventArgs e)
        {
            string filterValue = cbbTimKiem2.SelectedItem.ToString();
            string query = "";

            if (filterValue == "TatCa")
            {
                query = $"SELECT * FROM Book WHERE TenSach LIKE N'%{txt_timkiem2.Text}%' OR TacGia LIKE N'%{txt_timkiem2.Text}%' OR MaSach LIKE N'%{txt_timkiem2.Text}%' OR ChuDe LIKE N'%{txt_timkiem2.Text}%' OR ViTri LIKE N'%{txt_timkiem.Text}%'";

            }
            else
            {
                query = $"SELECT * From DanhsachMuon where {filterValue} LIKE N'%{txt_timkiem2.Text}%' ";
            }


            try
            {
                using (SqlConnection con = new SqlConnection(connectstring))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataAdapter adt = new SqlDataAdapter(cmd);
                        DataTable dtFiltered = new DataTable();
                        adt.Fill(dtFiltered);
                        dataGridView2.DataSource = dtFiltered;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void choMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Lấy dữ liệu từ hàng đó
                string maSach = selectedRow.Cells["MaSach"].Value.ToString();
                string tenSach = selectedRow.Cells["TenSach"].Value.ToString();
                Frm_ChoMuon form2 = new Frm_ChoMuon();
                form2.SetSach(maSach, tenSach);
                if (form2.ShowDialog() == DialogResult.OK)
                {

                    var thongtin = form2.LayTTSach();
                    using (SqlConnection connection = new SqlConnection(connectstring))
                    {
                        string query = "INSERT INTO DanhSachMuon (MaSach, TenSach, HoTen, TinhTrang, NgayMuon, NgayTra, SDT, DiaChi) " +
                          "VALUES (@MaSach, @TenSach, @HoTen, @TinhTrang, @NgayMuon, @NgayTra, @SDT, @DiaChi)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Gán giá trị cho các tham số
                            command.Parameters.AddWithValue("@MaSach", thongtin.Item1);
                            command.Parameters.AddWithValue("@TenSach", thongtin.Item2);
                            command.Parameters.AddWithValue("@HoTen", thongtin.Item3);
                            command.Parameters.AddWithValue("@TinhTrang", thongtin.Item6 != 0 ? 1 : 0);
                            command.Parameters.AddWithValue("@NgayMuon", thongtin.Item7);
                            command.Parameters.AddWithValue("@NgayTra", thongtin.Item8);
                            command.Parameters.AddWithValue("@SDT", thongtin.Item4);
                            command.Parameters.AddWithValue("@DiaChi", thongtin.Item5);

                            try
                            {
                                // Mở kết nối và thực thi câu lệnh
                                connection.Open();
                                int result = command.ExecuteNonQuery();


                                // Kiểm tra kết quả của câu lệnh
                                if (result > 0)
                                {
                                    MessageBox.Show("Thêm thông tin sách thành công!");
                                    LoadBook();
                                    con.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Không thêm được thông tin sách.");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Lỗi: " + ex.Message);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một hàng trước.");
                }
            }
        }
        private void ThemChuDeMenustrip_Click(object sender, EventArgs e)
        {
            FrmThemChuDe form = new FrmThemChuDe();

            if (form.ShowDialog() == DialogResult.OK)
            { 
                var temp = form.LayTTChuDe();
        
                 using (SqlConnection connection = new SqlConnection(connectstring))
                {
                   string query = "INSERT INTO Category (MaChuDe,Name)" +
                                "Values (@MaChuDe,@Name)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Gán giá trị cho các tham số
                        command.Parameters.AddWithValue("@Name", temp.Item1);
                        command.Parameters.AddWithValue("@MaChuDe", temp.Item2);
                    


                        try
                        {
                            // Mở kết nối và thực thi câu lệnh
                            connection.Open();
                            int result = command.ExecuteNonQuery();


                            // Kiểm tra kết quả của câu lệnh
                            if (result > 0)
                            {
                                MessageBox.Show("Thêm thông tin chủ đề thành công!");
                                LoadBook();
                               
                            }
                            else
                            {
                                MessageBox.Show("Không thêm được chủ đề.");
                            }
                            connection.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi: " + ex.Message);
                        }
                    }
                }
            }
        }

        private void DeleteSachMuon(int ID)
        {

           
            string query = "DELETE FROM DanhSachMuon WHERE ID = @ID";
            try
            {
                using (SqlConnection con = new SqlConnection(connectstring))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ID", ID);
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa sách thành công!");
                            LoadBook();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy sách với mã đã cho.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa sách: " + ex.Message);
            }
        }
        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];
                int IDMuon = Convert.ToInt32(selectedRow.Cells["ID"].Value);


                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sách này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DeleteSachMuon(IDMuon);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hàng cần xóa.");
            }
        }
    }
 }
 
