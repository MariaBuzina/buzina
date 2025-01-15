using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "user" && textBox2.Text == "user")
            {
                MainForm mainForm = new MainForm();
                this.Visible = false;
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Ошибка авторизации!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] captchaFile;
            captchaFile = Directory.GetFiles(@".\Resources\", "*.png");

            Random random = new Random();
            int index = random.Next(captchaFile.Length);
            pictureBox1.Image = Image.FromFile(captchaFile[index]);
        }

        private bool isTextVisible = false;
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            isTextVisible = !isTextVisible; // Переключаем состояние

            if (isTextVisible)
            {
                textBox2.PasswordChar = default; // Показываем текст
            }
            else
            {
                textBox2.PasswordChar = '*'; // Скрываем текст
            }
        }
    }
}
