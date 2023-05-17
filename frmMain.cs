using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyChatGPT
{
    public partial class frmMain : Form
    {
        static string strConn = ConfigurationManager.ConnectionStrings["myConn"].ConnectionString;
        SqlConnection sqlConn = new SqlConnection(strConn);

        string id;
        string cmbtxt;
        public frmMain()
        {
            InitializeComponent();
        }
        public frmMain(string id)
        {
            InitializeComponent();
            this.id = id;

            try
            {
                SqlCommand sqlComm = new SqlCommand("sp_selectId", sqlConn);
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.Parameters.AddWithValue("@id", id);
                sqlConn.Open();
                SqlDataReader dr = sqlComm.ExecuteReader();
                while (dr.Read())
                {
                    txtCodeId.Text = dr[0].ToString();
                    txtNameError.Text = dr[1].ToString();
                    cmbtxt = dr[2].ToString();
                    
                    txtDescription.Text = dr[3].ToString();
                    txtProcess.Text = dr[4].ToString();
                    byte[] pic = (byte[])dr[5];
                    MemoryStream mem = new MemoryStream(pic);
                    picCode.Image = Image.FromStream(mem);
                }
            }
            catch (Exception)
            {

                Form error = new frmError("Error frmMain id");
                error.ShowDialog();
            }
            finally { sqlConn.Close();}
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("sp_selectProgrammingLanguage", sqlConn);
                da.Fill(dt);
                cmbLanguge.DataSource = dt;
                cmbLanguge.DisplayMember = "ProgrammingLanguage";
            }
            catch (Exception)
            {

                Form error = new frmError("frmMain_Load error");
                error.ShowDialog();
            }
            if (!string.IsNullOrEmpty(cmbtxt))
            {
                cmbLanguge.Text = cmbtxt;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id))
            {
                //new

                try
                {
                    // Change image to array byte and save in database
                    MemoryStream mem = new MemoryStream();
                    picCode.Image.Save(mem, ImageFormat.Png);
                    var pic = mem.ToArray();

                    //save all data in database
                    SqlCommand sqlComm = new SqlCommand("sp_addEntry", sqlConn);
                    sqlComm.CommandType = CommandType.StoredProcedure;

                    sqlComm.Parameters.AddWithValue("@name", txtNameError.Text);
                    sqlComm.Parameters.AddWithValue("@programmingLanguage", cmbLanguge.Text);
                    sqlComm.Parameters.AddWithValue("@description", txtDescription.Text);
                    sqlComm.Parameters.AddWithValue("@process", txtProcess.Text);
                    sqlComm.Parameters.AddWithValue("@image", pic);

                    sqlConn.Open();
                    sqlComm.ExecuteNonQuery();
                }
                catch (Exception)
                {

                    Form error = new frmError("Add New Entry Error!!");
                    error.ShowDialog();
                    //MessageBox.Show($"Error\n {ex}");
                }
                finally
                {
                    sqlConn.Close();
                    Application.Restart();
                }

            }
            else
            {
                //Edit
                try
                {
                    MemoryStream mem = new MemoryStream();
                    picCode.Image.Save(mem, ImageFormat.Png);
                    var pic = mem.ToArray();
                    SqlCommand sqlComm = new SqlCommand("sp_editEntry", sqlConn);
                    sqlComm.CommandType = CommandType.StoredProcedure;

                    sqlComm.Parameters.AddWithValue("@id", id);
                    sqlComm.Parameters.AddWithValue("@name", txtNameError.Text);
                    sqlComm.Parameters.AddWithValue("@programmingLanguage", cmbLanguge.Text);
                    sqlComm.Parameters.AddWithValue("@description", txtDescription.Text);
                    sqlComm.Parameters.AddWithValue("@process", txtProcess.Text);
                    sqlComm.Parameters.AddWithValue("@image", pic);

                    sqlConn.Open();
                    sqlComm.ExecuteNonQuery();
                }
                catch (Exception)
                {

                    Form error = new frmError("Edit id error");
                    error.ShowDialog();
                }
                finally 
                { 
                    sqlConn.Close();
                    Application.Restart();
                }

            }
        }
        private void btnFotoUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectPic = new OpenFileDialog();
            selectPic.Filter = "Image | *.JPG; *.PNG";
            if (selectPic.ShowDialog() == DialogResult.OK)
            {
                picCode.Image = Image.FromFile(selectPic.FileName);
            }
        }

        
    }
}
