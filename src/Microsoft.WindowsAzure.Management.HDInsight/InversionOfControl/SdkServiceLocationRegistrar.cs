﻿namespace Microsoft.WindowsAzure.Management.HDInsight.InversionOfControl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Microsoft.WindowsAzure.Management.Framework;
    using Microsoft.WindowsAzure.Management.Framework.InversionOfControl;
    using Microsoft.WindowsAzure.Management.Framework.WebRequest;
    using Microsoft.WindowsAzure.Management.HDInsight.ClusterProvisioning;
    using Microsoft.WindowsAzure.Management.HDInsight.ClusterProvisioning.Asv;
    using Microsoft.WindowsAzure.Management.HDInsight.ClusterProvisioning.AzureManagementClient;
    using Microsoft.WindowsAzure.Management.HDInsight.ClusterProvisioning.PocoClient;
    using Microsoft.WindowsAzure.Management.HDInsight.ClusterProvisioning.RestClient;
    using Microsoft.WindowsAzure.Management.HDInsight.ConnectionContext;

    /// <summary>
    /// Registers services with the IOC for use by this assembly.
    /// </summary>
    public class SdkServiceLocationRegistrar : IServiceLocationRegistrar
    {
        /// <inheritdoc />
        public void Register(IIocServiceLocationRuntimeManager manager)
        {
            if (manager.IsNull())
            {
                throw new ArgumentNullException("manager");
            }

            manager.RegisterType<IHDInsightManagementRestClientFactory, HDInsightManagementRestClientFactory>();
            manager.RegisterType<IHDInsightManagementPocoClientFactory, HDInsightManagementPocoClientFactory>();
            manager.RegisterType<IClusterProvisioningClientFactory, ClusterProvisioningClientFactory>();
            manager.RegisterType<IAsvValidatorClientFactory, AsvValidatorValidatorClientFactory>();
            manager.RegisterType<IConnectionCredentialsFactory, ProductionConnectionCredentialsFactory>();
            manager.RegisterType<ISubscriptionRegistrationClientFactory, SubscriptionRegistrationClientFactory>();
        }
    }
}
