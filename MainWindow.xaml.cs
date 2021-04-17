using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SortedListApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SortedList sortedlist;
        public MainWindow()
        {
            InitializeComponent();
            sortedlist = new SortedList();
        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            sortedlist.Add(int.Parse(txtKey.Text), txtValue.Text);

            ICollection icollection = sortedlist.Keys;

            string output = "" ;

            foreach(int key in icollection)
            {
                output = output + sortedlist[key].ToString() + Environment.NewLine;
            }

            MessageBox.Show(output);
        }
    }
}
