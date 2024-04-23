using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;//исправ
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MyDiplom
{
    public partial class Ежедневник : Form
    {
        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = BD.mdb";//строка подключен.(исправ)
       
        private OleDbConnection myConnection;

        public Ежедневник()
        { 
            InitializeComponent();

            myConnection = new OleDbConnection(connectString);

            myConnection.Open();// исправ(соединен с БД)
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet1.Группы". При необходимости она может быть перемещена или удалена.
            this.группыTableAdapter1.Fill(this.bDDataSet1.Группы);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form2 Form1 = new Form2();
            Form1.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            //перебирает все ячейки таблицы и
            //устанавливает в них белый цвет фона и чёрный цвет текста, то есть,
            //отменяет результаты предыдущего поиска
            for (int i = 0; i < dataGridView1.ColumnCount - 1; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount - 1; j++)
                {
                    dataGridView1[i, j].Style.BackColor = Color.White;
                    dataGridView1[i, j].Style.ForeColor = Color.Black;
                }
            }
            //перебирает все ячейки таблицы и если они
            //содержат текст, введённый в поле ввода (TextBox1), то устанавливает в них
            //голубой цвет фона и синий цвет текста, чем выделяет искомые ячейки.
            for (int i = 0; i < dataGridView1.ColumnCount - 1; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount - 1; j++)
                {
                    if (dataGridView1[i, j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        dataGridView1[i, j].Style.BackColor = Color.AliceBlue;
                        dataGridView1[i, j].Style.ForeColor = Color.Blue;

                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            группыBindingSource1.RemoveCurrent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.группыTableAdapter.Fill(this.bDDataSet.Группы);
            // Если связывание было выполнено правильно, то должна была появиться эта запись  
            // myBase, tab1 - это название Вашей базы и ее таблицы.
            группыTableAdapter.Update(this.bDDataSet.Группы);
            String path = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = BD.mdb"; // Адрес базы данных
            MessageBox.Show("Новая запись добавлена");
        }

        private void группаBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form3 Form1 = new Form3();
            Form1.ShowDialog();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 Form1 = new Form4();
            Form1.ShowDialog();
            Close();
        }
    }

   
}
