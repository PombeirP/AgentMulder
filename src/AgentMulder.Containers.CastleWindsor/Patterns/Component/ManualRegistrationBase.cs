﻿using System.Collections.Generic;
using System.ComponentModel.Composition;
using AgentMulder.ReSharper.Domain.Registrations;
using AgentMulder.ReSharper.Domain.Search;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.Services.StructuralSearch;

namespace AgentMulder.Containers.CastleWindsor.Patterns.Component
{
    public abstract class ManualRegistrationBase : RegistrationBase
    {
        private readonly string elementName;

        protected ManualRegistrationBase(IStructuralSearchPattern pattern, string elementName)
            : base(pattern)
        {
            this.elementName = elementName;
        }

        public override IEnumerable<IComponentRegistration> GetComponentRegistrations(params IStructuralMatchResult[] matchResults)
        {
            foreach (IStructuralMatchResult match in matchResults)
            {
                var matchedType = match.GetMatchedType(elementName) as IDeclaredType;
                if (matchedType != null)
                {
                    ITypeElement typeElement = matchedType.GetTypeElement(match.MatchedElement.GetPsiModule());
                    yield return new ConcreteRegistration(match.GetDocumentRange(), typeElement);
                }
            }
        }
    }
}