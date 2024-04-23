using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDiplom
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void записиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.записиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDDataSet1);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet1.Записи". При необходимости она может быть перемещена или удалена.
            this.записиTableAdapter.Fill(this.bDDataSet1.Записи);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form3 Form = new Form3();
            Form.Show();
            this.Hide();
        }
    }
}
