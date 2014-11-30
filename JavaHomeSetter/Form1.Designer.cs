namespace JavaHomeSetter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSave = new System.Windows.Forms.Button();
            this.lblJavaHome = new System.Windows.Forms.Label();
            this.txtJavaHome = new System.Windows.Forms.TextBox();
            this.btnFindPath = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lblAbout = new System.Windows.Forms.Label();
            this.lblExample = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(15, 68);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(372, 47);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save Java Home Path";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblJavaHome
            // 
            this.lblJavaHome.AutoSize = true;
            this.lblJavaHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJavaHome.Location = new System.Drawing.Point(12, 9);
            this.lblJavaHome.Name = "lblJavaHome";
            this.lblJavaHome.Size = new System.Drawing.Size(104, 13);
            this.lblJavaHome.TabIndex = 1;
            this.lblJavaHome.Text = "Java Home Path:";
            // 
            // txtJavaHome
            // 
            this.txtJavaHome.Location = new System.Drawing.Point(15, 25);
            this.txtJavaHome.Name = "txtJavaHome";
            this.txtJavaHome.Size = new System.Drawing.Size(338, 20);
            this.txtJavaHome.TabIndex = 2;
            // 
            // btnFindPath
            // 
            this.btnFindPath.Location = new System.Drawing.Point(359, 23);
            this.btnFindPath.Name = "btnFindPath";
            this.btnFindPath.Size = new System.Drawing.Size(25, 23);
            this.btnFindPath.TabIndex = 3;
            this.btnFindPath.Text = "...";
            this.btnFindPath.UseVisualStyleBackColor = true;
            this.btnFindPath.Click += new System.EventHandler(this.btnFindPath_Click);
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Location = new System.Drawing.Point(12, 122);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(61, 13);
            this.lblAbout.TabIndex = 4;
            this.lblAbout.Text = "by cindy_k ";
            // 
            // lblExample
            // 
            this.lblExample.AutoSize = true;
            this.lblExample.Location = new System.Drawing.Point(16, 48);
            this.lblExample.Name = "lblExample";
            this.lblExample.Size = new System.Drawing.Size(35, 13);
            this.lblExample.TabIndex = 5;
            this.lblExample.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(396, 172);
            this.Controls.Add(this.lblExample);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.btnFindPath);
            this.Controls.Add(this.txtJavaHome);
            this.Controls.Add(this.lblJavaHome);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "JAVA_HOME setter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblJavaHome;
        private System.Windows.Forms.TextBox txtJavaHome;
        private System.Windows.Forms.Button btnFindPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.Label lblExample;
    }
}

