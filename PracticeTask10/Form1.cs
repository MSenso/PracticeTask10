using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace PracticeTask10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OneList list;
        int x = 101;
        Label x_label, sum_label;
        TextBox x_input;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        string[] Read_FromFile() // Чтение из файла
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Открытие текстового файла";
            openFileDialog1.Filter = "Текстовые файлы|*.txt";
            openFileDialog1.InitialDirectory = "";
            string[] filelines = null;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                filelines = File.ReadAllLines(filename);
            }
            return filelines;
        }
        void Make_List() // Создание списка
        {
            string[] lines = Read_FromFile(); // Чтение из файла
            if (lines != null) // Не пустой файл
            {
                if (lines.Length <= 20) // Количество строк в файле не больше 20
                {
                    list = new OneList(lines); // Создание списка из строк
                    if (list.Length == 0) MessageBox.Show("Файл содержит некорректные данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        list_output.Text = list.Show();
                        // Доступно вычисление полинома
                        вычислениеПолиномаToolStripMenuItem.Enabled = true;
                    }
                }
                else MessageBox.Show("Строк в файле должно быть не больше 20!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Пустой файл!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void созданиеСпискаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Make_List();
        }
        public void Add_X() // Добавление элементов управления для ввода х
        {
            x_label = new Label()
            {
                Name = "x_label",
                Text = "Введите x:",
                AutoSize = true,
                Location = new System.Drawing.Point(list_output.Location.X, list_output.Location.Y + list_output.Height + 20),
                BackColor = Color.Transparent,
                ForeColor = Color.Black,
                Font = list_output.Font
            };
            Controls.Add(x_label);
            x_input = new TextBox()
            {
                Name = "x_input",
                Size = new Size(60, 40),
                Location = new System.Drawing.Point(x_label.Location.X + x_label.Width + 10, x_label.Location.Y),
                BackColor = Color.FromArgb(255, 245, 248),
                ForeColor = Color.Black,
                Font = list_output.Font
            };
            x_input.KeyDown += new KeyEventHandler(X_Input_KeyDown);
            Controls.Add(x_input);
            x_input.Focus();
        }
        void Print_Sum() // Вывод суммы
        {
            if (int.TryParse(x_input.Text, out x)) // Введено целое х
            {
                if (Math.Abs(x) <= 100) // х по модулю не превосходит 100
                {
                    if (x != 0) // х не равно 0
                    {
                        double sum = list.Sum_Calculation(x); // Вычисление суммы полинома
                        if (sum_label != null) // Сумма уже выводилась ранее
                        {
                            sum_label.Text = "Полином равен: " + sum.ToString(); // Вывод суммы
                            sum_label.Visible = true;
                        }
                        else
                        {
                            sum_label = new Label() // Создание метки для вывода суммы
                            {
                                Name = "sum_label",
                                Text = "Полином равен: " + sum.ToString(),
                                AutoSize = true,
                                Location = new System.Drawing.Point(x_label.Location.X, x_label.Location.Y + x_label.Height + 20),
                                BackColor = Color.Transparent,
                                ForeColor = Color.Black,
                                Font = list_output.Font
                            };
                            Controls.Add(sum_label); // Вывод суммы
                        }
                        x_input.Focus(); // Фокус снова на текстбоксе для ввода х
                    }
                    else
                    {
                        x_input.Enabled = false;
                        MessageBox.Show("Вы ввели 0, выберите заново список для вычисления полинома", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Remove_Elements(); // Очищение формы
                        вычислениеПолиномаToolStripMenuItem.Enabled = false;
                        x = 101;
                        list_output.Text = string.Empty;
                    }
                }
                else MessageBox.Show("х не должен превышать 100 по модулю!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Введите целое число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        void Remove_Elements() // Очищение формы
        {
            if (x_label != null) // Если не удалено
            {
                Controls.Remove(x_label); // Удаление
                x_label = null;
            }
            if (x_input != null) // Если не удалено
            {
                Controls.Remove(x_input); // Удаление
                x_input = null;
            }
            if (sum_label != null) // Если не удалено
            {
                Controls.Remove(sum_label); // Удаление
                sum_label = null;
            }
        }
        void X_Input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Нажат энтер
            {
                Print_Sum(); // Вывод суммы
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void вычислениеПолиномаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_X(); // Вывод элементов управления для ввода х
        }
    }
}
