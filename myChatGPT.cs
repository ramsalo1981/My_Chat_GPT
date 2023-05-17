using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyChatGPT
{
    public partial class myChatGPT : Form
    {
        static string strConn = ConfigurationManager.ConnectionStrings["myConn"].ConnectionString;
        SqlConnection sqlConn = new SqlConnection(strConn);
        public myChatGPT()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Form add = new frmMain();
            add.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string id = dgvChatGPT.CurrentRow.Cells[0].Value.ToString();
            Form edit = new frmMain(id);
            edit.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = dgvChatGPT.CurrentRow.Cells[0].Value.ToString();
            Form del = new frmMessage(id);
            del.ShowDialog();
        }

        private void myChatGPT_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("sp_selectall", sqlConn);
                da.Fill(dt);
                dgvChatGPT.DataSource = dt;
                dgvChatGPT.Columns[0].Width = (5 * dgvChatGPT.Width) / 100;
                dgvChatGPT.Columns[1].Width = (10 * dgvChatGPT.Width) / 100;
                dgvChatGPT.Columns[2].Width = (20 * dgvChatGPT.Width) / 100;
                dgvChatGPT.Columns[3].Width = (25 * dgvChatGPT.Width) / 100;
                dgvChatGPT.Columns[4].Width = (40 * dgvChatGPT.Width) / 100;
                dgvChatGPT.Columns[5].Visible = false;
            }
            catch (Exception)
            {

                Form error = new frmError($"Data loading Error");
                error.ShowDialog();
            }


        }

        private void dgvChatGPT_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //tacke value of image by byte from database
            byte[] pic = (byte[])dgvChatGPT.CurrentRow.Cells[5].Value;
            //save it in memeory
            MemoryStream mem = new MemoryStream(pic);
            Image image = Image.FromStream(mem);

            //Show image in frmimage
            Form frmPic = new frmImage(image);
            frmPic.ShowDialog();
        }

        private void txtSearch_MouseDown(object sender, MouseEventArgs e)
        {
            txtSearch.SelectAll();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("sp_search", sqlConn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@param", "%" + txtSearch.Text + "%");
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvChatGPT.DataSource = dt;
                    dgvChatGPT.Columns[0].Width = (5 * dgvChatGPT.Width) / 100;
                    dgvChatGPT.Columns[1].Width = (10 * dgvChatGPT.Width) / 100;
                    dgvChatGPT.Columns[2].Width = (20 * dgvChatGPT.Width) / 100;
                    dgvChatGPT.Columns[3].Width = (25 * dgvChatGPT.Width) / 100;
                    dgvChatGPT.Columns[4].Width = (40 * dgvChatGPT.Width) / 100;
                    dgvChatGPT.Columns[5].Visible = false;
                }
                catch (Exception)
                {

                    Form error = new frmError("Search error!!!");
                    error.ShowDialog();
                }
                finally { sqlConn.Close(); }
            }
            else
            {
                Application.Restart();
            }
            
        }
    }
}
