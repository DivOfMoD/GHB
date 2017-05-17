using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Reflection;
using PhoneBook.Properties;
using Microsoft.Win32;

namespace PhoneBook
{
    public partial class Main_Form : Form
    {
        
        
        public Main_Form()
        {
            InitializeComponent();
                      
        }
      
        Rectangle screenSize = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
             
        DataSet da = new DataSet();
        OleDbDataAdapter adapter = new OleDbDataAdapter();
   
        #region Excel
        private static string Excel_Load() 
        {

            string path = Properties.Settings.Default.New;

            path = Path.Combine(path, "TelePhoneBook.xlsx");
            string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + @"; Extended Properties=""Excel 12.0 Macro;HDR=Yes;ImportMixedTypes=Text;TypeGuessRowsIMEX=1;TypeGuessRows=0""";
            return ConnectionString;

        }
        #endregion 

        #region Вид таблицы(обычный/полноэкранный) с фильтрами
        private void DataView(int size,DataSet da,string filtre ="", params double []a)//Таблица с фильтром
        {
            dataGridView1.DataSource = da.Tables[0];


            DataTableCollection tables = da.Tables;
            DataView view1 = new DataView(tables[0]);
          
            view1.RowFilter = filtre;
          
            dataGridView1.DataSource = view1;
            dataGridView1.Font = new Font("Calibri", size);
            
            dataGridView1.Columns[0].Width = (int)a[0];
            dataGridView1.Columns[1].Width = (int)a[1];
            dataGridView1.Columns[2].Width = (int)a[2];
            dataGridView1.Columns[3].Width = (int)a[3];
            dataGridView1.Columns[4].Width = (int)a[4];
            dataGridView1.Columns[5].Width = (int)a[5];
            dataGridView1.Columns[6].Width = (int)a[6];
            dataGridView1.Dock = DockStyle.Fill;
        }
         
        private void View(double x, string s)
        {
            if (this.WindowState == FormWindowState.Maximized)
                DataView(14, da, s, x * 0.075, x * 0.213, x * 0.058, x * 0.075, x * 0.139, x * 0.22, x * 0.22);
            else
                DataView(12, da, s, 70, 200, 55, 70, 130, 205, 205);

        }
        #endregion

        #region База данных
        private void DateBase() //База данных
        {
            OleDbConnection conn = new OleDbConnection(Excel_Load());
            
            string Strcmd = "select * from [List$A1:G350]";
            OleDbCommand cmd = new OleDbCommand(Strcmd, conn);

            try
            {
                conn.Open();
                da.Clear();
                adapter.SelectCommand = cmd;
                adapter.Fill(da);

                DataView(12,da,"", 70, 200, 55, 70, 130, 205, 205);

            }
            catch (Exception)
            {
                MessageBox.Show("Неверный адрес. Обратитесь к системному администратору");
            }
            finally
            {
                conn.Close();
            }

        }
        #endregion

        #region Запуск формы
        private void Form1_Load(object sender, EventArgs e) // Запуск формы
        {
          
          
          try
            {
                DateBase();
                DataView(12, da, "", 70, 200, 55, 70, 130, 205, 205);
                dataGridView1.Focus();
           }
           catch (Exception)
           {
               
               info_Click(new object { }, new EventArgs { });
               Application.Exit();
              
           }
          
           

        }
        #endregion

        #region Refresh Button
        private void pictureBox2_MouseClick(object sender, EventArgs e) //Обновление
        {
            double x = screenSize.Size.Width * 0.95;
            View(x,"");
            
            textBox1.Clear();
        }
        #endregion

        #region Text for filter
        private void textBox1_TextChanged(object sender, EventArgs e) //Фильтр
        {

            string rr = string.Format("(Convert(Офис, System.String) LIKE '%{0}%') OR (Convert(Город, System.String) LIKE '%{0}%') OR (Convert(Мобильный, System.String) LIKE '%{0}%') OR (Convert(Кабинет, System.String) LIKE '%{0}%') OR (Должность LIKE  '%{0}%') OR (ФИО LIKE  '%{0}%') OR (Подразделение LIKE  '%{0}%')", textBox1.Text);
             double x = screenSize.Size.Width * 0.95;
          
            View(x, rr);

        }
        #endregion
       
        #region Работа с переходами режимов экрана
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            double x = screenSize.Size.Height;
            double y = screenSize.Size.Width;

            if (panel1.Size.Height == 330)
            {
                x = screenSize.Size.Height;
                y = screenSize.Size.Width;
                tableLayoutPanel1.Size = new Size((int)y, (int)(x * 0.25));
                panel1.Size = new Size((int)y, (int)(x * 0.65));
                dataGridView1.Size = new Size((int)y, (int)(x * 0.65));              
            }
            else
            {
                panel1.Size = new Size(970, 330);          
                
                tableLayoutPanel1.Size = new Size(970, 181);
            }

            textBox1.Clear();
            View(y, "");       
        }
        #endregion

        #region Лист подразделений (ComboBox)
        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {
            double x = screenSize.Size.Width * 0.95;
           
            string select = (string)list.SelectedItem;
            string like = "(Подразделение LIKE  '" + select + "*')";
            textBox1.Clear();
            View(x, like);
           dataGridView1.Focus();

              
        }
        #endregion

        #region Настройки
        private void info_Click(object sender, EventArgs e)
        {
           
           Info_Form f = new Info_Form();
           
            f.ShowDialog();
        }
        #endregion
    }
}
