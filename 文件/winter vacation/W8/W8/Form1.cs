﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W8
{
    public partial class Form1 : Form
    {
        private List<Class1> products;
        private List<Class2> s;

        public Form1()
        {
            InitializeComponent();
            CreateSale();
            CreateProduts();
            dataGridView1.DataSource = s;
            dataGridView2.DataSource = products;
            var maxproducts = products.Where((x) => x.Total == products.Max((X) => X.Total));
            foreach (var p in maxproducts)
            {
                label6.Text = p.Product;
            }
            var maxsales = s.Where((x) => x.saleasAmount == s.Max((X) => X.saleasAmount));
            foreach (var s in maxsales)
            {
                label5.Text = s.sales;
            }
        }
        private void CreateProduts()
        {
            products = new List<Class1>();
            products.Add(new Class1 { Product = "原子筆", Money = 12, Many = (33 + 77 + 43), Total = 12 * 153 });
            products.Add(new Class1 { Product = "鉛筆", Money = 16, Many = (32 + 33 + 55), Total = 16 * 120 });
            products.Add(new Class1 { Product = "橡皮擦", Money = 10, Many = (56 + 68 + 43), Total = 10 * 167 });
            products.Add(new Class1 { Product = "直尺", Money = 14, Many = (45 + 23 + 67), Total = 14 * 157 });
            products.Add(new Class1 { Product = "立可白", Money = 15, Many = (33 + 23 + 65), Total = 15 * 121 });

        }

        private void CreateSale()
        {
            s = new List<Class2>();

            s.Add(new Class2 { sales = "Bill", pen = 33, pencil = 32, eraser = 56, ruler = 45, whiteout = 33, saleasAmount = (33 * 12) + (32 * 16) + (56 * 10) + (45 * 14) + (33 * 15) });
            s.Add(new Class2 { sales = "John", pen = 77, pencil = 33, eraser = 68, ruler = 23, whiteout = 23, saleasAmount = (77 * 12) + (33 * 16) + (68 * 10) + (23 * 14) + (23 * 15) });
            s.Add(new Class2 { sales = "David", pen = 43, pencil = 55, eraser = 43, ruler = 67, whiteout = 65, saleasAmount = (43 * 12) + (55 * 16) + (43 * 10) + (67 * 14) + (65 * 15) });

        }
       
     }
}

    

