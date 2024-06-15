using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tour
{
    internal class Region
    {

        private string name;
        private Point[] territory;
        private string backgroundImg;
        private string description;

        public Region(string name, Point[] territory, string backgroundImg, string description)
        {
            this.name = name;
            this.territory = territory;
            this.backgroundImg = backgroundImg;
            this.description = description;
        }
    }
}
