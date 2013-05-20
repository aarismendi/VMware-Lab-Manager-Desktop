using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VMware_Lab_Manager_Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void webBrowser1_LoadCompleted(object sender, NavigationEventArgs e)
        {
            TabItem tab = (TabItem)this.tabControl1.SelectedItem;
            dynamic doc = webBrowser1.Document;
            tab.Header = doc.Title;
        }
    }
}
