// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.BatchAI.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Information about a Job.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Job : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the Job class.
        /// </summary>
        public Job()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Job class.
        /// </summary>
        /// <param name="id">The ID of the resource.</param>
        /// <param name="name">The name of the resource.</param>
        /// <param name="type">The type of the resource.</param>
        /// <param name="schedulingPriority">Scheduling priority.</param>
        /// <param name="cluster">Cluster.</param>
        /// <param name="mountVolumes">Mount volumes.</param>
        /// <param name="nodeCount">Number of compute nodes to run the job
        /// on.</param>
        /// <param name="containerSettings">If provided the job will run in the
        /// specified container.</param>
        /// <param name="toolType">The toolkit type of this job.</param>
        /// <param name="cntkSettings">Specifies the settings for CNTK (aka
        /// Microsoft Cognitive Toolkit) job.</param>
        /// <param name="pyTorchSettings">Specifies the settings for pyTorch
        /// job.</param>
        /// <param name="tensorFlowSettings">Specifies the settings for Tensor
        /// Flow job.</param>
        /// <param name="caffeSettings">Specifies the settings for Caffe
        /// job.</param>
        /// <param name="caffe2Settings">Specifies the settings for Caffe2
        /// job.</param>
        /// <param name="chainerSettings">Specifies the settings for Chainer
        /// job.</param>
        /// <param name="customToolkitSettings">Specifies the settings for
        /// custom tool kit job.</param>
        /// <param name="customMpiSettings">Specifies the settings for custom
        /// MPI job.</param>
        /// <param name="horovodSettings">Specifies the settings for Horovod
        /// job.</param>
        /// <param name="jobPreparation">Specifies the actions to be performed
        /// before tool kit is launched.</param>
        /// <param name="jobOutputDirectoryPathSegment">Output directory path
        /// segment.</param>
        /// <param name="stdOutErrPathPrefix">Standard output directory path
        /// prefix.</param>
        /// <param name="inputDirectories">Input directories.</param>
        /// <param name="outputDirectories">Output directories.</param>
        /// <param name="environmentVariables">Environment variables.</param>
        /// <param name="secrets">Secrets.</param>
        /// <param name="constraints">Constraints associated with the
        /// Job.</param>
        /// <param name="creationTime">Creation time.</param>
        /// <param name="provisioningState">Provisioning state.</param>
        /// <param name="provisioningStateTransitionTime">Provisioning state
        /// transition time.</param>
        /// <param name="executionState">Execution state.</param>
        /// <param name="executionStateTransitionTime">Execution state
        /// transition time.</param>
        /// <param name="executionInfo">Information about the execution of a
        /// job.</param>
        public Job(string id = default(string), string name = default(string), string type = default(string), string schedulingPriority = default(string), ResourceId cluster = default(ResourceId), MountVolumes mountVolumes = default(MountVolumes), int? nodeCount = default(int?), ContainerSettings containerSettings = default(ContainerSettings), string toolType = default(string), CNTKsettings cntkSettings = default(CNTKsettings), PyTorchSettings pyTorchSettings = default(PyTorchSettings), TensorFlowSettings tensorFlowSettings = default(TensorFlowSettings), CaffeSettings caffeSettings = default(CaffeSettings), Caffe2Settings caffe2Settings = default(Caffe2Settings), ChainerSettings chainerSettings = default(ChainerSettings), CustomToolkitSettings customToolkitSettings = default(CustomToolkitSettings), CustomMpiSettings customMpiSettings = default(CustomMpiSettings), HorovodSettings horovodSettings = default(HorovodSettings), JobPreparation jobPreparation = default(JobPreparation), string jobOutputDirectoryPathSegment = default(string), string stdOutErrPathPrefix = default(string), IList<InputDirectory> inputDirectories = default(IList<InputDirectory>), IList<OutputDirectory> outputDirectories = default(IList<OutputDirectory>), IList<EnvironmentVariable> environmentVariables = default(IList<EnvironmentVariable>), IList<EnvironmentVariableWithSecretValue> secrets = default(IList<EnvironmentVariableWithSecretValue>), JobPropertiesConstraints constraints = default(JobPropertiesConstraints), System.DateTime? creationTime = default(System.DateTime?), string provisioningState = default(string), System.DateTime? provisioningStateTransitionTime = default(System.DateTime?), string executionState = default(string), System.DateTime? executionStateTransitionTime = default(System.DateTime?), JobPropertiesExecutionInfo executionInfo = default(JobPropertiesExecutionInfo))
            : base(id, name, type)
        {
            SchedulingPriority = schedulingPriority;
            Cluster = cluster;
            MountVolumes = mountVolumes;
            NodeCount = nodeCount;
            ContainerSettings = containerSettings;
            ToolType = toolType;
            CntkSettings = cntkSettings;
            PyTorchSettings = pyTorchSettings;
            TensorFlowSettings = tensorFlowSettings;
            CaffeSettings = caffeSettings;
            Caffe2Settings = caffe2Settings;
            ChainerSettings = chainerSettings;
            CustomToolkitSettings = customToolkitSettings;
            CustomMpiSettings = customMpiSettings;
            HorovodSettings = horovodSettings;
            JobPreparation = jobPreparation;
            JobOutputDirectoryPathSegment = jobOutputDirectoryPathSegment;
            StdOutErrPathPrefix = stdOutErrPathPrefix;
            InputDirectories = inputDirectories;
            OutputDirectories = outputDirectories;
            EnvironmentVariables = environmentVariables;
            Secrets = secrets;
            Constraints = constraints;
            CreationTime = creationTime;
            ProvisioningState = provisioningState;
            ProvisioningStateTransitionTime = provisioningStateTransitionTime;
            ExecutionState = executionState;
            ExecutionStateTransitionTime = executionStateTransitionTime;
            ExecutionInfo = executionInfo;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets scheduling priority.
        /// </summary>
        /// <remarks>
        /// Scheduling priority associated with the job. Possible values
        /// include: 'low', 'normal', 'high'
        /// </remarks>
        [JsonProperty(PropertyName = "properties.schedulingPriority")]
        public string SchedulingPriority { get; set; }

        /// <summary>
        /// Gets or sets cluster.
        /// </summary>
        /// <remarks>
        /// Resource ID of the cluster associated with the job.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.cluster")]
        public ResourceId Cluster { get; set; }

        /// <summary>
        /// Gets or sets mount volumes.
        /// </summary>
        /// <remarks>
        /// Collection of mount volumes available to the job during execution.
        /// These volumes are mounted before the job execution and unmouted
        /// after the job completion. The volumes are mounted at location
        /// specified by $AZ_BATCHAI_JOB_MOUNT_ROOT environment variable.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.mountVolumes")]
        public MountVolumes MountVolumes { get; set; }

        /// <summary>
        /// Gets or sets number of compute nodes to run the job on.
        /// </summary>
        /// <remarks>
        /// The job will be gang scheduled on that many compute nodes
        /// </remarks>
        [JsonProperty(PropertyName = "properties.nodeCount")]
        public int? NodeCount { get; set; }

        /// <summary>
        /// Gets or sets if provided the job will run in the specified
        /// container.
        /// </summary>
        /// <remarks>
        /// If the container was downloaded as part of cluster setup then the
        /// same container image will be used. If not provided, the job will
        /// run on the VM.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.containerSettings")]
        public ContainerSettings ContainerSettings { get; set; }

        /// <summary>
        /// Gets or sets the toolkit type of this job.
        /// </summary>
        /// <remarks>
        /// Possible values are: cntk, tensorflow, caffe, caffe2, chainer,
        /// pytorch, custom, mpi, horovod. Possible values include: 'cntk',
        /// 'tensorflow', 'caffe', 'caffe2', 'chainer', 'horovod', 'mpi',
        /// 'custom'
        /// </remarks>
        [JsonProperty(PropertyName = "properties.toolType")]
        public string ToolType { get; set; }

        /// <summary>
        /// Gets or sets specifies the settings for CNTK (aka Microsoft
        /// Cognitive Toolkit) job.
        /// </summary>
        [JsonProperty(PropertyName = "properties.cntkSettings")]
        public CNTKsettings CntkSettings { get; set; }

        /// <summary>
        /// Gets or sets specifies the settings for pyTorch job.
        /// </summary>
        [JsonProperty(PropertyName = "properties.pyTorchSettings")]
        public PyTorchSettings PyTorchSettings { get; set; }

        /// <summary>
        /// Gets or sets specifies the settings for Tensor Flow job.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tensorFlowSettings")]
        public TensorFlowSettings TensorFlowSettings { get; set; }

        /// <summary>
        /// Gets or sets specifies the settings for Caffe job.
        /// </summary>
        [JsonProperty(PropertyName = "properties.caffeSettings")]
        public CaffeSettings CaffeSettings { get; set; }

        /// <summary>
        /// Gets or sets specifies the settings for Caffe2 job.
        /// </summary>
        [JsonProperty(PropertyName = "properties.caffe2Settings")]
        public Caffe2Settings Caffe2Settings { get; set; }

        /// <summary>
        /// Gets or sets specifies the settings for Chainer job.
        /// </summary>
        [JsonProperty(PropertyName = "properties.chainerSettings")]
        public ChainerSettings ChainerSettings { get; set; }

        /// <summary>
        /// Gets or sets specifies the settings for custom tool kit job.
        /// </summary>
        [JsonProperty(PropertyName = "properties.customToolkitSettings")]
        public CustomToolkitSettings CustomToolkitSettings { get; set; }

        /// <summary>
        /// Gets or sets specifies the settings for custom MPI job.
        /// </summary>
        [JsonProperty(PropertyName = "properties.customMpiSettings")]
        public CustomMpiSettings CustomMpiSettings { get; set; }

        /// <summary>
        /// Gets or sets specifies the settings for Horovod job.
        /// </summary>
        [JsonProperty(PropertyName = "properties.horovodSettings")]
        public HorovodSettings HorovodSettings { get; set; }

        /// <summary>
        /// Gets or sets specifies the actions to be performed before tool kit
        /// is launched.
        /// </summary>
        /// <remarks>
        /// The specified actions will run on all the nodes that are part of
        /// the job
        /// </remarks>
        [JsonProperty(PropertyName = "properties.jobPreparation")]
        public JobPreparation JobPreparation { get; set; }

        /// <summary>
        /// Gets output directory path segment.
        /// </summary>
        /// <remarks>
        /// A segment of job's output directories path created by Batch AI.
        /// Batch AI creates job's output directories under an unique path to
        /// avoid conflicts between jobs. This value contains a path segment
        /// generated by Batch AI to make the path unique and can be used to
        /// find the output directory on the node or mounted filesystem.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.jobOutputDirectoryPathSegment")]
        public string JobOutputDirectoryPathSegment { get; private set; }

        /// <summary>
        /// Gets or sets standard output directory path prefix.
        /// </summary>
        /// <remarks>
        /// The path where the Batch AI service stores stdout, stderror and
        /// execution log of the job.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.stdOutErrPathPrefix")]
        public string StdOutErrPathPrefix { get; set; }

        /// <summary>
        /// Gets or sets input directories.
        /// </summary>
        /// <remarks>
        /// A list of input directories for the job.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.inputDirectories")]
        public IList<InputDirectory> InputDirectories { get; set; }

        /// <summary>
        /// Gets or sets output directories.
        /// </summary>
        /// <remarks>
        /// A list of output directories for the job.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.outputDirectories")]
        public IList<OutputDirectory> OutputDirectories { get; set; }

        /// <summary>
        /// Gets or sets environment variables.
        /// </summary>
        /// <remarks>
        /// A collection of user defined environment variables to be setup for
        /// the job.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.environmentVariables")]
        public IList<EnvironmentVariable> EnvironmentVariables { get; set; }

        /// <summary>
        /// Gets or sets secrets.
        /// </summary>
        /// <remarks>
        /// A collection of user defined environment variables with secret
        /// values to be setup for the job. Server will never report values of
        /// these variables back.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.secrets")]
        public IList<EnvironmentVariableWithSecretValue> Secrets { get; set; }

        /// <summary>
        /// Gets or sets constraints associated with the Job.
        /// </summary>
        [JsonProperty(PropertyName = "properties.constraints")]
        public JobPropertiesConstraints Constraints { get; set; }

        /// <summary>
        /// Gets creation time.
        /// </summary>
        /// <remarks>
        /// The creation time of the job.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.creationTime")]
        public System.DateTime? CreationTime { get; private set; }

        /// <summary>
        /// Gets provisioning state.
        /// </summary>
        /// <remarks>
        /// The provisioned state of the Batch AI job. Possible values include:
        /// 'creating', 'succeeded', 'failed', 'deleting'
        /// </remarks>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets provisioning state transition time.
        /// </summary>
        /// <remarks>
        /// The time at which the job entered its current provisioning state.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.provisioningStateTransitionTime")]
        public System.DateTime? ProvisioningStateTransitionTime { get; private set; }

        /// <summary>
        /// Gets execution state.
        /// </summary>
        /// <remarks>
        /// The current state of the job. Possible values are: queued - The job
        /// is queued and able to run. A job enters this state when it is
        /// created, or when it is awaiting a retry after a failed run. running
        /// - The job is running on a compute cluster. This includes job-level
        /// preparation such as downloading resource files or set up container
        /// specified on the job - it does not necessarily mean that the job
        /// command line has started executing. terminating - The job is
        /// terminated by the user, the terminate operation is in progress.
        /// succeeded - The job has completed running successfully and exited
        /// with exit code 0. failed - The job has finished unsuccessfully
        /// (failed with a non-zero exit code) and has exhausted its retry
        /// limit. A job is also marked as failed if an error occurred
        /// launching the job. Possible values include: 'queued', 'running',
        /// 'terminating', 'succeeded', 'failed'
        /// </remarks>
        [JsonProperty(PropertyName = "properties.executionState")]
        public string ExecutionState { get; private set; }

        /// <summary>
        /// Gets execution state transition time.
        /// </summary>
        /// <remarks>
        /// The time at which the job entered its current execution state.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.executionStateTransitionTime")]
        public System.DateTime? ExecutionStateTransitionTime { get; private set; }

        /// <summary>
        /// Gets or sets information about the execution of a job.
        /// </summary>
        [JsonProperty(PropertyName = "properties.executionInfo")]
        public JobPropertiesExecutionInfo ExecutionInfo { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Cluster != null)
            {
                Cluster.Validate();
            }
            if (ContainerSettings != null)
            {
                ContainerSettings.Validate();
            }
            if (PyTorchSettings != null)
            {
                PyTorchSettings.Validate();
            }
            if (TensorFlowSettings != null)
            {
                TensorFlowSettings.Validate();
            }
            if (Caffe2Settings != null)
            {
                Caffe2Settings.Validate();
            }
            if (ChainerSettings != null)
            {
                ChainerSettings.Validate();
            }
            if (CustomMpiSettings != null)
            {
                CustomMpiSettings.Validate();
            }
            if (HorovodSettings != null)
            {
                HorovodSettings.Validate();
            }
            if (JobPreparation != null)
            {
                JobPreparation.Validate();
            }
            if (InputDirectories != null)
            {
                foreach (var element in InputDirectories)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (OutputDirectories != null)
            {
                foreach (var element1 in OutputDirectories)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (EnvironmentVariables != null)
            {
                foreach (var element2 in EnvironmentVariables)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
            if (Secrets != null)
            {
                foreach (var element3 in Secrets)
                {
                    if (element3 != null)
                    {
                        element3.Validate();
                    }
                }
            }
        }
    }
}
