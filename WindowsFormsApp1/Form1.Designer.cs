namespace WindowsFormsApp1
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
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_fileDialog = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_create_folders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(342, 328);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(172, 43);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Text = "ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            // 
            // btn_fileDialog
            // 
            this.btn_fileDialog.Location = new System.Drawing.Point(571, 88);
            this.btn_fileDialog.Name = "btn_fileDialog";
            this.btn_fileDialog.Size = new System.Drawing.Size(62, 62);
            this.btn_fileDialog.TabIndex = 1;
            this.btn_fileDialog.Text = "...";
            this.btn_fileDialog.UseVisualStyleBackColor = true;
            this.btn_fileDialog.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(497, 26);
            this.textBox1.TabIndex = 3;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(135, 328);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(159, 42);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(68, 124);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(497, 26);
            this.textBox2.TabIndex = 5;
            // 
            // btn_create_folders
            // 
            this.btn_create_folders.Location = new System.Drawing.Point(518, 172);
            this.btn_create_folders.Name = "btn_create_folders";
            this.btn_create_folders.Size = new System.Drawing.Size(114, 59);
            this.btn_create_folders.TabIndex = 6;
            this.btn_create_folders.Text = "button1";
            this.btn_create_folders.UseVisualStyleBackColor = true;
            this.btn_create_folders.Click += new System.EventHandler(this.btn_create_folders_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_create_folders);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_fileDialog);
            this.Controls.Add(this.btn_ok);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_fileDialog;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_create_folders;
    }
}

