/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 1.0.015
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.DtsService.Requests;
using Oci.DtsService.Responses;
using Oci.DtsService.Models;

namespace Oci.DtsService.Cmdlets
{
    [Cmdlet("Update", "OCIDtsTransferAppliance")]
    [OutputType(new System.Type[] { typeof(Oci.DtsService.Models.TransferAppliance), typeof(Oci.DtsService.Responses.UpdateTransferApplianceResponse) })]
    public class UpdateOCIDtsTransferAppliance : OCITransferApplianceCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"ID of the Transfer Job")]
        public string Id { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Label of the Transfer Appliance")]
        public string TransferApplianceLabel { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"fields to update")]
        public UpdateTransferApplianceDetails UpdateTransferApplianceDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The entity tag to match. Optional, if set, the update will be successful only if the object's tag matches the tag specified in the request.")]
        public string IfMatch { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            UpdateTransferApplianceRequest request;

            try
            {
                request = new UpdateTransferApplianceRequest
                {
                    Id = Id,
                    TransferApplianceLabel = TransferApplianceLabel,
                    UpdateTransferApplianceDetails = UpdateTransferApplianceDetails,
                    IfMatch = IfMatch
                };

                response = client.UpdateTransferAppliance(request).GetAwaiter().GetResult();
                WriteOutput(response, response.TransferAppliance);
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

        private UpdateTransferApplianceResponse response;
    }
}
