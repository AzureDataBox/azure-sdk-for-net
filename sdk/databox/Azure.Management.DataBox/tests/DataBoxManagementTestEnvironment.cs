// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.TestFramework;

namespace Azure.Management.DataBox.Tests
{
    public class DataBoxManagementTestEnvironment : TestEnvironment
    {
        public DataBoxManagementTestEnvironment() : base("microsft.databoxmgmt")
        {
        }
    }
}
