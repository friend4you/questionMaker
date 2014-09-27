namespace QuestionPackMaker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnCreatePack = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Question1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RightAnswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WrongAnswer1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WrongAnswer2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WrongAnswer3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.btnCreatePack);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnAddQuestion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 490);
            this.panel1.TabIndex = 0;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(655, 59);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(555, 59);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(455, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(355, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(54, 21);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(301, 58);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // btnCreatePack
            // 
            this.btnCreatePack.Location = new System.Drawing.Point(783, 403);
            this.btnCreatePack.Name = "btnCreatePack";
            this.btnCreatePack.Size = new System.Drawing.Size(75, 23);
            this.btnCreatePack.TabIndex = 2;
            this.btnCreatePack.Text = "CreatePack";
            this.btnCreatePack.UseVisualStyleBackColor = true;
            this.btnCreatePack.Click += new System.EventHandler(this.btnCreatePack_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Question1,
            this.RightAnswer,
            this.WrongAnswer1,
            this.WrongAnswer2,
            this.WrongAnswer3});
            this.dataGridView1.DataSource = this.questionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(765, 375);
            this.dataGridView1.TabIndex = 1;
            // 
            // Question1
            // 
            this.Question1.HeaderText = "Question";
            this.Question1.Name = "Question1";
            this.Question1.Width = 300;
            // 
            // RightAnswer
            // 
            this.RightAnswer.HeaderText = "RightAnswer";
            this.RightAnswer.Name = "RightAnswer";
            // 
            // WrongAnswer1
            // 
            this.WrongAnswer1.HeaderText = "WrongAnswer";
            this.WrongAnswer1.Name = "WrongAnswer1";
            // 
            // WrongAnswer2
            // 
            this.WrongAnswer2.HeaderText = "WrongAnswer";
            this.WrongAnswer2.Name = "WrongAnswer2";
            // 
            // WrongAnswer3
            // 
            this.WrongAnswer3.HeaderText = "WrongAnswer";
            this.WrongAnswer3.Name = "WrongAnswer3";
            // 
            // questionBindingSource
            // 
            this.questionBindingSource.DataSource = typeof(QuestionPackMaker.Question);
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Location = new System.Drawing.Point(783, 21);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(78, 38);
            this.btnAddQuestion.TabIndex = 0;
            this.btnAddQuestion.Text = "Add";
            this.btnAddQuestion.UseVisualStyleBackColor = true;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 490);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource questionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Question1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RightAnswer;
        private System.Windows.Forms.DataGridViewTextBoxColumn WrongAnswer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn WrongAnswer2;
        private System.Windows.Forms.DataGridViewTextBoxColumn WrongAnswer3;
        private System.Windows.Forms.Button btnCreatePack;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

