using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TotalCommander.MainViews;
namespace TotalCommander.Classes
{
    //Aceasta clasa se ocupa de stabilirea ultimei "liste" active peste care se vor procesa operatii
    class FocusCommunication
    {
        //Ultimul element activ de tip Side View
        SideView lastActive;
        SelectedSide selectedSide;

        //Initializarea ultimului element activ, folosindu-ne de campul bool isActive din Side View
        public string CorrectSide(SideView sideLeft, SideView sideRight)
        {
            if (sideLeft.isActive != false || sideRight.isActive != false)
            {
                if (sideLeft.isActive == true)
                {
                    sideRight.isActive = false;
                    lastActive = sideLeft;
                }
                if (sideRight.isActive == true)
                {

                    sideLeft.isActive = false;
                    lastActive = sideRight;
                }
            }

            else
            {
                if (lastActive == sideLeft) sideLeft.isActive = true;
                else sideRight.isActive = true;
            }

            selectedSide = sideLeft.isActive == true ? SelectedSide.left : SelectedSide.right;

            string side = selectedSide.ToString();
            return side;

        }
    }
}
