/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20200601
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.LoganalyticsService.Requests;
using Oci.LoganalyticsService.Responses;
using Oci.LoganalyticsService.Models;

namespace Oci.LoganalyticsService.Cmdlets
{
    [Cmdlet("Update", "OCILoganalyticsScheduledTask")]
    [OutputType(new System.Type[] { typeof(Oci.LoganalyticsService.Models.ScheduledTask), typeof(Oci.LoganalyticsService.Responses.UpdateScheduledTaskResponse) })]
    public class UpdateOCILoganalyticsScheduledTask : OCILogAnalyticsCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The Logging Analytics namespace used for the request.")]
        public string NamespaceName { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique scheduledTask id returned from task create. If invalid will lead to a 404 not found.")]
        public string ScheduledTaskId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Update details. Schedules may be updated only for taskType SAVED_SEARCH and PURGE. This parameter also accepts subtype <Oci.LoganalyticsService.Models.UpdateStandardTaskDetails> of type <Oci.LoganalyticsService.Models.UpdateScheduledTaskDetails>.")]
        public UpdateScheduledTaskDetails UpdateScheduledTaskDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match` parameter to the value of the etag from a previous GET or POST response for that resource. The resource will be updated or deleted only if the etag you provide matches the resource's current etag value.")]
        public string IfMatch { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            UpdateScheduledTaskRequest request;

            try
            {
                request = new UpdateScheduledTaskRequest
                {
                    NamespaceName = NamespaceName,
                    ScheduledTaskId = ScheduledTaskId,
                    UpdateScheduledTaskDetails = UpdateScheduledTaskDetails,
                    OpcRequestId = OpcRequestId,
                    IfMatch = IfMatch
                };

                response = client.UpdateScheduledTask(request).GetAwaiter().GetResult();
                WriteOutput(response, response.ScheduledTask);
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

        private UpdateScheduledTaskResponse response;
    }
}
