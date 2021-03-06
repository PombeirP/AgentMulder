﻿using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using SomeNamespace;

namespace TestApplication.Windsor.TestCases.BasedOn
{
    public class FromThisAssemblyInSameNamespaceAsGeneric : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                AllTypes.FromThisAssembly().InSameNamespaceAs<IInSomeNamespace>(),
                Classes.FromThisAssembly().InSameNamespaceAs<IInSomeNamespace>(),
                Castle.MicroKernel.Registration.Types.FromThisAssembly().InSameNamespaceAs<IInSomeNamespace>()
                );
        }
    }
}