using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeToan
{
    public class ConnectSQLServer
    {
        // Thông tin        
        public static string tengd = "";
        public static string tenktt = "";

        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dt = new DataTable();
        // khai báo để biết thêm hay sửa
        public static string _so = "";
        public static int _them = 3;
        public static int _sua = 3;
        public static int _check = 1;
        public static string tableName = "";
        // Lấy các biến dùng chung
        public static string ten_DN = "";
        public static int Check_DN = 0;
        public static string Chuoi_KN = "";
        public static string ten_CSDL = "";
        //Lấy thông tin doang nghiệp
        public static string BC_TENDN = "";
        public static string BC_DiaChiDN = "";
        public static string BC_MaSoThue = "";
        // Lấy ID để load lại dữ liệu
        public static int iD = 0;
        // Lấy Id, Mã để xử lý phần thêm
        public static int iDKtra_LoadLai = 0;

        // Khai báo thông tin kết nối
        public static string Servername = "VIETDUC\\SQLEXPRESS";
        public static string Usersql = "sa";
        public static string Passsql = "123456";
        public static string Database = "VTSX";

        //Kết nối C# đến SQL Server
        public SqlConnection Ketnoi1()
        {
            try
            {
                Servername = "VIETDUC\\SQLEXPRESS";
                Usersql = "sa";
                Passsql = "123456";
                Database = "VTSX";

                Chuoi_KN = @"Data Source=" + Servername + ";Initial Catalog=" + Database + ";User ID=" + Usersql + ";Password=" + Passsql + "";

                string strconn = Chuoi_KN;
                SqlConnection con = new SqlConnection();
                if (con.State == ConnectionState.Closed)
                    con.Open();
                return con;
            }
            catch (Exception)
            {
                //MessageBox.Show("Lỗi: " + ex.Message);
                return null;
            }
        }

        // lấy ra một bảng dữ liệu
        public DataTable laybang(string s1)
        {
            DataTable dt = new DataTable();
            SqlConnection con = Ketnoi1();
            //       string s1 = "SELECT Ma, Ten FROM dmtk";
            cmd.CommandText = s1;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            adt.SelectCommand = cmd;
            adt.Fill(dt);
            return dt;
        }

        // Kiểm tra thực thi các câu lệnh SQL
        public bool Kiemtrathucthilenh(string s1)
        {
            int ktra = 0;
            SqlConnection con = Ketnoi1();
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                cmd.Connection = con;
                cmd.CommandText = s1;
                ktra = cmd.ExecuteNonQuery();
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            catch (Exception)
            {
                //MessageBox.Show("Lỗi: " + ex.Message);
            }
            if (ktra > 0)
                return true;
            return false;
        }

        //Kiểm tra tính duy nhất, sử dụng trong trường hợp kiểm tra thêm mới, trả về true nếu có và false nếu không
        public bool Kiemtratinhduynhat(string tenbang, string tentruong, string giatri)
        {
            string strsql1 = "SELECT * FROM " + tenbang + " WHERE " + tentruong + " =  N'" + giatri + "'";
            DataTable dtkiemtratinhduynhat = new DataTable();
            dtkiemtratinhduynhat = laybang(strsql1);
            if (dtkiemtratinhduynhat.Rows.Count > 0)
                return true;
            return false;
        }

        //Kiểm tra tính duy nhất với khóa là 2 trường, sử dụng trong trường hợp kiểm tra thêm mới, trả về true nếu có và false nếu không
        public bool Kiemtratinhduynhat(string tenbang, string tentruong1, string giatri1, string tentruong2, string giatri2)
        {
            string strsql1 = "SELECT * FROM " + tenbang + " WHERE " + tentruong1 + " =  N'" + giatri1 + "'";
            strsql1 = strsql1 + " AND " + tentruong2 + " = N'" + giatri2 + "'";
            DataTable dtkiemtratinhduynhat = new DataTable();
            dtkiemtratinhduynhat = laybang(strsql1);
            if (dtkiemtratinhduynhat.Rows.Count > 0)
                return true;
            return false;
        }

        // Lấy một giá trị
        public string GiaTriTraVe(string s1)
        {
            SqlConnection con = Ketnoi1();
            if (con.State == ConnectionState.Closed)
                con.Open();
            cmd.CommandText = s1;
            cmd.Connection = con;
            string kq = cmd.ExecuteScalar().ToString();
            con.Close();
            cmd.Dispose();
            return kq;
        }

        // Lấy giá trị cho các cột
        public string GiaTriTraVe(string tenbang, string tentruong, string khoa, string giatri)
        {
            try
            {
                SqlConnection con = Ketnoi1();
                if (con.State == ConnectionState.Closed)
                    con.Open();
                cmd.CommandText = "SELECT rtrim(" + tentruong + ") as " + tentruong + " FROM " + tenbang + " WHERE " + khoa + " = N'" + giatri.Trim() + "'";
                cmd.Connection = con;
                string kq = cmd.ExecuteScalar().ToString();
                con.Close();
                cmd.Dispose();
                return kq;
            }
            catch
            {
                return "0";
            }
        }

        // Lấy giá trị cho các cột
        public string GiaTriTraVe(string tenbang, string tentruong, string khoa, int giatri)
        {
            try
            {
                SqlConnection con = Ketnoi1();
                if (con.State == ConnectionState.Closed)
                    con.Open();
                cmd.CommandText = "SELECT " + tentruong + " FROM " + tenbang + " WHERE " + khoa + " = " + giatri + "";
                cmd.Connection = con;
                string kq = cmd.ExecuteScalar().ToString();
                con.Close();
                cmd.Dispose();
                return kq;
            }
            catch
            {
                return "0";
            }
        }

        // Lấy giá trị MAX cho các cột
        public string GiaTriTraVe(string tenbang, string tentruong)
        {
            try
            {
                SqlConnection con = Ketnoi1();
                if (con.State == ConnectionState.Closed)
                    con.Open();
                cmd.CommandText = "SELECT TOP 1 " + tentruong + " FROM " + tenbang + " ORDER BY " + tentruong + " DESC";
                cmd.Connection = con;
                string kq = cmd.ExecuteScalar().ToString();
                con.Close();
                cmd.Dispose();
                return kq;
            }
            catch
            {
                return "0";
            }
        }
        // thực thi thủ tục thêm, sửa, xóa dữ liệu. gọi thủ tục lên sổ & báo cáo
        public static DataSet GetDataSetProc(string ProcName, SqlParameter[] para, int npara)
        {
            try
            {
                DataSet dtct = new DataSet();
                if (_check == 1)
                    return dtct;
                SqlConnection con = SqlConnect.connect.ketnoi();
                SqlCommand cmd = new SqlCommand();
                cmd = con.CreateCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                cmd.CommandText = ProcName;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                for (int i = 0; i < npara; i++)
                {
                    cmd.Parameters.Add(para[i]);
                }
                da = new SqlDataAdapter(cmd);
                //da.Fill(dtct);
            }
            catch (Exception ex)
            {
                return null;
            }
            return null;
        }
        // Thực thi câu lênh thêm dữ liệu
        public bool them(string tenbang, string atentruong, string agiatri)
        {
            string str = "";
            str = str + "INSERT INTO " + tenbang + "(";
            str += atentruong;
            str += ") VALUES (";
            str += agiatri;
            str += ")";
            bool ktra = Kiemtrathucthilenh(str);
            return ktra;
        }
        // Thực thi câu lênh chèn dữ liệu có kiểm tra dữ liệu
        public bool them(string tenbang, string atentruong, string agiatri, string tentruong, string giatri, bool duynhat)
        {
            SqlConnection con = Ketnoi1();
            if (con.State == ConnectionState.Closed)
                con.Open();
            try
            {
                if (Kiemtratinhduynhat(tenbang, tentruong, giatri) == true)
                {
                    //   MessageBox.Show("Đã tồn tại mã này, nhập lại mã khác");
                    return false;
                }
                else
                {
                    try
                    {
                        string str = "";
                        str = str + "INSERT INTO " + tenbang + "(";
                        str += atentruong;
                        str += ") VALUES (";
                        str += agiatri;
                        str += ")";
                        bool ktra = Kiemtrathucthilenh(str);
                        return ktra;
                    }
                    catch (Exception)
                    {
                        //MessageBox.Show("Lỗi: " + ex.Message);
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
        }
        // Thực thi câu lênh chèn dữ liệu có kiểm tra dữ liệu, chứng từ chi tiết vật tưu
        public bool them(string tenbang, string atentruong, string agiatri, string tentruong1, string giatri1, string tentruong2, string giatri2, bool duynhat)
        {
            SqlConnection con = Ketnoi1();
            if (con.State == ConnectionState.Closed)
                con.Open();
            try
            {
                if (Kiemtratinhduynhat(tenbang, tentruong1, giatri2, tentruong2, giatri2) == true)
                {
                    //       MessageBox.Show("Đã tồn tại mã này, nhập lại mã khác");
                    return false;
                }
                else
                {
                    try
                    {
                        string str = "";
                        str = str + "INSERT INTO " + tenbang + "(";
                        str += atentruong;
                        str += ") VALUES (";
                        str += agiatri;
                        str += ")";
                        bool ktra = Kiemtrathucthilenh(str);
                        return ktra;
                    }
                    catch (Exception)
                    {
                        //MessageBox.Show("Lỗi: " + ex.Message);
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
        }
        // Thực thi câu lệnh update
        public bool sua(string tenbang, string acapnhat, string tentruong, string giatri)
        {
            try
            {
                string str = "";
                str = str + "UPDATE " + tenbang + " SET ";
                str += acapnhat;
                str += " WHERE ";
                str += tentruong + " = '" + giatri + "'";
                bool ktra = Kiemtrathucthilenh(str);
                return ktra;
            }
            catch (Exception)
            {
                //MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
        }
        // Thực thi câu lệnh update
        public bool sua(string tenbang, string acapnhat, string tentruong, int giatri)
        {
            try
            {
                string str = "";
                str = str + "UPDATE " + tenbang + " SET ";
                str += acapnhat;
                str += " WHERE ";
                str += tentruong + " = " + giatri;
                bool ktra = Kiemtrathucthilenh(str);
                return ktra;
            }
            catch (Exception)
            {
                //    MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
        }
        // Thực thi câu lệnh xóa
        public bool xoa(string tenbang, string tentruong, string giatri)
        {
            try
            {
                string str = "";
                str = str + "DELETE FROM " + tenbang + " WHERE ";
                str += tentruong + " = '" + giatri + "'";
                bool ktra = Kiemtrathucthilenh(str);
                return ktra;
            }
            catch (Exception)
            {
                //MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
        }
        // Thực thi câu lệnh xóa
        public bool xoa(string tenbang, string tentruong, int giatri)
        {
            try
            {
                string str = "";
                str = str + "DELETE FROM " + tenbang + " WHERE ";
                str += tentruong + " = " + giatri;
                bool ktra = Kiemtrathucthilenh(str);
                return ktra;
            }
            catch (Exception)
            {
                // MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
        }
        // Thực thi ngày tháng năm
        public string ngaythang(DateTime d1, DateTime d2)
        {
            string _bc = "";
            if (d1.Day != 1)
            {
                _bc = "Từ ngày " + d1.ToString("dd/MM/yyyy") + " đến ngày " + d2.ToString("dd/MM/yyyy");
            }
            else if (d1 == d2.AddDays(1).AddMonths(-1))
            {
                _bc = "Tháng " + d1.ToString("MM") + " năm " + d1.ToString("yyyy");
            }
            else if (d1.Year == d2.Year && d1.Month == 1 && d2.Month == 12 && d2.Day == 31)
            {
                _bc = "Năm " + d2.ToString("yyyy");
            }
            else if (d1.Month == 1 && d2.Day == 31 && d2.Month == 3)
            {
                _bc = "Quý I năm " + d2.ToString("yyyy");
            }
            else if (d1.Month == 4 && d2.Day == 30 && d2.Month == 6)
            {
                _bc = "Quý II năm " + d2.ToString("yyyy");
            }
            else if (d1.Month == 7 && d2.Day == 30 && d2.Month == 9)
            {
                _bc = "Quý III năm " + d2.ToString("yyyy");
            }
            else if (d1.Month == 10 && d2.Day == 31 && d2.Month == 12)
            {
                _bc = "Quý IV năm " + d2.ToString("yyyy");
            }
            else
            {
                _bc = "Từ ngày " + d1.ToString("dd/MM/yyyy") + " đến ngày " + d2.ToString("dd/MM/yyyy");
            }
            return _bc;
        }
        // Thực thi hàm đọc tiền
        public string doctien(double number)
        {
            string s = number.ToString("#");
            string[] so = new string[] { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] hang = new string[] { "", "nghìn", "triệu", "tỷ" };
            int i, j, donvi, chuc, tram;
            string str = " ";
            bool booAm = false;
            double decS = 0;
            //Tung addnew
            try
            {
                decS = Convert.ToDouble(s.ToString());
            }
            catch
            {
            }
            if (decS < 0)
            {
                decS = -decS;
                s = decS.ToString();
                booAm = true;
            }
            i = s.Length;
            if (i == 0)
                str = so[0] + str;
            else
            {
                j = 0;
                while (i > 0)
                {
                    donvi = Convert.ToInt32(s.Substring(i - 1, 1));
                    i--;
                    if (i > 0)
                        chuc = Convert.ToInt32(s.Substring(i - 1, 1));
                    else
                        chuc = -1;
                    i--;
                    if (i > 0)
                        tram = Convert.ToInt32(s.Substring(i - 1, 1));
                    else
                        tram = -1;
                    i--;
                    if ((donvi > 0) || (chuc > 0) || (tram > 0) || (j == 3))
                        str = hang[j] + str;
                    j++;
                    if (j > 3) j = 1;
                    if ((donvi == 1) && (chuc > 1))
                        str = "một " + str;
                    else
                    {
                        if ((donvi == 5) && (chuc > 0))
                            str = "lăm " + str;
                        else if (donvi > 0)
                            str = so[donvi] + " " + str;
                    }
                    if (chuc < 0)
                        break;
                    else
                    {
                        if ((chuc == 0) && (donvi > 0)) str = "lẻ " + str;
                        if (chuc == 1) str = "mười " + str;
                        if (chuc > 1) str = so[chuc] + " mươi " + str;
                    }
                    if (tram < 0) break;
                    else
                    {
                        if ((tram > 0) || (chuc > 0) || (donvi > 0)) str = so[tram] + " trăm " + str;
                    }
                    str = " " + str;
                }
            }
            if (booAm) str = "Âm " + str;
            return str + "đồng chẵn";
        }
        // Thực thi hàm số phiếu tự tăng
        public string abc(string tenbang, string tiento)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection con = Ketnoi1();
            cmd = con.CreateCommand();
            // con.Open();
            DataTable dtct = new DataTable();
            SqlDataAdapter da = null;
            cmd.CommandText = "usp_Chung_Tu_So_TT";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Ten_Bang", tenbang);
            cmd.Parameters.AddWithValue("@Tien_To", tiento);
            da = new SqlDataAdapter(cmd);
            da.Fill(dtct);
            string _sp = dtct.Rows[0][0].ToString();
            return _sp;
        }

        public static void GetDefault()
        {
            // khai báo đường dẫn Logo
            SqlConnect.connect.imgLogo = @"D:\DoAn\KeToan\Icons\anh.png";
            // Khai báo đường dẫn kết nối
                                                                                                                                                             if (Usersql != "") SqlConnect.connect.WriteRegKey("Login", "SQLUser", Usersql); if (Passsql != "") SqlConnect.connect.WriteRegKey("Login", "SQLPass", Passsql); if (Database != "") SqlConnect.connect.WriteRegKey("Login", "Database1", Database);
        }
    }
}
