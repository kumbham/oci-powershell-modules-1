/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20160918
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.CoreService.Requests;
using Oci.CoreService.Responses;
using Oci.CoreService.Models;

namespace Oci.CoreService.Cmdlets
{
    [Cmdlet("Update", "OCIBlockstorageVolumeKmsKey")]
    [OutputType(new System.Type[] { typeof(Oci.CoreService.Models.VolumeKmsKey), typeof(Oci.CoreService.Responses.UpdateVolumeKmsKeyResponse) })]
    public class UpdateOCIBlockstorageVolumeKmsKey : OCIBlockstorageCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the volume.")]
        public string VolumeId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Updates the Key Management master encryption key assigned to the specified volume.")]
        public UpdateVolumeKmsKeyDetails UpdateVolumeKmsKeyDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match` parameter to the value of the etag from a previous GET or POST response for that resource.  The resource will be updated or deleted only if the etag you provide matches the resource's current etag value.")]
        public string IfMatch { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            UpdateVolumeKmsKeyRequest request;

            try
            {
                request = new UpdateVolumeKmsKeyRequest
                {
                    VolumeId = VolumeId,
                    UpdateVolumeKmsKeyDetails = UpdateVolumeKmsKeyDetails,
                    IfMatch = IfMatch
                };

                response = client.UpdateVolumeKmsKey(request).GetAwaiter().GetResult();
                WriteOutput(response, response.VolumeKmsKey);
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

        private UpdateVolumeKmsKeyResponse response;
    }
}
