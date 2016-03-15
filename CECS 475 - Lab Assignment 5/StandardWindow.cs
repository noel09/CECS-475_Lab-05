using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CECS_475___Lab_Assignment_5
{
    public partial class StandardWindow : Form
    {
        BusinessLayer bLayer = new BusinessLayer();
        IEnumerable<Standard> stdData;

        public StandardWindow()
        {
            InitializeComponent();
        }

        private void StandardWindow_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            outputTextBox.Clear();
            int counter = 1;
            stdData = bLayer.getAllStandards();
            foreach (var ele in stdData)
            {
                outputTextBox.AppendText(counter + ".\tStandard ID: " + ele.StandardId
                                          + "\r\n\tStandard Name: " + ele.StandardName + "\r\n");
                counter++;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddRecord addWindow = new AddRecord(bLayer, "Standard");
            addWindow.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateWindow updtWindow = new UpdateWindow(bLayer, "Standard");
            updtWindow.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteWindow delWindow = new DeleteWindow(bLayer, "Standard");
            delWindow.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchWindow srchWindow = new SearchWindow(bLayer, "Standard");
            srchWindow.Show();
        }
    }
}
