using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string s = "Provider=Microsoft.Jet.OLEDB.12.0;Data Source=Spusok_ychniv.accdb";
        private OleDbConnection conn;
        private void button1_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(s);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "spusok_ychnivDataSet1.Рух_студентів". При необходимости она может быть перемещена или удалена.
            this.рух_студентівTableAdapter.Fill(this.spusok_ychnivDataSet1.Рух_студентів);

            this.рух_студентівTableAdapter.Fill(this.spusok_ychnivDataSet.Рух_студентів);


        }
    }
}
