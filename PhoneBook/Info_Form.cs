using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace PhoneBook
{
    public partial class Info_Form : Form
    {
        
        public Info_Form()
        {
            InitializeComponent();
        }

        #region Кнопки Сохранить/Изменить
        private void save_btn_Click(object sender, EventArgs e)
        {
            adress_line.Enabled = false;
            save_btn.Enabled = false;
            LoadSet();      
        }

        private void change_btn_Click(object sender, EventArgs e)
        {
            save_btn.Enabled = true;
            adress_line.Enabled = true;
        }
        #endregion

        #region Адресная строка
        private void LoadSettings()
        {
            this.adress_line.Text = Properties.Settings.Default.New;
               this.Text = adress_line.Text;
               
        }

      
        private void Info_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadSet();
        }

        private void Info_Form_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }
        #endregion

        private void default_Click(object sender, EventArgs e)
        {
          
            adress_line.Text = "\\" + "\\" + "server-pu/Telephone";
        }

        private void LoadSet()
        {
            Properties.Settings.Default.New = adress_line.Text;
            Properties.Settings.Default.Save();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

       

    }
}
