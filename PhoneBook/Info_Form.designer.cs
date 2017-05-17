namespace PhoneBook
{
    partial class Info_Form
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
            this.adress_line = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            this.change_btn = new System.Windows.Forms.Button();
            this.Developers = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adress_line
            // 
            this.adress_line.Enabled = false;
            this.adress_line.Location = new System.Drawing.Point(16, 56);
            this.adress_line.Name = "adress_line";
            this.adress_line.Size = new System.Drawing.Size(254, 20);
            this.adress_line.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "Путь на сервер";
            // 
            // save_btn
            // 
            this.save_btn.Enabled = false;
            this.save_btn.Location = new System.Drawing.Point(292, 56);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 20);
            this.save_btn.TabIndex = 19;
            this.save_btn.Text = "Сохранить";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // change_btn
            // 
            this.change_btn.Location = new System.Drawing.Point(373, 56);
            this.change_btn.Name = "change_btn";
            this.change_btn.Size = new System.Drawing.Size(75, 20);
            this.change_btn.TabIndex = 22;
            this.change_btn.Text = "Изменить";
            this.change_btn.UseVisualStyleBackColor = true;
            this.change_btn.Click += new System.EventHandler(this.change_btn_Click);
            // 
            // Developers
            // 
            this.Developers.AutoSize = true;
            this.Developers.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Developers.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Developers.Location = new System.Drawing.Point(12, 275);
            this.Developers.Name = "Developers";
            this.Developers.Size = new System.Drawing.Size(143, 40);
            this.Developers.TabIndex = 23;
            this.Developers.Text = "Ушкевич Дмитрий  \r\nГерасютин Фома\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Программу разработали:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(454, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 20);
            this.button1.TabIndex = 27;
            this.button1.Text = "По умолчанию";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.default_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(497, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 60);
            this.button2.TabIndex = 28;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Info_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Developers);
            this.Controls.Add(this.change_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adress_line);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Info_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Info";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Info_Form_FormClosed);
            this.Load += new System.EventHandler(this.Info_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adress_line;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button change_btn;
        private System.Windows.Forms.Label Developers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;



    }
}