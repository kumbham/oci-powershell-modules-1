/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20171215
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.FilestorageService.Requests;
using Oci.FilestorageService.Responses;
using Oci.FilestorageService.Models;

namespace Oci.FilestorageService.Cmdlets
{
    [Cmdlet("Update", "OCIFilestorageExportSet")]
    [OutputType(new System.Type[] { typeof(Oci.FilestorageService.Models.ExportSet), typeof(Oci.FilestorageService.Responses.UpdateExportSetResponse) })]
    public class UpdateOCIFilestorageExportSet : OCIFileStorageCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the export set.")]
        public string ExportSetId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Details object for updating an export set.")]
        public UpdateExportSetDetails UpdateExportSetDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match` parameter to the value of the etag from a previous GET or POST response for that resource. The resource will be updated or deleted only if the etag you provide matches the resource's current etag value.")]
        public string IfMatch { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            UpdateExportSetRequest request;

            try
            {
                request = new UpdateExportSetRequest
                {
                    ExportSetId = ExportSetId,
                    UpdateExportSetDetails = UpdateExportSetDetails,
                    IfMatch = IfMatch,
                    OpcRequestId = OpcRequestId
                };

                response = client.UpdateExportSet(request).GetAwaiter().GetResult();
                WriteOutput(response, response.ExportSet);
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

        private UpdateExportSetResponse response;
    }
}
