using System;

namespace CompAndDel.Pipes
{
    public class PipeCognitive : IPipe
    {
        IPipe next2Pipe;
        IPipe nextPipe;

        public PipeCognitive(IPipe nextPipe, IPipe next2Pipe) 
        {
            this.next2Pipe = next2Pipe;
            this.nextPipe = nextPipe;           
        }
        
        public IPicture Send(IPicture picture)
        {
            return picture;            
        }
    }
}
