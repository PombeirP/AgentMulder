﻿using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using TestApplication.Types;

namespace TestApplication.Windsor.TestCases.BasedOn
{
    public class FromThisAssemblyBasedOnGeneric : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                AllTypes.FromThisAssembly().BasedOn<IFoo>(),
                Classes.FromThisAssembly().BasedOn<IFoo>(),
                Castle.MicroKernel.Registration.Types.FromThisAssembly().BasedOn<IFoo>()
                );
        }
    }
}