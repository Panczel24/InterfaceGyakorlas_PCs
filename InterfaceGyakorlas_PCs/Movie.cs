using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceGyakorlas_PCs
{
    internal class Movie : IContent
    {
        public Video video;

        public Movie(Video video)
        {
            this.video = video;
        }

        public int getLenght()
        {
            return video.title.Length;
        }

        public string getTitle()
        {
            return video.title;
        }

    }
}
