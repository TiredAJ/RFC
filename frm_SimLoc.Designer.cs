namespace RCF
{
    partial class frm_SimLoc
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
            this.btn_FindFile = new System.Windows.Forms.Button();
            this.btn_Default = new System.Windows.Forms.Button();
            this.btn_Skip = new System.Windows.Forms.Button();
            this.btn_Proceed = new System.Windows.Forms.Button();
            this.txt_FileLoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ofd_FindFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btn_FindFile
            // 
            this.btn_FindFile.Location = new System.Drawing.Point(12, 65);
            this.btn_FindFile.Name = "btn_FindFile";
            this.btn_FindFile.Size = new System.Drawing.Size(94, 29);
            this.btn_FindFile.TabIndex = 0;
            this.btn_FindFile.Text = "Find File";
            this.btn_FindFile.UseVisualStyleBackColor = true;
            this.btn_FindFile.Click += new System.EventHandler(this.btn_FindFile_Click);
            // 
            // btn_Default
            // 
            this.btn_Default.Location = new System.Drawing.Point(112, 65);
            this.btn_Default.Name = "btn_Default";
            this.btn_Default.Size = new System.Drawing.Size(94, 29);
            this.btn_Default.TabIndex = 1;
            this.btn_Default.Text = "Default";
            this.btn_Default.UseVisualStyleBackColor = true;
            this.btn_Default.Click += new System.EventHandler(this.btn_Default_Click);
            // 
            // btn_Skip
            // 
            this.btn_Skip.Location = new System.Drawing.Point(12, 100);
            this.btn_Skip.Name = "btn_Skip";
            this.btn_Skip.Size = new System.Drawing.Size(194, 29);
            this.btn_Skip.TabIndex = 2;
            this.btn_Skip.Text = "I already have it open";
            this.btn_Skip.UseVisualStyleBackColor = true;
            this.btn_Skip.Click += new System.EventHandler(this.btn_Skip_Click);
            // 
            // btn_Proceed
            // 
            this.btn_Proceed.Enabled = false;
            this.btn_Proceed.Location = new System.Drawing.Point(422, 65);
            this.btn_Proceed.Name = "btn_Proceed";
            this.btn_Proceed.Size = new System.Drawing.Size(94, 29);
            this.btn_Proceed.TabIndex = 3;
            this.btn_Proceed.Text = "Proceed";
            this.btn_Proceed.UseVisualStyleBackColor = true;
            this.btn_Proceed.Click += new System.EventHandler(this.btn_Proceed_Click);
            // 
            // txt_FileLoc
            // 
            this.txt_FileLoc.Location = new System.Drawing.Point(12, 32);
            this.txt_FileLoc.Name = "txt_FileLoc";
            this.txt_FileLoc.Size = new System.Drawing.Size(504, 27);
            this.txt_FileLoc.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "File Location";
            // 
            // frm_SimLoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 146);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_FileLoc);
            this.Controls.Add(this.btn_Proceed);
            this.Controls.Add(this.btn_Skip);
            this.Controls.Add(this.btn_Default);
            this.Controls.Add(this.btn_FindFile);
            this.Name = "frm_SimLoc";
            this.Text = "SimLoc";
            this.Load += new System.EventHandler(this.frm_SimLoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_FindFile;
        private Button btn_Default;
        private Button btn_Skip;
        private Button btn_Proceed;
        private TextBox txt_FileLoc;
        private Label label1;
        private OpenFileDialog ofd_FindFile;
    }
}