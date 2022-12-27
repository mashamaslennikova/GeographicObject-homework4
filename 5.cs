using System;
using System.Data;
using System.Diagnostics;
using System.Xml.Linq;

namespace Завдання_5
{

    public partial class Вікно : Form
    {
        uint price1 = 0, price2 = 0;
        string name1 = "", name2 = "";
        string packingDate1 = "", description2 = "";
        string description1 = "", description2 = "";
        int index1 = 0;
        int index2 = 0;

        uint expirationDate = 0;
        uint number = 0;
        string unit = "";

        string author = "";
        uint numberOfPage = 0;
        string publishingHouse = "";

        DataTable table1 = new DataTable();
        DataTable table2 = new DataTable();

        List<Product> products = new List<Product>(); //Лист створений для виконання завдання підпункту 5, тобто заповнення таблиці стартовими значеннями.ЛИСТ НЕ БЕРЕ УЧАСТІ В ОСНОВНОМУ МЕХАНІЗМІ
        List<Book> books = new List<Book>(); //Лист створений для виконання завдання підпункту 5, тобто заповнення таблиці стартовими значеннями.ЛИСТ НЕ БЕРЕ УЧАСТІ В ОСНОВНОМУ МЕХАНІЗМІ 


        public Вікно()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            products.Add(new Product(15, "Вода мінеральна Поляна Квасова 1,5 л", "04.10.2022", "Тип: напої; обєм: 1,5 л", 365, 1, "Літри"));
            products.Add(new Product(16, "Вода мінеральна Bonague 1,5 л", "04.10.2022", "Тип: напої; обєм: 1,5 л", 365, 2, "Літри"));
            products.Add(new Product(11, "Вода мінеральна Моршинська сильногазована 1,5 л", "04.10.2022", "Тип: напої сильногазовані; обєм: 1,5 л", 365, 3, "Літри"));
            products.Add(new Product(249, "Кава розчинна Jacobs 200 г", "04.10.2022", "Тип: розчинні напої; маса: 200г", 730, 4, "Грами"));
            products.Add(new Product(189, "Чай пакетований Lovare 100 шт.х 2г", "04.10.2022", "Тип: розчинні напої; маса: 200 г", 24 * 30, 5, "Грами"));

            table1.Columns.Add("Ціна", typeof(int));
            table1.Columns.Add("Ім'я", typeof(string));
            table1.Columns.Add("Дата пакування", typeof(string));
            table1.Columns.Add("Опис", typeof(string));
            table1.Columns.Add("Термін придатності", typeof(int));
            table1.Columns.Add("Номер", typeof(int));
            table1.Columns.Add("Одиниця вимірювання", typeof(string));

            for (int i = 0; i < products.Count; i++)
            {
                table1.Rows.Add(products[1].Price, products[i].Name, products[i].PackingDate, products[i].Description, products[i].ExpirationDate, products[i].Number, products[i].Unit);
                index1++;
            }
            DataGridView1.DataSource = table1;

            books.Add(new Book(105, "Божественна комедія- Данте", "04.10.2022", "Палітурка - тверда", "Данте", 368, "BookChef"));
            books.Add(new Book(176, "Перевтілення- Франц Кафка", "04.10.2022", "Палітурка - тверда", "Франц Кафка", 272, "BookChef"));
            books.Add(new Book(264, "Парфюмер- Патрік Сюскенд", "04.10.2022", "Палітурка - тверда", "Патрік Сюскент", 320, "Форс"));

            table2.Columns.Add("Ціна", typeof(int));
            table2.Columns.Add("Ім'я", typeof(string));
            table2.Columns.Add("Дата пакування", typeof(string));
            table2.Columns.Add("Опис", typeof(string));
            table2.Columns.Add("Автор", typeof(string));
            table2.Columns.Add("К-сть сторінок", typeof(int));
            table2.Columns.Add("Видавництво", typeof(string));

            for (int i = 0; i < books.Count; i++)
            {
                table2.Rows.Add(books[i].Price, books[i].Name, books[i].PackingDate, books[i].Description, books[i].Description, books[i].Author, books[i].NumberOfPage, books[i].PublishingHouse);
                index2++;
            }
            dataGridView2.DataSource = table2;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataColumnChangeEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                price1 = Convert.ToUInt32(textBox1.Text);
                name1 = textBox2.Text; ;
                packingDate1 = textBox3.Text;
                description1 = textBox4.Text;
                expirationDate = Convert.ToUInt32(textBox5.Text);
                number = Convert.ToUInt32(textBox6.Text);
                unit = textBox7.Text;
                table1.Rows.Add(price1, name1, packingDate1, description1, expirationDate, number, unit);
                dataGridView1.DataSource = table1;
                ++index1;
            }

            catch
            {
                MesssageBox.Show("Введено некоректні дані! Зверніть увагу на стовпчик ціни, терміну придатності та числа");


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                price2 = Convert.ToUInt32(textBox8.Text);
                name2 = textBox9.Text; ;
                packingDate2 = textBox10.Text;
                description2 = textBox4.Text;
                author = textBox12.Text;
                numberOfPage = Convert.ToUInt32(textBox13.Text);
                publishingHouse = textBox14.Text;
                table2.Rows.Add(price2, name2, packingDate2, description2, expirationDate, number, unit);
                dataGridView1.DataSource = table2;
                ++index2;
            }
            catch
            {
                MessageBox.Show("ВВедено некоректні дані! Зверніть увагу на стовпчик ціни та кількості сторінок.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (index1 != 0)
            {
                table1.Rows.RemoveAt(index1 - 1);
                dataGridView1.DataSource = table1;
                --index1;
            }
        }
        private void DeleteBook_Click(object sender, EventArgs e)
        {
            if (index2 != 0)
            {
                table2.Rows.RemoveAt(index2 - 1);
                dataGridView2.DataSource = table2;
                --index2;
            }
        }

        private void DeleteAll_Click(oblect sender, EventArgs e)
        {


            table1.Rows.Clear();
            dataGridView1.DataSource = table1;
            index1 = 0;
        }
    }
}

