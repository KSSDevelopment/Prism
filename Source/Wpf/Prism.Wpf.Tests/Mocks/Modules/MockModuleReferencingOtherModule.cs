// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using Prism.Modularity;

namespace Prism.Wpf.Tests.Mocks.Modules
{
    public class MockModuleReferencingOtherModule : IModule
    {
        public void Initialize()
        {
            throw new System.NotImplementedException();
        }
    }

    public class MyDummyClass : DummyClass {}
}
