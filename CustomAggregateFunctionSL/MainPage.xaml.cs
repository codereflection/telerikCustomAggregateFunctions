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
                items.Add(new Item() { stringValue = i.ToString(), intValue = i * 2, datetimeValue = DateTime.Now, floatValue = i * 1.5f });
            }
            this.RadGridView1.ItemsSource = items;
            this.RadGridView1.Columns[0].AggregateFunctions.Add(new MyAggregateSelectorFunction { SourceField = "stringValue" });
            this.RadGridView1.Columns[1].AggregateFunctions.Add(new MyAggregateSelectorFunction { SourceField = "intValue" });
            this.RadGridView1.Columns[2].AggregateFunctions.Add(new MyAggregateSelectorFunction { SourceField = "datetimeValue" });
            this.RadGridView1.Columns[3].AggregateFunctions.Add(new MyAggregateSelectorFunction { SourceField = "floatValue" });
        }
    }

    public class Item
    {
        public string stringValue { get; set; }
        public int intValue { get; set; }
        public DateTime datetimeValue { get; set; }
        public float floatValue { get; set; }
    }
}
