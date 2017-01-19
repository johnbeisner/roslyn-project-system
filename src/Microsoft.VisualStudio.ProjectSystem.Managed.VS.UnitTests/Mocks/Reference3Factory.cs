﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using Moq;
using VSLangProj;

namespace VSLangProj80
{
    internal static class Reference3Factory
    {
        public static Reference3 CreateComReference()
        {
            var mock = new Mock<Reference3>();
            mock.SetupGet(r => r.Type)
                .Returns(prjReferenceType.prjReferenceTypeActiveX);

            return mock.Object;
        }

        public static Reference3 CreateAssemblyReference(string name, string version, string path = null)
        {
            var mock = new Mock<Reference3>();
            mock.SetupGet(r => r.Name)
                .Returns(name);

            mock.SetupGet(r => r.Version)
                .Returns(version);

            mock.SetupGet(r => r.Path)
                .Returns(path);

            mock.SetupGet(r => r.Resolved)
                .Returns(path != null);

            mock.SetupGet(r => r.Type)
                .Returns(prjReferenceType.prjReferenceTypeAssembly);

            return mock.Object;            
        }
    }
}