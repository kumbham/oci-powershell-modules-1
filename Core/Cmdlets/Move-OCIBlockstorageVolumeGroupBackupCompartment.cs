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
    [Cmdlet("Move", "OCIBlockstorageVolumeGroupBackupCompartment")]
    [OutputType(new System.Type[] { typeof(void), typeof(Oci.CoreService.Responses.ChangeVolumeGroupBackupCompartmentResponse) })]
    public class MoveOCIBlockstorageVolumeGroupBackupCompartment : OCIBlockstorageCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The Oracle Cloud ID (OCID) that uniquely identifies the volume group backup.")]
        public string VolumeGroupBackupId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Request to change the compartment of given volume group backup.")]
        public ChangeVolumeGroupBackupCompartmentDetails ChangeVolumeGroupBackupCompartmentDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ChangeVolumeGroupBackupCompartmentRequest request;

            try
            {
                request = new ChangeVolumeGroupBackupCompartmentRequest
                {
                    VolumeGroupBackupId = VolumeGroupBackupId,
                    ChangeVolumeGroupBackupCompartmentDetails = ChangeVolumeGroupBackupCompartmentDetails,
                    OpcRequestId = OpcRequestId
                };

                response = client.ChangeVolumeGroupBackupCompartment(request).GetAwaiter().GetResult();
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

        private ChangeVolumeGroupBackupCompartmentResponse response;
    }
}
