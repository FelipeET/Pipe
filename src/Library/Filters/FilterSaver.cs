using System;
using System.Drawing;

namespace CompAndDel.Filters
{
    public class FilterSaver: IFilter
    {
        // Esta clase sirve para guardar la imagen cada vez que se aplica un filtro.
        public IPicture Filter(IPicture image)
        {
            PictureProvider p = new PictureProvider();
            p.SavePicture(image, @"lukefiltrado2.jpg");

            return image;
        }
    }
}
