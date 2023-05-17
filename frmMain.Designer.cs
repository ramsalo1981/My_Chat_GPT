namespace MyChatGPT
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTop = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlMedel = new System.Windows.Forms.Panel();
            this.btnFotoUpload = new System.Windows.Forms.Button();
            this.lblCodeId = new System.Windows.Forms.Label();
            this.txtCodeId = new System.Windows.Forms.TextBox();
            this.lblNameError = new System.Windows.Forms.Label();
            this.lblProLanguge = new System.Windows.Forms.Label();
            this.txtNameError = new System.Windows.Forms.TextBox();
            this.cmbLanguge = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtProcess = new System.Windows.Forms.TextBox();
            this.lblSolving = new System.Windows.Forms.Label();
            this.picCode = new System.Windows.Forms.PictureBox();
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlMedel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCode)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblTop);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(493, 47);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTop.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTop.Location = new System.Drawing.Point(80, 11);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(333, 24);
            this.lblTop.TabIndex = 0;
            this.lblTop.Text = "Welcome to my ChatGPT program";
            this.lblTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnCancel);
            this.pnlBottom.Controls.Add(this.btnSave);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 577);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(493, 64);
            this.pnlBottom.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(183)))), ((int)(((byte)(19)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Arial", 10F);
            this.btnSave.Location = new System.Drawing.Point(12, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 42);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(183)))), ((int)(((byte)(19)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 10F);
            this.btnCancel.Location = new System.Drawing.Point(364, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 42);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlMedel
            // 
            this.pnlMedel.Controls.Add(this.txtProcess);
            this.pnlMedel.Controls.Add(this.lblSolving);
            this.pnlMedel.Controls.Add(this.txtDescription);
            this.pnlMedel.Controls.Add(this.lblDescription);
            this.pnlMedel.Controls.Add(this.cmbLanguge);
            this.pnlMedel.Controls.Add(this.lblProLanguge);
            this.pnlMedel.Controls.Add(this.txtNameError);
            this.pnlMedel.Controls.Add(this.lblNameError);
            this.pnlMedel.Controls.Add(this.txtCodeId);
            this.pnlMedel.Controls.Add(this.lblCodeId);
            this.pnlMedel.Controls.Add(this.btnFotoUpload);
            this.pnlMedel.Controls.Add(this.picCode);
            this.pnlMedel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMedel.Location = new System.Drawing.Point(0, 47);
            this.pnlMedel.Name = "pnlMedel";
            this.pnlMedel.Size = new System.Drawing.Size(493, 530);
            this.pnlMedel.TabIndex = 2;
            // 
            // btnFotoUpload
            // 
            this.btnFotoUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(183)))), ((int)(((byte)(19)))));
            this.btnFotoUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFotoUpload.Font = new System.Drawing.Font("Arial", 10F);
            this.btnFotoUpload.Location = new System.Drawing.Point(281, 220);
            this.btnFotoUpload.Name = "btnFotoUpload";
            this.btnFotoUpload.Size = new System.Drawing.Size(200, 42);
            this.btnFotoUpload.TabIndex = 3;
            this.btnFotoUpload.Text = "Foto Upload";
            this.btnFotoUpload.UseVisualStyleBackColor = false;
            this.btnFotoUpload.Click += new System.EventHandler(this.btnFotoUpload_Click);
            // 
            // lblCodeId
            // 
            this.lblCodeId.AutoSize = true;
            this.lblCodeId.Font = new System.Drawing.Font("Arial", 10F);
            this.lblCodeId.ForeColor = System.Drawing.Color.Yellow;
            this.lblCodeId.Location = new System.Drawing.Point(14, 21);
            this.lblCodeId.Name = "lblCodeId";
            this.lblCodeId.Size = new System.Drawing.Size(94, 23);
            this.lblCodeId.TabIndex = 4;
            this.lblCodeId.Text = "Code_ID:";
            // 
            // txtCodeId
            // 
            this.txtCodeId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.txtCodeId.Enabled = false;
            this.txtCodeId.Font = new System.Drawing.Font("Arial", 10F);
            this.txtCodeId.ForeColor = System.Drawing.Color.White;
            this.txtCodeId.Location = new System.Drawing.Point(19, 47);
            this.txtCodeId.Name = "txtCodeId";
            this.txtCodeId.ReadOnly = true;
            this.txtCodeId.Size = new System.Drawing.Size(245, 30);
            this.txtCodeId.TabIndex = 5;
            this.txtCodeId.Text = "Code ID";
            // 
            // lblNameError
            // 
            this.lblNameError.AutoSize = true;
            this.lblNameError.Font = new System.Drawing.Font("Arial", 10F);
            this.lblNameError.ForeColor = System.Drawing.Color.Yellow;
            this.lblNameError.Location = new System.Drawing.Point(14, 89);
            this.lblNameError.Name = "lblNameError";
            this.lblNameError.Size = new System.Drawing.Size(172, 23);
            this.lblNameError.TabIndex = 6;
            this.lblNameError.Text = "Name of the error:";
            // 
            // lblProLanguge
            // 
            this.lblProLanguge.AutoSize = true;
            this.lblProLanguge.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProLanguge.ForeColor = System.Drawing.Color.Yellow;
            this.lblProLanguge.Location = new System.Drawing.Point(14, 157);
            this.lblProLanguge.Name = "lblProLanguge";
            this.lblProLanguge.Size = new System.Drawing.Size(218, 23);
            this.lblProLanguge.TabIndex = 8;
            this.lblProLanguge.Text = "Programming language:";
            // 
            // txtNameError
            // 
            this.txtNameError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.txtNameError.Font = new System.Drawing.Font("Arial", 10F);
            this.txtNameError.ForeColor = System.Drawing.Color.White;
            this.txtNameError.Location = new System.Drawing.Point(18, 115);
            this.txtNameError.Name = "txtNameError";
            this.txtNameError.Size = new System.Drawing.Size(240, 30);
            this.txtNameError.TabIndex = 7;
            this.txtNameError.Text = "The name of the problem";
            // 
            // cmbLanguge
            // 
            this.cmbLanguge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.cmbLanguge.Font = new System.Drawing.Font("Arial", 10F);
            this.cmbLanguge.ForeColor = System.Drawing.Color.White;
            this.cmbLanguge.FormattingEnabled = true;
            this.cmbLanguge.Location = new System.Drawing.Point(19, 183);
            this.cmbLanguge.Name = "cmbLanguge";
            this.cmbLanguge.Size = new System.Drawing.Size(239, 31);
            this.cmbLanguge.TabIndex = 9;
            this.cmbLanguge.Text = "Select Language";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.txtDescription.Font = new System.Drawing.Font("Arial", 10F);
            this.txtDescription.ForeColor = System.Drawing.Color.White;
            this.txtDescription.Location = new System.Drawing.Point(12, 301);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(468, 30);
            this.txtDescription.TabIndex = 11;
            this.txtDescription.Text = "Type the description of the problem";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Arial", 10F);
            this.lblDescription.ForeColor = System.Drawing.Color.Yellow;
            this.lblDescription.Location = new System.Drawing.Point(9, 275);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(114, 23);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "Description:";
            // 
            // txtProcess
            // 
            this.txtProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.txtProcess.Font = new System.Drawing.Font("Arial", 10F);
            this.txtProcess.ForeColor = System.Drawing.Color.White;
            this.txtProcess.Location = new System.Drawing.Point(14, 376);
            this.txtProcess.Multiline = true;
            this.txtProcess.Name = "txtProcess";
            this.txtProcess.Size = new System.Drawing.Size(466, 144);
            this.txtProcess.TabIndex = 13;
            this.txtProcess.Text = "Write down the steps to solve the problem";
            // 
            // lblSolving
            // 
            this.lblSolving.AutoSize = true;
            this.lblSolving.Font = new System.Drawing.Font("Arial", 10F);
            this.lblSolving.ForeColor = System.Drawing.Color.Yellow;
            this.lblSolving.Location = new System.Drawing.Point(9, 343);
            this.lblSolving.Name = "lblSolving";
            this.lblSolving.Size = new System.Drawing.Size(237, 23);
            this.lblSolving.TabIndex = 12;
            this.lblSolving.Text = "Problem_solving Process:";
            // 
            // picCode
            // 
            this.picCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.picCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCode.Image = global::MyChatGPT.Properties.Resources.questionmark;
            this.picCode.Location = new System.Drawing.Point(281, 21);
            this.picCode.Name = "picCode";
            this.picCode.Size = new System.Drawing.Size(200, 193);
            this.picCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCode.TabIndex = 0;
            this.picCode.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(493, 641);
            this.Controls.Add(this.pnlMedel);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlMedel.ResumeLayout(false);
            this.pnlMedel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlMedel;
        private System.Windows.Forms.PictureBox picCode;
        private System.Windows.Forms.TextBox txtProcess;
        private System.Windows.Forms.Label lblSolving;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ComboBox cmbLanguge;
        private System.Windows.Forms.Label lblProLanguge;
        private System.Windows.Forms.TextBox txtNameError;
        private System.Windows.Forms.Label lblNameError;
        private System.Windows.Forms.TextBox txtCodeId;
        private System.Windows.Forms.Label lblCodeId;
        private System.Windows.Forms.Button btnFotoUpload;
    }
}