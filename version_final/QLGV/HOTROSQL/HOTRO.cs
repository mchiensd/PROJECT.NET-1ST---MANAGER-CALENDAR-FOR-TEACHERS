using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.HOTROSQL
{
    public class HOTRO
    {
        private string CHUOIKETNOI = @"Data Source=PHUNG-THANH;Initial Catalog=QuanLyMoiGiang;Integrated Security=True";

        private static HOTRO sQL;

        public static HOTRO SQL
        {
            get
            {
                if (sQL == null)
                {
                    sQL = new HOTRO();
                }
                return HOTRO.sQL;

            }
            private set { HOTRO.sQL = value; }
        }

        private HOTRO() { }

        public DataTable TAIBANGDULIEU(string LENH)
        {
            DataTable BANG = new DataTable();
            using (SqlConnection KETNOI = new SqlConnection(CHUOIKETNOI))
            {
                KETNOI.Open();

                SqlCommand THUCTHILENH = new SqlCommand(LENH, KETNOI);
                SqlDataAdapter TRUYENDL = new SqlDataAdapter(THUCTHILENH);
                TRUYENDL.Fill(BANG);

                KETNOI.Close();
            }
            return BANG;
        }

        public int THEM_XOA_SUA_DULIEU(string LENH)
        {
            int dong = 0;
            using (SqlConnection KETNOI = new SqlConnection(CHUOIKETNOI))
            {
                KETNOI.Open();

                SqlCommand THUCTHILENH = new SqlCommand(LENH, KETNOI);
                dong = THUCTHILENH.ExecuteNonQuery();

                KETNOI.Close();
            }
            return dong;
        }
    }
}
