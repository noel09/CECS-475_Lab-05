using System;
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
using System.Windows.Shapes;
using CECS_475___Lab_Assignment_5;

namespace ClientProgram
{
    /// <summary>
    /// Interaction logic for StandardWindow.xaml
    /// </summary>
    public partial class StandardWindow : Window
    {
        BusinessLayer blObj = new BusinessLayer();
        IEnumerable<CECS_475___Lab_Assignment_5.Standard> stdData;

        public StandardWindow()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void load_Loaded(object sender, RoutedEventArgs e)
        {
            stdData = blObj.getAllStandards();

            foreach (var std in stdData)
            {
                outputTextBlock.Text += std;
            }
        }
    }
}
