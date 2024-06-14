namespace pregl
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_f = new System.Windows.Forms.Button();
            this.btn_idi = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1355, 534);
            this.webBrowser1.TabIndex = 0;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(76, 43);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "nazad";
            this.btn_back.UseVisualStyleBackColor = true;
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(227, 43);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(75, 23);
            this.btn_home.TabIndex = 2;
            this.btn_home.Text = "kuća";
            this.btn_home.UseVisualStyleBackColor = true;
            // 
            // btn_f
            // 
            this.btn_f.Location = new System.Drawing.Point(404, 43);
            this.btn_f.Name = "btn_f";
            this.btn_f.Size = new System.Drawing.Size(75, 23);
            this.btn_f.TabIndex = 3;
            this.btn_f.Text = "naprijed";
            this.btn_f.UseVisualStyleBackColor = true;
            // 
            // btn_idi
            // 
            this.btn_idi.Location = new System.Drawing.Point(570, 43);
            this.btn_idi.Name = "btn_idi";
            this.btn_idi.Size = new System.Drawing.Size(75, 23);
            this.btn_idi.TabIndex = 4;
            this.btn_idi.Text = "idi";
            this.btn_idi.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 173);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(569, 22);
            this.textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 534);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_idi);
            this.Controls.Add(this.btn_f);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_f;
        private System.Windows.Forms.Button btn_idi;
        private System.Windows.Forms.TextBox textBox1;
    }
}

