using System.Data;
using System.Text;

namespace OrnekDatatable
{
    public partial class Form1 : Form
    {
        DataTable table = new DataTable();
        private DataRow rows;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataColumn[] cols =
            {
                new DataColumn("Kimden Alindi",typeof(String)),
                new DataColumn("Miktar�",typeof(Decimal)),
                new DataColumn("�deme Y�ntemi",typeof(String)),
                new DataColumn("�deme Tarihi",typeof(DateTime)),
                new DataColumn("Fatura No",typeof(Int64)),
                new DataColumn("�ehir",typeof(String)),
                new DataColumn("Fatura T�r�",typeof(String)),
                new DataColumn("�deme Kontrol",typeof(bool))
            };
            table.Columns.AddRange(cols);

            Object[] rows =
            {
                new Object[]{"Ahmet Kaya", 350, "Mastercard", "30.04.2021", 3000, "London","Bireysel",false},
                new Object[]{"R�fk� G�kalp", 260, "Havale", "01.10.2022", 9000, "Paris","Kurumsal",true},
                new Object[]{"Zeynep Demirel", 1980, "Eft", "30.05.2020", 3974, "New York","Bireysel",true},
                new Object[]{"Fahriye T�rk", 7000, "Mastercard", "01.01.2023", 1117, "Tokyo","Kurumsal",true},
                new Object[]{"Semih �ent�rk", 1000, "Havale", "15.04.2021", 7777, "Edinburg","Bireysel",false},
                new Object[]{"Semih �ent�rk", 500, "Visa", "19.02.2021", 5817, "Edinburg","Bireysel",true},
                new Object[]{"Robert Brown", 20000, "Eft", "03.09.2020", 5557, "�stanbul","Kurumsal",false}
            };
            foreach (Object[] row in rows)
            {
                table.Rows.Add(row);
            }
            dataGridView1.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int64 faturano;
            Random rnd = new Random();
            faturano = rnd.Next(1000, 10000);
            textBoxFaturaNo.Text = faturano.ToString();
            if (comboBoxKimden.Text != "" && textBoxMiktar.Text != "")
            {
                rows = table.NewRow();
                rows["Kimden Alindi"] = comboBoxKimden.Text;
                rows["Miktar�"] = textBoxMiktar.Text;
                rows["�deme Y�ntemi"] = comboBoxOdeme.Text;
                rows["�deme Tarihi"] = dateTimePicker1.Value;
                rows["Fatura No"] = faturano;
                rows["�ehir"] = comboBoxSehir.Text;
                rows["Fatura T�r�"] = comboBoxFatura.Text;
                rows["�deme Kontrol"] = checkBox1.Checked;
                table.Rows.Add(rows);
                dataGridView1.DataSource = table;
            }
            else
            {
                MessageBox.Show("M��teri Bilgilerini Eksiksiz Giriniz!");
            }
        }
    }
}