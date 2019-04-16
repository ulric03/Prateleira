using Autofac;
using Autofac.Core;

namespace InjectDependentionGetServiceByCtor
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Corinthians>().Named<ITimes>("Corinthians");
            builder.RegisterType<SaoBento>().Named<ITimes>("SaoBento");

            IContainer container = null;
            builder.Register(c => container).AsSelf();
            builder.RegisterBuildCallback(c => container = c);

        }
    }
}