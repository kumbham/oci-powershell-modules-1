/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20181116
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.WaasService.Requests;
using Oci.WaasService.Responses;
using Oci.WaasService.Models;

namespace Oci.WaasService.Cmdlets
{
    [Cmdlet("Invoke", "OCIWaasPurgeCache")]
    [OutputType(new System.Type[] { typeof(Oci.PSModules.Common.Cmdlets.WorkRequest), typeof(Oci.WaasService.Responses.PurgeCacheResponse) })]
    public class InvokeOCIWaasPurgeCache : OCIWaasCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the WAAS policy.")]
        public string WaasPolicyId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the `PUT` or `DELETE` call for a resource, set the `if-match` parameter to the value of the etag from a previous `GET` or `POST` response for that resource. The resource will be updated or deleted only if the etag provided matches the resource's current etag value.")]
        public string IfMatch { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true)]
        public PurgeCache PurgeCache { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            PurgeCacheRequest request;

            try
            {
                request = new PurgeCacheRequest
                {
                    WaasPolicyId = WaasPolicyId,
                    OpcRequestId = OpcRequestId,
                    IfMatch = IfMatch,
                    PurgeCache = PurgeCache
                };

                response = client.PurgeCache(request).GetAwaiter().GetResult();
                WriteOutput(response, CreateWorkRequestObject(response.OpcWorkRequestId));
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

        private PurgeCacheResponse response;
    }
}
