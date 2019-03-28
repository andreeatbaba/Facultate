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
using System.IO;
using System.IO.Compression;
using TotalCommander.Classes;
using TotalCommander.MainViews;

namespace ChestieMVP.AdditionalElements
{
    /// <summary>
    /// Interaction logic for ZIP.xaml
    /// </summary>
    public partial class ZIP : Window
    {

        public string sourcePath { get; set; }
        public string targetPath { get; set; }
        public string fileName { get; set; }
        public ZIP(string sourcePath, string targetPath, string fileName)
        {
            InitializeComponent();
            this.sourcePath = sourcePath;
            this.targetPath = targetPath;
            this.fileName = fileName;
        }

        public delegate void ZIPEDEventHandler();
        public event ZIPEDEventHandler ShowAfterZIPED;
        private string newFileName { get; set; }

        protected virtual void onShowAfterZIPED()
        {
            if (ShowAfterZIPED != null)
            {
                ShowAfterZIPED.Invoke();
            }
        }
        private void Create(object sender, RoutedEventArgs e)
        {
            if (ItemNameTB.Text != null)
            {
                this.newFileName = ItemNameTB.Text;
            }
            else
            {
                this.newFileName = this.fileName;
            }
            try
                { 
                    ZipFile.CreateFromDirectory(sourcePath, (targetPath + newFileName + ".rar"));
                    onShowAfterZIPED();
                    ItemNameTB.Text = "";
                    this.Close();
                }
                catch (IOException exep)
                {
                    MessageBox.Show("The problem:" + exep.Message);
                    return;
                }
                catch(UnauthorizedAccessException exep)
                {
                MessageBox.Show("You're not authorized to access the file you're trying to\n" + exep.Message);
                return;
                }
           
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
