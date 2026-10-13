using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceGyakorlas_PCs
{
    internal class Video : IContent
    {
        private string title;
        private int length;

        public Video(string title, int length)
        {
            this.title = title;
            this.length = length;
        }

        public string getTitle()
        {
            return title;
        }

        public int getLenght()
        {
            return length;
        }
    }

}
