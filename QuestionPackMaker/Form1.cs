using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QuestionPackMaker
{
    public partial class Form1 : Form
    {
        List<Question> Questions;
        public Form1()
        {
            InitializeComponent();
            Questions = new List<Question>();


        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows[dataGridView1.RowCount - 1].Cells["Question1"].Value = richTextBox1.Text;
            dataGridView1.Rows[dataGridView1.RowCount - 1].Cells["RightAnswer"].Value = textBox1.Text;
            dataGridView1.Rows[dataGridView1.RowCount - 1].Cells["WrongAnswer1"].Value = textBox2.Text;
            dataGridView1.Rows[dataGridView1.RowCount - 1].Cells["WrongAnswer2"].Value = textBox3.Text;
            dataGridView1.Rows[dataGridView1.RowCount - 1].Cells["WrongAnswer3"].Value = textBox4.Text;

        }

        public int clearCell()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++ )
            {
                for (int j = 0; j < 5; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value == null) return i;
                }
            }

                return -1;
        }

        public int fileExist()
        {
            for (int packNum = 0; packNum < packNum + 1; packNum++)
            {
                if (File.Exists("QuestionPack" + packNum + ".xml") == false) return packNum;
            }
            return -1;
        }

        void writeToFile(List<Question> questions)
        {
            int packNum = fileExist();
            TextWriter write = new StreamWriter("QuestionPack" + packNum + ".xml");
            write.WriteLine("<Questions>");
            foreach (Question q in questions)
            {
                write.WriteLine("<Question>");
                write.WriteLine("<Text>" + q.question + "</Text>");
                write.WriteLine("<A>" + q.question + "</A>");
                write.WriteLine("<B>" + q.question + "</B>");
                write.WriteLine("<C>" + q.question + "</C>");
                write.WriteLine("<D>" + q.question + "</D>");
                write.WriteLine("<CorrectAnswer>" + q.question + "</CorrectAnswer>");
                write.WriteLine("</Question>");
                write.WriteLine("");
                write.WriteLine("");
            }
            write.WriteLine("</Questions>");
            write.Close();
        }

        private void btnCreatePack_Click(object sender, EventArgs e)
        {
            int cell = clearCell();
            if (cell != -1)
            {
                MessageBox.Show("Пустое значение в строке" + cell);
                return; 
            }

            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                Question question = new Question();
                question.question = dataGridView1.Rows[i].Cells["Question1"].Value.ToString();
                question.rightAnswer = dataGridView1.Rows[i].Cells["RightAnswer"].Value.ToString();
                question.wrongAnswer1 = dataGridView1.Rows[i].Cells["WrongAnswer1"].Value.ToString();
                question.wrongAnswer2 = dataGridView1.Rows[i].Cells["WrongAnswer2"].Value.ToString();
                question.wrongAnswer3 = dataGridView1.Rows[i].Cells["WrongAnswer3"].Value.ToString();
                Questions.Add(question);
            }
            writeToFile(Questions);
            Questions.Clear();
            dataGridView1.Rows.Clear();
        }
    }
}
