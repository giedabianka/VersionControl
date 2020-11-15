using Gieda_Bianka_FYZINS_gyak8.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gieda_Bianka_FYZINS_gyak8.Entities
{
    class BallFactory : Abstractions.IToyFactory
    {
        public Color BallColor { get; set; }

        public Toy CreateNew()
        {
            return new Ball(BallColor);
        }
    }
}
