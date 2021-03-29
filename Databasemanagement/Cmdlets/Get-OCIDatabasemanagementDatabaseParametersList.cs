/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20201101
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.DatabasemanagementService.Requests;
using Oci.DatabasemanagementService.Responses;
using Oci.DatabasemanagementService.Models;

namespace Oci.DatabasemanagementService.Cmdlets
{
    [Cmdlet("Get", "OCIDatabasemanagementDatabaseParametersList")]
    [OutputType(new System.Type[] { typeof(Oci.DatabasemanagementService.Models.DatabaseParametersCollection), typeof(Oci.DatabasemanagementService.Responses.ListDatabaseParametersResponse) })]
    public class GetOCIDatabasemanagementDatabaseParametersList : OCIDbManagementCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Managed Database.")]
        public string ManagedDatabaseId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The source used to list database parameters. `CURRENT` is used to get the database parameters that are currently in effect for the database instance. `SPFILE` is used to list parameters from the server parameter file. Default is `CURRENT`.")]
        public System.Nullable<Oci.DatabasemanagementService.Requests.ListDatabaseParametersRequest.SourceEnum> Source { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return all parameters that have the text given in their names.")]
        public string Name { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"When true, results include a list of valid values for parameters (if applicable).")]
        public System.Nullable<bool> IsAllowedValuesIncluded { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field to sort information by. Only one sortOrder can be used. The default sort order for `NAME` is ascending and it is case-sensitive.")]
        public System.Nullable<Oci.DatabasemanagementService.Requests.ListDatabaseParametersRequest.SortByEnum> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The option to sort information in ascending ('ASC') or descending ('DESC') order.")]
        public System.Nullable<Oci.DatabasemanagementService.Models.SortOrders> SortOrder { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListDatabaseParametersRequest request;

            try
            {
                request = new ListDatabaseParametersRequest
                {
                    ManagedDatabaseId = ManagedDatabaseId,
                    OpcRequestId = OpcRequestId,
                    Source = Source,
                    Name = Name,
                    IsAllowedValuesIncluded = IsAllowedValuesIncluded,
                    SortBy = SortBy,
                    SortOrder = SortOrder
                };

                response = client.ListDatabaseParameters(request).GetAwaiter().GetResult();
                WriteOutput(response, response.DatabaseParametersCollection);
                FinishProcessing(response);
            }
            catch (Exception ex)
            {
                TerminatingErrorDuringExecution(ex);
            }
        }

        protected override void StopProcessing()
        {
            base.StopProcessing();
            TerminatingErrorDuringExecution(new OperationCanceledException("Cmdlet execution interrupted"));
        }

        private ListDatabaseParametersResponse response;
    }
}
