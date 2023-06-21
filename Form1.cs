using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWindowsFormsProject
{


    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            var color = new Color();
            color = Color.FromArgb(255, 0, 255, 0);
            labelOutput1.ForeColor = color;
            try
            {
                int square = Convert.ToInt32(textBoxInput1.Text); // свойство TEXT имеет тип string
                labelOutput1.Text = $"Квадрат числа {square} равен {(square * square).ToString()}";
            }
            catch (Exception)
            {
                string message = "Ошибка";
                labelOutput1.Text = MessageBox.Show(message).ToString(); // вывод системного сообщения

            }

        }

        private void textBoxInput1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog(); // Отображает диалоговое окно, позволяющее пользователю
                                                                  // открыть файл. Этот класс не наследуется.

            openFileDialog.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog.Filter = "Текстовые (шаблон*.txt)|*.txt|Исходник (шаблон *.cs)|*.cs|*Все (шаблон*.*|*.*";
            var result = openFileDialog.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFileDialog.FileName))
                {
                    TextBoxViewer.Text = sr.ReadToEnd();
                }

            }
        }

        private void TextBoxViewer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
