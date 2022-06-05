using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;

namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 1
            PictureProvider p = new PictureProvider();
            IPicture picture = p.GetPicture(@"luke.jpg");

            PipeNull pipe3= new PipeNull();
            PipeSerial pipe2= new PipeSerial(new FilterNegative(), pipe3);
            PipeSerial pipe= new PipeSerial(new FilterGreyscale(), pipe2);

            IPicture pictureModify = pipe.Send(picture);
            p.SavePicture(pictureModify, @"lukefiltrado.jpg");

            // Ejercicio 2
            PipeNull pipe3B= new PipeNull();
            PipeSerial pipeS1= new PipeSerial(new FilterSaver(), pipe3B);
            PipeSerial pipe2B= new PipeSerial(new FilterNegative(), pipeS1);
            PipeSerial pipeS2= new PipeSerial(new FilterSaver(), pipe2B);
            PipeSerial pipeB= new PipeSerial(new FilterGreyscale(), pipeS2);
            pipeB.Send(picture);

            // Ejercicio 3
            PipeNull pipe3C= new PipeNull();
            PipeSerial pipeT= new PipeSerial(new FilterTwitter(), pipe3C);
            PipeSerial pipeS1C= new PipeSerial(new FilterSaver(), pipeT);
            PipeSerial pipe2C= new PipeSerial(new FilterNegative(), pipeS1C);
            PipeSerial pipeT2= new PipeSerial(new FilterTwitter(), pipe2C);
            PipeSerial pipeS2C= new PipeSerial(new FilterSaver(), pipeT2);
            PipeSerial pipeC= new PipeSerial(new FilterGreyscale(), pipeS2C);
            pipeC.Send(picture);

            // Ejercicio 4

        }
    }
}