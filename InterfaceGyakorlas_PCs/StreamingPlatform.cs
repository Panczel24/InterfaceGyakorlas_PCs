using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceGyakorlas_PCs
{

    internal class StreamingPlatform
    {
        public List<IContent> contents = new List<IContent>();

        public void AddContent(IContent content)
        {
            contents.Add(content);
        }

        public IContent Leghosszabb()
        {
            IContent leghosszabb = contents[0];

            foreach (IContent content in contents)
            {
                if (content.getLenght() > leghosszabb.getLenght())
                {
                    leghosszabb = content;
                }
            }

            return leghosszabb;
        }
    }

}
