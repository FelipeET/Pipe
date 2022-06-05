using System;
using CognitiveCoreUCU;
using System.Drawing;

namespace CompAndDel.Filters
{
    public class FilterCognitive: IFilter
    {
        // Esta clase sirve para aplicar el filto que reconoce caras.
        public IPicture Filter(IPicture image)
        {
            CognitiveFace cog = new CognitiveFace(true, Color.GreenYellow);

            return image;
        }
    }
}
