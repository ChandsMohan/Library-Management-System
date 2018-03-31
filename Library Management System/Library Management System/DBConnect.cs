using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Library_Management_System
{
    class DBConnect
    {
        public static SqlConnection Connection;

        public bool OpenConnection()
        {
            string StrCn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            encrypter encr = new encrypter();
            string str_cn_new = StrCn;
            int userid_ind = str_cn_new.LastIndexOf(";User ID") + 9;
            int password_ind = str_cn_new.LastIndexOf(";Password") + 10;
            int unocode_index = str_cn_new.LastIndexOf(";Persist Security Info") + 9;
            string userid = str_cn_new.Substring(userid_ind, (password_ind - userid_ind - 10));
            string passowrd = str_cn_new.Substring(password_ind, unocode_index - password_ind - 9);
            string decr_username = encr.DecryptString(userid);
            string decr_password = encr.DecryptString(passowrd);
            str_cn_new = str_cn_new.Replace(userid, decr_username);
            str_cn_new = str_cn_new.Replace(passowrd, decr_password);
            Connection = new SqlConnection(str_cn_new);
            try
            {
                if (Connection.State == ConnectionState.Closed)
                {
                    Connection.Open();
                    return true;
                }
                return false;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                Connection.Close();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static SqlConnection DBConnection;

        public bool DBOpenConnection()
        {
            string StrCnn = ConfigurationManager.ConnectionStrings["MyCon"].ConnectionString;
            encrypter encrpt = new encrypter();
            string str_cnn_new = StrCnn;
            int userid_ind1 = str_cnn_new.LastIndexOf(";User ID") + 9;
            int password_ind1 = str_cnn_new.LastIndexOf(";Password") + 10;
            int unocode_index1 = str_cnn_new.LastIndexOf(";Persist Security Info") + 9;
            string userid1 = str_cnn_new.Substring(userid_ind1, (password_ind1 - userid_ind1 - 10));
            string passowrd1 = str_cnn_new.Substring(password_ind1, unocode_index1 - password_ind1 - 9);
            string decr_username1 = encrpt.DecryptString(userid1);
            string decr_password = encrpt.DecryptString(passowrd1);
            str_cnn_new = str_cnn_new.Replace(userid1, decr_username1);
            str_cnn_new = str_cnn_new.Replace(passowrd1, decr_password);
            DBConnection = new SqlConnection(str_cnn_new);
            try
            {
                if (DBConnection.State== ConnectionState.Closed)
                {
                    DBConnection.Open();
                    return true;
                }
                return false;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool DBCloseConnection()
        {
            try
            {
                DBConnection.Close();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        
    }


}
