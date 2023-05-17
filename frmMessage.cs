using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyChatGPT
{
    public partial class frmMessage : Form
    {
        static string strConn = ConfigurationManager.ConnectionStrings["myConn"].ConnectionString;
        SqlConnection sqlConn = new SqlConnection(strConn);
        string id;
        public frmMessage(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlComm = new SqlCommand("sp_deleteEntry", sqlConn) ;
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.Parameters.AddWithValue("@id",id);
                sqlConn.Open();
                sqlComm.ExecuteNonQuery();
            }
            catch (Exception)
            {

                Form error = new frmError("Delete Error!!!");
                error.ShowDialog();
            }
            finally { sqlConn.Close();
                Application.Restart();
            }
        }
    }
}
