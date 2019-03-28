using ChestieMVP.AdditionalElements;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO.Packaging;
using TotalCommander.Classes;
using TotalCommander.MainViews;
using TotalCommander.AdditionalElements;

namespace ChestieMVP.MainViews
{
    /// <summary>
    /// Interaction logic for MenuView.xaml
    /// 
    /// </summary>
    public partial class MenuView : UserControl
    {
        public MenuView(SideView sideLeft, SideView sideRight)
        {
            InitializeComponent();
            this.sideLeft = sideLeft;
            this.sideRight = sideRight;
        }
        // Viitoarea parte selectata (left/right)
        SelectedSide selectedSite;

        //De tipul definit sunt create doua variabile, pt simetrie (Stanga/Dreapta)
        public SideView sideLeft { get; set; }
        public SideView sideRight { get; set; }

        FocusCommunication communication = new FocusCommunication();
        private void About_Click(object sender, RoutedEventArgs e)
        {
            AboutWindow aw = new AboutWindow();
            aw.Show();
        }

        private void Tree_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Full_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Unpack_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Pack_Click(object sender, RoutedEventArgs e)
        {
            //Ne luam path-ul directorului
            if (sideRight.SelectedElement != null)
            {
                selectedSite = SelectedSide.right;
            }
            else selectedSite = SelectedSide.left;

            string dirName = selectedSite == SelectedSide.left ? sideLeft.SelectedElement.Path : sideRight.SelectedElement.Path;
            string fileName = selectedSite == SelectedSide.left ? sideLeft.SelectedElement.getName() : sideRight.SelectedElement.getName();
            string sourcePath = selectedSite == SelectedSide.left ? sideLeft.mainPath.Text : sideRight.mainPath.Text;
            string targetPath = selectedSite == SelectedSide.left ? sideRight.mainPath.Text : sideLeft.mainPath.Text;
            ZIP dialog = new ZIP(sourcePath, targetPath, fileName);
            dialog.Show();
            RefreshAllList();
        }

        private void RefreshAllList()
        {
            sideLeft.RefreshList();
            sideRight.RefreshList();
        }

        private void Compare_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
