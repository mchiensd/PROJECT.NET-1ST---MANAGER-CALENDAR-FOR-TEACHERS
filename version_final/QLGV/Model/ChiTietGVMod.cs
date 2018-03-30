using QLGV.Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Model
{
    public class ChiTietGVMod
    {
        ConnecttoSQL Con = new ConnecttoSQL();
        SqlCommand cmd = new SqlCommand();
        public DataTable Getdata()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from ChiTietMoiGiang";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Con.Connection;
            try
            {
                Con.OpenCon();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                string tex = ex.Message;
                cmd.Dispose();
                Con.CloseCon();
            }
            return dt;
        }
        public DataTable Timdata(string tim)
        {


            DataTable dt = new DataTable();
            cmd.CommandText = "Select * from ChiTietMoiGiang where MaMoiGiang like N'%" + tim + "%' or MaGiaoVien like N'%" + tim + "%'or MaLop like N'%" + tim + "%'or MaMon like N'%" + tim + "%'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Con.Connection;
            try
            {
                Con.OpenCon();
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                ad.Fill(dt);

            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                Con.CloseCon();
            }
            return dt;
        }
        public bool Addata(ChiTietMG lh)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "insert into ChiTietMoiGiang values('" + lh.MaMoiGiang1 + "','" + lh.MaGiaoVien1 + "','" + lh.MaLop1 + "','" + lh.MaMon1 + "',CONVERT(date,'" + lh.NgayBatDau1 + "',103),CONVERT(date,'" + lh.NgayKetThuc1 + "',103))";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Con.Connection;

            try
            {
                Con.OpenCon();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                Con.CloseCon();
            }
            return false;
        }
        public bool Update(ChiTietMG lh)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "update ChiTietMoiGiang set MaGiaoVien='" + lh.MaGiaoVien1 + "',MaLop='" + lh.MaLop1 + "',MaMon='"+lh.MaMon1+ "',NgayBatDau=CONVERT(date,'"+lh.NgayBatDau1+ "',103),NgayKetThuc=CONVERT(date,'" + lh.NgayKetThuc1 + "',103) where MaMoiGiang='" + lh.MaMoiGiang1 + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Con.Connection;

            try
            {
                Con.OpenCon();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                Con.CloseCon();
            }
            return false;
        }
        public bool Deldata(string mamg)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "delete ChiTietMoiGiang where MaMoiGiang='" + mamg + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Con.Connection;

            try
            {
                Con.OpenCon();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                Con.CloseCon();
            }
            return false;
        }
        public string Tudongtangma()
        {
            cmd.CommandText = "select MaMoiGiang from ChiTietMoiGiang";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Con.Connection;
            DataTable dt = new DataTable();
            try
            {
                Con.OpenCon();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);


            }
            catch (Exception ex)
            {
                string test = ex.Message;
                cmd.Dispose();
                Con.CloseCon();
            }
            string g = "";
            if (dt.Rows.Count <= 0)
            {
                g = "MG001";

            }
            else
            {
                int k;
                g = "MG";
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2));
                k = k + 1;
                if (k < 10)
                {
                    g = g + "00";
                }
                else
                {
                    g = g + "0";
                }
                g = g + k.ToString();
            }
            return g;
        }
    }
}
