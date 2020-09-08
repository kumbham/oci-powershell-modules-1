/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20200531
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.LoggingService.Requests;
using Oci.LoggingService.Responses;
using Oci.LoggingService.Models;

namespace Oci.LoggingService.Cmdlets
{
    [Cmdlet("Update", "OCILoggingLogSavedSearch")]
    [OutputType(new System.Type[] { typeof(Oci.LoggingService.Models.LogSavedSearch), typeof(Oci.LoggingService.Responses.UpdateLogSavedSearchResponse) })]
    public class UpdateOCILoggingLogSavedSearch : OCILoggingManagementCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"OCID of the logSavedSearch")]
        public string LogSavedSearchId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Updates to the saved search.")]
        public UpdateLogSavedSearchDetails UpdateLogSavedSearchDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match` parameter to the value of the etag from a previous GET or POST response for that resource. The resource will be updated or deleted only if the etag you provide matches the resource's current etag value.")]
        public string IfMatch { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            UpdateLogSavedSearchRequest request;

            try
            {
                request = new UpdateLogSavedSearchRequest
                {
                    LogSavedSearchId = LogSavedSearchId,
                    UpdateLogSavedSearchDetails = UpdateLogSavedSearchDetails,
                    IfMatch = IfMatch,
                    OpcRequestId = OpcRequestId
                };

                response = client.UpdateLogSavedSearch(request).GetAwaiter().GetResult();
                WriteOutput(response, response.LogSavedSearch);
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

        private UpdateLogSavedSearchResponse response;
    }
}
