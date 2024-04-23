using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDiplom
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet1.Группы". При необходимости она может быть перемещена или удалена.
            this.группыTableAdapter1.Fill(this.bDDataSet1.Группы);


        }



        private void button5_Click(object sender, EventArgs e)
        {
            this.группыTableAdapter.Fill(this.bDDataSet.Группы);
            // Если связывание было выполнено правильно, то должна была появиться эта запись  
            // myBase, tab1 - это название Вашей базы и ее таблицы.
            группыTableAdapter.Update(this.bDDataSet.Группы);
            string path = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = BD.mdb"; // Адрес базы данных
            MessageBox.Show("Новая запись добавлена");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide(); //свернуть форму 1
            Ежедневник Form2 = new Ежедневник();
            Form2.ShowDialog();
            Close();

        }
    }
    
}
