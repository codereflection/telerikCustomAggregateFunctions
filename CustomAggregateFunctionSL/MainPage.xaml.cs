using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.IO;
using Telerik.Windows.Controls;
using System.Collections;

namespace CustomAggregateFunctionSL
{
    public partial class MainPage : UserControl
    {

        public MainPage()
        {

            InitializeComponent();
            List<Item> items = new List<Item>();
            for (int i = 0; i < 10; i++)
            {
                items.Add(new Item() { Value1 = i.ToString(), Value2 = i * 2, Value3 = DateTime.Now, Value4 = i * 1.5f });
            }
            this.RadGridView1.ItemsSource = items;
            this.RadGridView1.Columns[0].AggregateFunctions.Add(new MyAggregateSelectorFunction { SourceField = "Value1" });
            this.RadGridView1.Columns[1].AggregateFunctions.Add(new MyAggregateSelectorFunction { SourceField = "Value2" });
            this.RadGridView1.Columns[2].AggregateFunctions.Add(new MyAggregateSelectorFunction { SourceField = "Value3" });
            this.RadGridView1.Columns[3].AggregateFunctions.Add(new MyAggregateSelectorFunction { SourceField = "Value4" });
        }
    }

    public class Item
    {
        public string Value1 { get; set; }
        public int Value2 { get; set; }
        public DateTime Value3 { get; set; }
        public float Value4 { get; set; }
    }
}
