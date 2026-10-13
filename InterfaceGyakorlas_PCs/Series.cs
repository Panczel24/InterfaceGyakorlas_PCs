using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceGyakorlas_PCs
{
    internal class Series : IContent
    {
        public string title;
        public List<Video> videos;

        public Series(string title, List<Video> videos)
        {
            this.title = title;
            this.videos = videos;
        }

        public int getLenght()
        {
            int total = 0;

            foreach (Video video in videos)
            {
                total = total + video.length;
            }

            return total;
        }

        public string getTitle()
        {
            return title;
        }
    }
}
