# Change Log
All notable changes to this project will be documented in this file.

The format is based on Keep a [Changelog](https://keepachangelog.com/en/1.0.0/).

## 13.5.0 - 2021-05-18
### Added
- Support for spark-submit compatible options in the Data Flow service.
- Support for Object Storage as a configuration source in the Resource Manager service.

## 13.4.0 - 2021-05-11
### Added
- Support for creating notebook sessions with larger block volumes in the Data Science service.
- Support for database maintenance run patch modes in the Database service.

## 13.3.0 - 2021-05-04
### Added
- Support for the Operator Access Control service.
- Support for the Service Catalog service.
- Support for the AI Language service.
- Support for autonomous database on Exadata Cloud at Customer infrastructure patching in the Database service.

## 13.2.0 - 2021-04-27
### Added
- VCN id parameters were moved from being required to being optional on all list operations in the Networking service.
- Support for RACs (real application clusters) for external container, non-container, and pluggable databases in the Database service.
- Support for data masking in the Cloud Guard service.
- Support for opting out of DNS records during instance launch, as well as attaching secondary VNICs, in the Compute service.
- Support for mutable sizes on cluster networks in the Autoscaling service.
- Support for auto-tiering on buckets in the Object Storage service.

## 13.1.0 - 2021-04-20
### Added
- Support for opting in/out of live migration on instances in the Compute service.
- Support for enabling/disabling Operations Insights on external non-container and external pluggable databases in the Database service.
- Support for a GraphStudio URL as a connection URL on databases in the Database service.
- Support for adding customer contacts on autonomous databases in the Database service.
- Support for name annotations on harvested objects in the Data Catalog service.







## 13.0.0 - 2021-04-13
### Added
- Support for the Database Migration service.
- Support for the Networking Topology service.
- Support for getting the id of peered VCNs on local peering gateways in the Networking service.
- Support for burstable instances in the Compute service.
- Support for preemptible instances in the Compute service.
- Support for fractional resource usage and availability in the Limits service.
- Support for streaming analytics in the Service Connector Hub service.
- Support for flexible routing inside DRGs to enable packet flow between any two attachments in the Networking service.
- Support for routing policy to customize dynamic import/export of routes in the Networking service.
- Support for IPv6, including on FastConnect and IPsec resources, in the Networking service.
- Support for request validation policies in the API Gateway service.
- Support for RESP-compliant (e.g. REDIS) response caches, and for configuring response caching per-route in the API Gateway service.
- Support for flexible billing in the VMWare Solution service.
- Support for new DNS format for the Web Application Acceleration and Security service.
- Support for configuring APM tracing on applications and functions in the Functions service.
- Support for Enterprise Manager external databases and Management Agent Service managed external databases and hosts in the Operations Insights service.
- Support for getting cluster cache metrics for RAC CDB managed databases in the Database Management service.
 
### Breaking Changes
- Required property `PeerId` was added to the `Oci.CoreService.Models.LocalPeeringGateway` model in the Core service.
- The `IsInternetAccessAllowed` property was removed from the `Oci.CoreService.Models.CreateIpv6Details` model in the Core service.
- The `Ipv6CidrBlock` property was removed from the `Oci.CoreService.Models.CreateVcnDetails` model in the Core service.
- The `Ipv6PublicCidrBlock` property was removed from the `Oci.CoreService.Models.Subnet` model in the Core service.
- The `Ipv6PublicCidrBlock` property was replaced by `Ipv6CidrBlocks` in the `Oci.CoreService.Models.Vcn` model in the Core service.
- The properties `PublicIpAddress` and `IsInternetAccessAllowed` were removed from the `Oci.CoreService.Models.Ipv6` model in the Core service.
- `VcnId` was made optional in the `Oci.CoreService.Models.CreateDrgAttachmentDetails` model in the Core service.
- Required property `CurrentSku` was added to the `Oci.OcvpService.Models.CreateEsxiHostDetails` model in the Ocvp service.
- Required property `InitialSku` was added to the `Oci.OcvpService.Models.CreateSddcDetails` model in the Ocvp service.
- Required properties `BillingContractEndDate`, `NextSku` & `CurrentSku` were added to the `Oci.OcvpService.Models.EsxiHost` model in the Ocvp service.
- Required properties `BillingContractEndDate`, `NextSku` & `CurrentSku` were added to the `Oci.OcvpService.Models.EsxiHostSummary` model in the Ocvp service.
- Required property `InitialSku` was added to the `Oci.OcvpService.Models.Sddc` model in the Ocvp service.
- Required property `Id` was added to the `Oci.OpsiService.Models.DatabaseDetails` model in the Opsi service.
- The `CompartmentId` property was made optional in the `Oci.OpsiService.Requests.ListDatabaseInsightsRequest` request in the Opsi service.
- The properties `CompartmentId` and `DatabaseId` were made optional in the `Oci.OpsiService.Requests.IngestSqlTextRequest` request in the Opsi service.
- The properties `CompartmentId` and `DatabaseId` were made optional in the `Oci.OpsiService.Requests.IngestSqlPlanLinesRequest` request in the Opsi service.

## 12.1.0 - 2021-04-06
### Added
- Support for scheduling the suspension and resumption of compute instance pools based on predefined schedules in the Autoscaling service.
- Support for database software images for Cloud@Customer in the Database service.
- Support for OCIC IDCS authorization details in the Application Migration service.
- Support for cross-region asynchronous volume replication in the Block Storage service.
- Support for SDK generation in the API Gateway service.
- Support for container image signing in the Registry service.
- Support for cluster features as a part of the Container Engine for Kubernetes service.
- Support for filtering dedicated virtual machine hosts by remaining memory and OCPUs in the Compute service.
- Support for read/write-any object from buckets using pre-authenticated requests in the Object Storage service.
- Support for restricting pre-authenticated requests by prefix in the Object Storage service.
- Support for route filtering on public virtual circuits in the Virtual Networking service.

## 12.0.0 - 2021-03-30
### Added
- Support for the Vulnerability Scanning service.
- Support for vSphere 7.0 in the VMware Solution service.
- Support for forecasting in the Usage service.
- Support for viewing, searching, and modifying parameters for on-premise Oracle databases in the Database Management service.
- Support for listing tablespaces of managed databases in the Database Management service.
- Support for cross-regional replication of keys in the Key Management service.
- Support for highly-available database systems in the MySQL Database service.
- Support for Oracle Enterprise Manager bridges, source auto-association, source event type mappings, and plugins to upload data in the Logging Analytics service.
 
### Breaking Changes
- EnumMember `SUCCESFUL` was renamed to `SUCCESSFUL` in `Oci.LoganalyticsService.Requests.ListLookupsRequest.StatusEnum` in the Loganalytics service.
- Property `ForcastType` was renamed to `ForecastType` in the `Oci.UsageapiService.Models.Forecast` model in the Usageapi service.
- Property `TimeForecastStarted` is now optional in the `Oci.UsageapiService.Models.Forecast` model in the Usageapi service.

## 11.0.0 - 2021-03-23
### Added
- Support for the Network Load Balancing service.
- Support for maintenance runs on autonomous databases in the Database service.
- Support for announcement preferences in the Announcements service.
- Support for domain claiming in the Organizations service.
- Support for saved reports in the Usage service.
- Support for the HeatWave in-memory analytics accelerator in the MySQL Database service.
- Support for community applications in the Marketplace service.
- Support for capacity reservations in the Compute service.
 
### Breaking Changes
- `VnicId` is now a required property for `Oci.CoreService.Models.Ipv6` in the `Core` service.
- `VnicId` is now a required property for `Oci.CoreService.Models.CreateIpv6Details` in the `Core` service.
- `CompartmentId` was removed as a property from `Oci.TenantmanagercontrolplaneService.Requests.ListWorkRequestLogsRequest` in the `Tenantmanagercontrolplane` service.

## 10.2.0 - 2021-03-16
### Added
- Support for routing policies and HTTP2 listener protocols in the Load Balancing service.
- Support for model deployments in the Data Science service.
- Support for private clusters in the Container Engine for Kubernetes service.
- Support for updating an instance's usage type in the Content and Experience service.

## 10.1.0 - 2021-03-09
### Added
- Support for the Application Performance Monitoring service.
- Support for the Golden Gate service.
- Support for SMS subscriptions in the Notifications service.
- Support for friendly-formatted messages in the Service Connector Hub service.
- Support for attaching and detaching instances to instance pools in the Autoscaling service.

## 10.0.0 - 2021-03-02
### Added
- Support for pipelines, pipeline tasks, and favorites in the Data Integration service.
- Support for publishing tasks to OCI Data Flow in the Data Integration service.
- Support for clones in the File Storage service.
- Support for bundled modules.
 
### Breaking changes
- Changed `Oci.DataintegrationService.Models.UniqueKey` model in the Dataintegration service to not inherit from `Key`.
- Changed `Oci.DataintegrationService.Models.PrimaryKey` model in the Dataintegration service to inherit from `UniqueKey`.
- Removed `PRIMARY_KEY` and `UNIQUE_KEY` values from `KeyModelTypeEnum` in `Oci.DataintegrationService.Models.Key` model in the Dataintegration service.

## 9.2.0 - 2021-02-23
### Added
- Support for the OCI Registry service.
- Support for exporting an existing running VM, or a copy of VM, into a VMDK, QCOW2, VDI, VHD, or OCI formatted image in the Compute service.
- Support for platform configurations on instances in the Compute service.
- Support for providing target tags and target compartments on profiles in the Optimizer service.
- Support for the 'Fix it' feature in the Optimizer service.

## 9.1.0 - 2021-02-16
### Added
- Support for scan DNS names and zone ids on database system, cloud VM cluster, and autonomous Exadata infrastructure responses in the Database service.
- Support for specifying ACL rules to limit ingress into public load balancers in the Integration service.
- Support for Cloud at Customer as a source type in the Application Migration service.
- Support for selective migration of specific resources in the Application Migration service.

## 9.0.0 - 2021-02-09
### Added
- Support for the Database Management service.
- Support for setting an offset for budget processing in the Budgets service.
- Support for enabling and disabling Oracle Cloud Agent plugins in the Compute service.
- Support for listing available plugins and for getting the status of plugins in the Oracle Cloud Agent service.
- Support for one-off patching in autonomous transaction processing - dedicated databases in the Database service.
- Support for additional database upgrade options in the Database service.
- Support for glossary term recommendations in the Data Catalog service.
- Support for listing errata in the OS Management service.
 
### Breaking changes
- `InstallationRequirements` was replaced by `InstallationRequirementsEnum` in the WindowsUpdate object returned in `Get-OCIOsmanagementWindowsUpdate` cmdlet of the Osmanagement service.

## 8.0.0 - 2021-02-02
### Added
- Support for checking if a contact for Exadata infrastructure is valid in My Oracle Support in the Database service.
- Support for checking if Exadata infrastructure is in a degraded state in the Database service.
- Support for updating the operating system on a VM cluster in the Database service.
- Support for external databases in the Database service.
- Support for uploading objects to the infrequent access storage tier in the Object Storage service.
- Support for changing the storage tier of existing objects in the Object Storage service.
- Support for private templates in the Resource Manager service.
- Support for multiple encryption domains on IPSec tunnels in the Networking service.

### Breaking Changes
- `ListAppCatalogListingResourceVersionsResponse` in `Get-OCIComputeAppCatalogListingResourceVersionsList` no longer supports the `etag` parameter.
- Property `vnicId` in model `Oci.CoreService.Models.Ipv6` was removed as a parameter from the Core service.
- `ArchivalStateEnum` enum was replaced by `ArchivalState` in response `GetObjectResponse` in cmdlet `Get-OCIObjectStorageObject` in the Object Storage Service.

## 7.0.0 - 2021-01-26
### Added
- Support for creating, managing, and using asymmetric keys in the Key Management service.
- Support for peer ACD unique names in Exadata Cloud at Customer in the Database service.
- Support for ACLs on autonomous databases in Exadata Cloud at Customer Data Guard in the Database service.
- Support for drift detection on individual resources of a stack in the Resource Manager service.
- Support for private access channels and vanity URLs in the Analytics Cloud service.
- Support for updating load balancer shapes in the Blockchain Platform service.
- Support for assigning volume backup policies to volume groups in the Block Volume service.

### Breaking Changes
- CreateBlockchainPlatformDetails now has IdcsAccessToken as required property in the BlockChain service.

## 6.0.0 - 2021-01-19
### Added
- Support for Logging Analytics as a target in the Service Connector Hub service
- Support for lookups, agent collection warnings, task commands, and data archive/recall in the Logging Analytics service

### Fixed
- Fixed a bug in the endpoint used for the Management Dashboard service

### Breaking Changes
- Parameter `SortBy` in cmdlets `Get-OCILoganalyticsMetaSourceTypesList`, `Get-OCILoganalyticsParserFunctionsList`, `Get-OCILoganalyticsParserMetaPluginsList`, `Get-OCILoganalyticsSourceLabelOperatorsList`, `Get-OCILoganalyticsSourceMetaFunctionsList` has changed its datatype from `String` to `Oci.LoganalyticsService.Requests.ListSourceMetaFunctionsRequest.SortByEnum` in the Logging Analytics service
- Parameter `WaitForLifecycleState` in cmdlet `Get-OCILoganalyticsObjectCollectionRule` has changed its datatype from `LogAnalyticsObjectCollectionRule.LifecycleStateEnum` to `ObjectCollectionRuleLifecycleStates` in the Logging Analytics Service

## 5.0.0 - 2021-01-12
### Added
- Support for auto-scaling in the Big Data service
- Documentation fixes for the Logging Search service

### Breaking Changes
- Removed `STARTING` and `STOPPING` values from enum `Oci.BdsService.Models.Node.LifecycleStateEnum` in the Bds service
- Removed `UPDATING_INFRA` value from enum `Oci.BdsService.Models.BdsInstance.LifecycleStateEnum` in Get-OCIBdsInstancesList Cmdlet of Oci.PSModules.Bds

## 4.0.0 - 2020-12-15
### Added
- Support for filtering listKeys based on KeyShape in KeyManagement service
- Support for the Oracle Roving Edge Infrastructure service
- Support for flexible ShapeDetails in Load Balancer service
- Support for listing of harvested Rules, additional filtering for Logical Entity list calls in Data Catalog service
- Support second level domain for audit SDK
- Support for listing flex components in Database service
- Support for APEX service for ADBS on OCI console for Database service
- Support for Customer-Managed Key features as a part of the Database service
- Support for Github configuration source provider as part of the Resource Manager service
  
### Breaking Changes
- Removing deprecated Get-OCIDatabaseAutonomousDataWarehouse cmdlet from OCI.PSModules.Database module
- Removing deprecated New-OCIDatabaseAutonomousDataWarehouse cmdlet from OCI.PSModules.Database module
- Removing deprecated Remove-OCIDatabaseAutonomousDataWarehouse cmdlet from OCI.PSModules.Database module
- Removing deprecated New-OCIDatabaseAutonomousDataWarehouseWallet cmdlet from OCI.PSModules.Database module
- Removing deprecated New-OCIDatabaseAutonomousDataWarehouseBackup cmdlet from OCI.PSModules.Database module
- Removing deprecated Get-OCIDatabaseAutonomousDataWarehouseBackup cmdlet from OCI.PSModules.Database module
- Removing deprecated Get-OCIDatabaseAutonomousDataWarehouseBackupsList cmdlet from OCI.PSModules.Database module
- Removing deprecated Get-OCIDatabaseAutonomousDataWarehousesList cmdlet from OCI.PSModules.Database module
- Removing deprecated Restore-OCIDatabaseAutonomousDataWarehouse cmdlet from OCI.PSModules.Database module
- Removing deprecated Start-OCIDatabaseAutonomousDataWarehouse cmdlet from OCI.PSModules.Database module
- Removing deprecated Stop-OCIDatabaseAutonomousDataWarehouse API from OCI.PSModules.Database module

## 3.1.0 - 2020-12-08
### Added

- Support for Integration Service custom endpoint feature
- Support for metadata field in IdentityProvider Get and List response
- Support for fine-grained data analysis and improved SQL insights
- Support for ADB Dedicated - ORDS and SSL cert rotation at AEI
- Support for Maintenance Schedule feature for Exadata Infrastructure resources for ExaCC

## 3.0.0 - 2020-12-01
### Added
- Support for calling Oracle Cloud Infrastructure services in the sa-santiago-1 region
- Support for peer and OSN resources, as well as retry tokens, in the Blockchain Platform service
- Support for getting the availability status of management agents in the Management Agent service
- Support for the on-prem-connector resource type in the Data Safe service
- Support for service channels in the MySQL Database service
- Support for getting the creation type of backups, and for filtering backups by creation type in the MySQL Database service
  
### Breaking Changes
- DefinedTags and FreeformTags properties are removed from EnableDataSafeConfigurationDetails model in the Datasafe service
- CompartmentId parameter is changed from optional to required in ListDataSafePrivateEndpointsRequest in the Datasafe service
- IsEnabled property is changed from optional to required in EnableDataSafeConfigurationDetails model in the Datasafe service

## 2.0.0 - 2020-11-17
### Added

- Support for specifying memory for AMD E3 shapes during node pool creation and update in the Container Engine for Kubernetes service
- Support for upgrading a database on a VM database system in the Database service
- Support for listing autonomous database clones in the Database service
- Support for Data Guard with autonomous container databases on Exadata Cloud at Customer in the Database service
- Support for getting the last login time of a user in the Identity service
- Support to bulk editing tags on resources in the Identity service
- Property Id in CreateManagementSavedSearchDetails model is changed from required to optional in the Management Dashboard service
- Support for registering new regions and realms not supported by current version of OCI PowerShell Modules

### Breaking Changes

- The base type of parameter `Status` in `Get-OCIContainerengineWorkRequestsList` is changed from `Oci.ContainerengineService.Models.WorkRequestStatus` enum to `String` in the Container Engine for Kubernetes service
- The property `ErrorDetails` is removed from `Oci.LoganalyticsService.Responses.DeleteAssociationsResponse` in the `Remove-OCILoganalyticsAssociations` Cmdlet of Log Analytics module
- The enum `name` removed value `CuslterSplit` and added `ClusterSplit` in the Log Analytics service
- The type of property `Id` in `LogAnalyticsParserFilter` model is changed from `Object` to `String` in the Log Analytics service

## 1.12.0 - 2020-11-10
### Added
- Support for the 21C autonomous database version in the Database service
- Support for creating a Data Guard association with a standby database from a database software image in the Database service
- Support for specifying a TDE wallet password when creating a database or database system in the Database service
- Support for enabling access control lists for autonomous databases on Exadata Cloud At Customer in the Database service
- Support for private DNS resolvers, resolver endpoints, and views in the DNS service
- Support for getting a VCN and resolver association in the Networking service
- Support for additional parameters when updating subnets and VLANs in the Networking service
- Support for analytics clusters (database accelerators) in the MySQL Database service
- Support for migrations to Java Cloud Service and Oracle Weblogic Server instances that use existing databases in the Application Migration service
- Support for specifying reserved IPs when creating load balancers in the Load Balancing service

## 1.11.0 - 2020-11-03
### Added

- Support for calling Oracle Cloud Infrastructure services in the uk-cardiff-1 region
- Support for the Organizations service
- Support for the Optimizer service
- Support for tenancy ID and name on responses in the Usage service
- Support for object versioning in object lifecycle management in the Object Storage service
- Support for specifying a syslog URL for applications in the Functions service
- Support for creation of always-free NoSQL database tables in the NoSQL Database service

## 1.10.0 - 2020-10-27
### Added
- Support for the Compute Instance Agent service
- Support for key store resources and operations in the Database service
- Support for specifying a key store when creating autonomous container databases in the Database service

## 1.9.0 - 2020-10-20
### Added

- Support for the Operations Insights service
- Support for updating autonomous databases to enable/disable Operations Insights service integration, in the Database service
- Support for the NEEDS_ATTENTION lifecycle state on database systems in the Database service
- Support for HCX in the VMware Solutions service

## 1.8.0 - 2020-10-13
### Added

- Support for API definitions in the API Gateway service
- Support for pattern-based logical entities, namespace-bound custom properties, and faceted search in the Data Catalog service
- Support for autonomous Data Guard on autonomous infrastructure in the Database service
- Support for creating a Data Guard association on an existing standby database home in the Database service
- Support for upgrading cloud VM cluster grid infrastructure in the Database service

## 1.7.0 - 2020-10-06
### Added
    
- Support for calling Oracle Cloud Infrastructure services in the me-dubai-1 region
- Support for rotating keys on autonomous container databases and autonomous databases in the Database service
- Support for cloud Exadata infrastructure and cloud VM clusters in the Database service
- Support for controlling the display of tax banners in the Marketplace service
- Support for application references, patch changes, generic JDBC and MySQL data asset types, and publishing tasks to OCI Dataflow in the Data Integration service
- Support for disabling the legacy Instance Metadata endpoints v1 in the Compute service
- Support for instance configurations specifying instance options in the Compute Management service
- Support for Instance Principal Authentication

## 1.6.0 - 2020-09-29
### Added

- Support for specifying custom content dispositions when downloading objects in the Object Storage service
- Support for the “bring your own IP address” feature in the Virtual Networking service
- Support for updating the tags of instance console connections in the Compute service
- Support for custom SSL certificates on gateways in the API Gateway service

## 1.5.0 - 2020-09-22
### Added

- Support for software keys in the Key Management service
- Support for customer contacts on Exadata Cloud at Customer in the Database service
- Support for updating open modes and permission levels of autonomous databases in the Database service
- Support for flexible memory on VM instances in the Compute and Compute Management services

## 1.4.0 - 2020-09-15
### Added

- Support for the Cloud Guard service
- Support for specifying desired consumption models when creating instances in the Integration service
- Support for dynamic shapes in the Load Balancing service

## 1.3.0 - 2020-09-08
### Added
 
- Support for Logging Service
- Support for Logging Analytics Service
- Support for Logging Search Service
- Support for Logging Ingestion Service
- Support for Management Agent Cloud Service
- Support for Management Dashboard Service
- Support for Service Connector Hub service
- Support for Policy based Request/Response transformation in the API Gateway Service
- Support for sending diagnostic interrupt to a VM instance in the Compute Service
- Support for custom Database Software Images in the Database Service
- Support for getting and listing container database patches for Autonomous Container Database resources in the Database Service
- Support for updating patch id on maintenance run for Autonomous Container Database resources in the Database Service
- Support for searching Oracle Cloud resources across tenancies in the Search Service
- Documentation update for Logging Policies in the API Gateway service

## 1.2.0 - 2020-09-01
### Added

- Support for calling Oracle Cloud Infrastructure services in the ap-chiyoda-1 region
- Support for VM database cloning in the Database service
- Support for the MAINTENANCE_IN_PROGRESS lifecycle state on database systems, VM clusters, and Cloud Exadata in the Database service
- Support for provisioning refreshable clones in the Database service
- Support for new options on listeners and backend sets for specifying SSL protocols, SSL cipher suites, and server ordering preferences in the Load Balancing service
- Support for AMD flexible shapes with configurable CPU in the Container Engine for Kubernetes service
- Support for network sources in authentication policies in the Identity service

## 1.1.0 - 2020-08-18
### Added

- Support for the Dataintegration service

## 1.0.0 - 2020-08-18
### Added

- Initial Release
- Config-Based Authentication
- Supports Waiters
- Supports Paginators
- Supports History Store
- Supports Non-Regional clients via `-EndPoint` parameter
- Support for Debug and Verbose level logging using `-Debug` and `-Verbose` parameters
