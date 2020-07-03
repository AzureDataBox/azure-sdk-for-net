// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.DataBox.Models
{
    /// <summary> Unencrypted credentials for accessing device. </summary>
    public partial class UnencryptedCredentials
    {
        /// <summary> Initializes a new instance of UnencryptedCredentials. </summary>
        internal UnencryptedCredentials()
        {
        }

        /// <summary> Initializes a new instance of UnencryptedCredentials. </summary>
        /// <param name="jobName"> Name of the job. </param>
        /// <param name="jobSecrets"> Secrets related to this job. </param>
        internal UnencryptedCredentials(string jobName, JobSecrets jobSecrets)
        {
            JobName = jobName;
            JobSecrets = jobSecrets;
        }

        /// <summary> Name of the job. </summary>
        public string JobName { get; }
        /// <summary> Secrets related to this job. </summary>
        public JobSecrets JobSecrets { get; }
    }
}
