using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BiblWorm
{
    public partial class Form1 : Form
    {
        List<Item> its = new List<Item>();

        public Form1()
        {
            InitializeComponent();
        }

        public string Author // автор
        {
            get => textBox1.Text;
            set => textBox1.Text = value;
        }
        public string Title // Название
        {
            get => textBox2.Text;
            set => textBox2.Text = value;
        }
        public string PublishHouse // Издательство
        {
            get => textBox3.Text;
            set => textBox3.Text = value;
        }
        public int Page // Количество страниц
        {
            get => (int)numericUpDown1.Value;
            set => numericUpDown1.Value = value;
        }
        public int Year // Год издания
        {
            get => (int)numericUpDown2.Value;
            set => numericUpDown2.Value = value;
        }
        public int InvNumber // Инвентарный номер
        {
            get => (int)numericUpDown3.Value;
            set => numericUpDown3.Value = value;
        }
        public bool Existence // Наличие
        {
            get => checkBox1.Checked;
            set => checkBox1.Checked = value;
        }
        public bool SortInvNumber // Сортировка по инвентарному номеру
        {
            get => checkBox2.Checked;
            set => checkBox2.Checked = value;
        }
        public bool ReturnTime // Возвращение в срок
        {
            get => checkBox3.Checked;
            set => checkBox3.Checked = value;
        }
        public int PeriodUse // Инвентарный номер
        {
            get => (int)numericUpDown4.Value;
            set => numericUpDown4.Value = value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book b = new Book(Author, Title, PublishHouse, Page, Year, InvNumber, Existence);

            if (ReturnTime)
                b.ReturnSrok();

            b.PriceBook(PeriodUse);

            its.Add(b);

            Author = Title = PublishHouse = "";
            Page = InvNumber = PeriodUse = 0;
            Year = 2000;
            Existence = ReturnTime = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (SortInvNumber)
                its.Sort();

            StringBuilder sb = new StringBuilder();
            foreach (Item item in its)
            {
                sb.Append($"\n{item}");
            }

            richTextBox1.Text = sb.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }
    }
}
