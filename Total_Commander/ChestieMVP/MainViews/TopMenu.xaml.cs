using ChestieMVP.AdditionalElements;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.IO;
using System.IO.Compression;
using TotalCommander.Classes;
using System.Security.Permissions;

namespace TotalCommander.MainViews
{
    /// <summary>
    /// Interaction logic for TopMenu.xaml
    /// </summary>
    public partial class TopMenu : UserControl
    {
        // Viitoarea parte selectata (left/right)
        SelectedSide selectedSite;

        //De tipul definit sunt create doua variabile, pt simetrie (Stanga/Dreapta)
        public SideView sideLeft { get; set; }
        public SideView sideRight { get; set; }

        FocusCommunication communication = new FocusCommunication();
        public TopMenu(SideView sideLeft, SideView sideRight)
        {
            InitializeComponent();
            this.sideLeft = sideLeft;
            this.sideRight = sideRight;
        }
        public delegate void UNZIPEDEventHandler();
        public event UNZIPEDEventHandler ShowAfterUNZIPED;

        protected virtual void onShowAfterUNZIPED()
        {
            if (ShowAfterUNZIPED != null)
            {
                ShowAfterUNZIPED.Invoke();
            }
        }
        private void Unpack_Click(object sender, RoutedEventArgs e)
        {
            if (sideRight.SelectedElement != null)
            {
                selectedSite = SelectedSide.right;
            }
            else selectedSite = SelectedSide.left;
            sideLeft.isActive = false;
            sideRight.isActive = false;
            string sourcePath = selectedSite.ToString() == "left" ? sideLeft.mainPath.Text : sideRight.mainPath.Text;
            string targetPath = selectedSite.ToString() == "left" ? sideRight.mainPath.Text : sideLeft.mainPath.Text;

            FileIOPermission f = new FileIOPermission(PermissionState.Unrestricted);
            f.AllLocalFiles = FileIOPermissionAccess.AllAccess;

            try
            {
                /*
                 * string startPath = @"c:\example\start";
                 * string zipPath = @"c:\example\result.zip";
                 * string extractPath = @"c:\example\extract";

                 * System.IO.Compression.ZipFile.CreateFromDirectory(startPath, zipPath);
                 * System.IO.Compression.ZipFile.ExtractToDirectory(zipPath, extractPath);
                 */
                f.Demand();
                string temppath = System.IO.Path.Combine(targetPath, System.IO.Path.GetFileNameWithoutExtension(sourcePath));
                Directory.CreateDirectory(temppath);

                System.IO.File.SetAttributes(sourcePath, System.IO.FileAttributes.Archive);
                System.IO.File.SetAttributes(targetPath, System.IO.FileAttributes.Normal);

                ZipFile.ExtractToDirectory(sourcePath, targetPath);
                ShowAfterUNZIPED();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Something went wrong\n" + exp.Message);
            }
        }
        private void Pack_Click(object sender, RoutedEventArgs e)
        {
            //Ne luam path-ul directorului
            if (sideRight.SelectedElement != null)
            {
                selectedSite = SelectedSide.right;
            }
            else selectedSite = SelectedSide.left;

            string fileName = selectedSite == SelectedSide.left ? sideLeft.SelectedElement.getName() : sideRight.SelectedElement.getName();
            string sourcePath = selectedSite == SelectedSide.left ? sideLeft.mainPath.Text : sideRight.mainPath.Text;
            string targetPath = selectedSite == SelectedSide.left ? sideRight.mainPath.Text : sideLeft.mainPath.Text;
            ZIP dialog = new ZIP(sourcePath, targetPath, fileName);
            dialog.Show();
        }

        private void RefreshAllList()
        {
            sideLeft.RefreshList();
            sideRight.RefreshList();
        }
    }
}
