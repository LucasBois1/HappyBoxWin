using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Happy_Box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TabAdd_Click(object sender, EventArgs e)
        {

        }

        private void RichTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void RandWord_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            if (totallyRandom.Checked)
                richTextBox2.Text = Program.GetTotallyRandomWord();
            else if (lastWeek.Checked)
                richTextBox2.Text = Program.GetLastWeekRandomWord();
        }

        private void SeeDescription_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Program.GetDescription(richTextBox2.Text);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Program.InsertWord(richTextBox4.Text, richTextBox3.Text);
            richTextBox4.Clear();
            richTextBox3.Clear();
        }

        private void TotallyRandom_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            Tuple<string, string> word = Program.CheckId(int.Parse(richTextBox5.Text));

            richTextBox6.Text = (string) word.Item1;
            richTextBox7.Text = (string) word.Item2;                    
        }

        private void FillDataGrid ( DataGridView Dgv )
        {

            String Id, Word;

            SQLiteConnection conn = Database.GetInstance();

            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT Id, Word FROM words";

            sqlite_datareader = sqlite_cmd.ExecuteReader();

            while (sqlite_datareader.Read())
            {
                Id = sqlite_datareader.GetInt32(0).ToString();
                Word = sqlite_datareader.GetString(1);
                string[] row = { Id, Word };
                Dgv.Rows.Add(row);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillDataGrid(dataGridView1);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Program.RemoveWord(int.Parse(richTextBox5.Text));
            dataGridView1.Rows.RemoveAt(int.Parse(richTextBox5.Text));
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Program.RefreshDataGrid(dataGridView1);
        }
    }
}
