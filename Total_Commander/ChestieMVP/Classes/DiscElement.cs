using System;
using System.Windows.Controls;

namespace TotalCommander.Classes
{
    //Clasa abstracta destinata extragerii de date despre director
    public abstract class DiscElement
    {

        public string Path { get; }
        public DateTime creationDate { get; set; }
        public DiscElement(string path)
        {
            this.Path = path;
        }
        public Image icon { get; set; }

        public abstract string getDescription();
        public abstract bool isFile();
        public abstract string getName();
    }
}
