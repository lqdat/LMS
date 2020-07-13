using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace LB
{
    class Conect
    {
          

        //tao ket noi
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=thuvien;Integrated Security=True");
        //tao ham lay du lieu
        public DataTable getdata(String cmd)
        {
           try
            {
                con.Open();
                SqlCommand cmds = new SqlCommand(cmd, con);
                SqlDataAdapter da = new SqlDataAdapter(cmds);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                return dt;
                
            }
            catch (Exception)
            {
                return null;
            }

        }
        public Boolean excute (String cmd)
        {
            try
            {
                con.Open();
                SqlCommand cmds = new SqlCommand(cmd, con);
                cmds.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
        public Boolean checkdata (String cmd)
        {
            try
            {
                con.Open();
                SqlCommand cmds = new SqlCommand(cmd, con);
                SqlDataAdapter da = new SqlDataAdapter(cmds);
                con.Close();
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public SqlDataReader all (String cmd)
        {
            try
            {
                con.Open();
                SqlCommand cmds = new SqlCommand(cmd, con);
                cmds.ExecuteNonQuery();
                SqlDataReader dr = cmds.ExecuteReader();
                return dr;
                


            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
