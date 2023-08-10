using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linq_App_3202
{
    public partial class Form1 : Form
    {
        static private List<Product> products = new List<Product>()
        {
            new Product() {Name="탕후루", Type = "간식", Price=4000},
            new Product() {Name="마라탕", Type = "식사", Price=7000},
            new Product() {Name="햄버거", Type = "식사", Price=6500},
            new Product() {Name="빙수", Type = "간식", Price=10000},
            new Product() {Name="돈까스", Type = "식사", Price=9000},
            new Product() {Name="칼국수", Type = "식사", Price=6000},
            new Product() {Name="아이스크림", Type = "간식", Price=1000},
            new Product() {Name="자가비", Type = "간식", Price=2000},
            new Product() {Name="라면", Type = "식사", Price=5000},
            new Product() {Name="김치볶음밥", Type = "식사", Price=8000},//10
            new Product() {Name="와플", Type = "간식", Price=4000},
            new Product() {Name="버블티", Type = "간식", Price=4000},
            new Product() {Name="떡볶이", Type = "식사", Price=5000},
            new Product() {Name="치킨", Type = "식사", Price=20000},
            new Product() {Name="김치찜", Type = "식사", Price=15000},
            new Product() {Name="딸기라떼", Type = "간식", Price=4000},
            new Product() {Name="짬뽕", Type = "식사", Price=8000},
            new Product() {Name="케이크", Type = "간식", Price=30000},
            new Product() {Name="쿠키", Type = "간식", Price=3000},
            new Product() {Name="초밥", Type = "식사", Price=12000},
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            productBindingSource.DataSource = products;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            productBindingSource.DataSource = from item in products
                                              select item;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            productBindingSource.DataSource = from item in products
                                              orderby item.Name
                                              select item;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            productBindingSource.DataSource = from item in products
                                              orderby item.Price descending
                                              select item;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            productBindingSource.DataSource = from item in products
                                              where item.Price >= 8000
                                              orderby item.Price descending
                                              select item;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            productBindingSource.DataSource = from item in products
                                              where item.Type == "식사" 
                                              orderby item.Name
                                              select item;
        }
    }
}
