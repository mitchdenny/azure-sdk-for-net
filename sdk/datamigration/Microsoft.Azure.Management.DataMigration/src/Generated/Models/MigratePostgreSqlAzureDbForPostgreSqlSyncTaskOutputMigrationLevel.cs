// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    [Newtonsoft.Json.JsonObject("MigrationLevelOutput")]
    public partial class MigratePostgreSqlAzureDbForPostgreSqlSyncTaskOutputMigrationLevel : MigratePostgreSqlAzureDbForPostgreSqlSyncTaskOutput
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MigratePostgreSqlAzureDbForPostgreSqlSyncTaskOutputMigrationLevel
        /// class.
        /// </summary>
        public MigratePostgreSqlAzureDbForPostgreSqlSyncTaskOutputMigrationLevel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MigratePostgreSqlAzureDbForPostgreSqlSyncTaskOutputMigrationLevel
        /// class.
        /// </summary>
        /// <param name="id">Result identifier</param>
        /// <param name="startedOn">Migration start time</param>
        /// <param name="endedOn">Migration end time</param>
        /// <param name="sourceServerVersion">Source server version</param>
        /// <param name="sourceServer">Source server name</param>
        /// <param name="targetServerVersion">Target server version</param>
        /// <param name="targetServer">Target server name</param>
        /// <param name="sourceServerType">Source server type. Possible values
        /// include: 'Access', 'DB2', 'MySQL', 'Oracle', 'SQL', 'Sybase',
        /// 'PostgreSQL', 'MongoDB', 'SQLRDS', 'MySQLRDS',
        /// 'PostgreSQLRDS'</param>
        /// <param name="targetServerType">Target server type. Possible values
        /// include: 'SQLServer', 'SQLDB', 'SQLDW', 'SQLMI', 'AzureDBForMySql',
        /// 'AzureDBForPostgresSQL', 'MongoDB'</param>
        /// <param name="state">Migration status. Possible values include:
        /// 'UNDEFINED', 'VALIDATING', 'PENDING', 'COMPLETE',
        /// 'ACTION_REQUIRED', 'FAILED'</param>
        public MigratePostgreSqlAzureDbForPostgreSqlSyncTaskOutputMigrationLevel(string id = default(string), System.DateTimeOffset? startedOn = default(System.DateTimeOffset?), System.DateTimeOffset? endedOn = default(System.DateTimeOffset?), string sourceServerVersion = default(string), string sourceServer = default(string), string targetServerVersion = default(string), string targetServer = default(string), string sourceServerType = default(string), string targetServerType = default(string), string state = default(string))
            : base(id)
        {
            StartedOn = startedOn;
            EndedOn = endedOn;
            SourceServerVersion = sourceServerVersion;
            SourceServer = sourceServer;
            TargetServerVersion = targetServerVersion;
            TargetServer = targetServer;
            SourceServerType = sourceServerType;
            TargetServerType = targetServerType;
            State = state;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets migration start time
        /// </summary>
        [JsonProperty(PropertyName = "startedOn")]
        public System.DateTimeOffset? StartedOn { get; private set; }

        /// <summary>
        /// Gets migration end time
        /// </summary>
        [JsonProperty(PropertyName = "endedOn")]
        public System.DateTimeOffset? EndedOn { get; private set; }

        /// <summary>
        /// Gets source server version
        /// </summary>
        [JsonProperty(PropertyName = "sourceServerVersion")]
        public string SourceServerVersion { get; private set; }

        /// <summary>
        /// Gets source server name
        /// </summary>
        [JsonProperty(PropertyName = "sourceServer")]
        public string SourceServer { get; private set; }

        /// <summary>
        /// Gets target server version
        /// </summary>
        [JsonProperty(PropertyName = "targetServerVersion")]
        public string TargetServerVersion { get; private set; }

        /// <summary>
        /// Gets target server name
        /// </summary>
        [JsonProperty(PropertyName = "targetServer")]
        public string TargetServer { get; private set; }

        /// <summary>
        /// Gets source server type. Possible values include: 'Access', 'DB2',
        /// 'MySQL', 'Oracle', 'SQL', 'Sybase', 'PostgreSQL', 'MongoDB',
        /// 'SQLRDS', 'MySQLRDS', 'PostgreSQLRDS'
        /// </summary>
        [JsonProperty(PropertyName = "sourceServerType")]
        public string SourceServerType { get; private set; }

        /// <summary>
        /// Gets target server type. Possible values include: 'SQLServer',
        /// 'SQLDB', 'SQLDW', 'SQLMI', 'AzureDBForMySql',
        /// 'AzureDBForPostgresSQL', 'MongoDB'
        /// </summary>
        [JsonProperty(PropertyName = "targetServerType")]
        public string TargetServerType { get; private set; }

        /// <summary>
        /// Gets migration status. Possible values include: 'UNDEFINED',
        /// 'VALIDATING', 'PENDING', 'COMPLETE', 'ACTION_REQUIRED', 'FAILED'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; private set; }

    }
}
