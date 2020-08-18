/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20180501
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.HealthchecksService.Requests;
using Oci.HealthchecksService.Responses;
using Oci.HealthchecksService.Models;

namespace Oci.HealthchecksService.Cmdlets
{
    [Cmdlet("Move", "OCIHealthchecksHttpMonitorCompartment")]
    [OutputType(new System.Type[] { typeof(void), typeof(Oci.HealthchecksService.Responses.ChangeHttpMonitorCompartmentResponse) })]
    public class MoveOCIHealthchecksHttpMonitorCompartment : OCIHealthChecksCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of a monitor.")]
        public string MonitorId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The details needed to move the monitor.")]
        public ChangeHttpMonitorCompartmentDetails ChangeHttpMonitorCompartmentDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match` parameter to the value of the etag from a previous GET or POST response for that resource.  The resource will be updated or deleted only if the etag you provide matches the resource's current etag value.")]
        public string IfMatch { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A token that uniquely identifies a request that can be retried in case of a timeout or server error without risk of executing the same action again. Retry tokens expire after 24 hours.

*Note:* Retry tokens can be invalidated before the 24 hour time limit due to conflicting operations, such as a resource being deleted or purged from the system.")]
        public string OpcRetryToken { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ChangeHttpMonitorCompartmentRequest request;

            try
            {
                request = new ChangeHttpMonitorCompartmentRequest
                {
                    MonitorId = MonitorId,
                    ChangeHttpMonitorCompartmentDetails = ChangeHttpMonitorCompartmentDetails,
                    IfMatch = IfMatch,
                    OpcRequestId = OpcRequestId,
                    OpcRetryToken = OpcRetryToken
                };

                response = client.ChangeHttpMonitorCompartment(request).GetAwaiter().GetResult();
                WriteOutput(response);
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

        private ChangeHttpMonitorCompartmentResponse response;
    }
}
