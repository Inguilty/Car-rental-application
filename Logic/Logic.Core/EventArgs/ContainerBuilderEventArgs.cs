using Autofac;

namespace AspNetIdentity.Logic.Core.EventArgs
{
    public class ContainerBuilderEventArgs : System.EventArgs
    {
        public ContainerBuilderEventArgs(ContainerBuilder builder)
        {
            ContainerBuilder = builder;
        }
        public ContainerBuilder ContainerBuilder { get; private set; }   
        
    }
}
