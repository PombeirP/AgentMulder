using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using TestApplication.Types;

namespace TestApplication.Windsor.TestCases.BasedOn
{
    public class FromThisAssemblyPick : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                AllTypes.FromThisAssembly().Pick(),
                Classes.FromThisAssembly().Pick(),
                Castle.MicroKernel.Registration.Types.FromThisAssembly().Pick()
                );
        }
    }
}