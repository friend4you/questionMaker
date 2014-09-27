using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
           
            dataGridView1.Rows[dataGridView1.RowCount-1].Cells["Question1"].Value = richTextBox1.Text;
            
        }

        void questionsToFile(List<Question> questions)
        {

        }

        private void btnCreatePack_Click(object sender, EventArgs e)
        {
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
            
        }
    }
}
