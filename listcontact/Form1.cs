using System.Diagnostics.Eventing.Reader;

namespace listcontact
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("colnom", "Nom");
            dataGridView1.Columns.Add("colmail", "email");

            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "Supprimer";
            btnColumn.Text = "X";
            btnColumn.Name = "btnsupprimer";
            btnColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btnColumn);


            dataGridView1.ReadOnly = true;


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nom = textBox1.Text;
            string email = textBox2.Text;

            if (email.Contains("@"))
            {
                dataGridView1.Rows.Add(nom, email);
            }
            else
            {
                MessageBox.Show("votre adresse email n'est pas valide");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["btnsupprimer"].Index && e.RowIndex >= 0)
            {
                dataGridView1.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}
