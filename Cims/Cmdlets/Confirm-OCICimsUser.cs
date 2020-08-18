/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20181231
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.CimsService.Requests;
using Oci.CimsService.Responses;
using Oci.CimsService.Models;

namespace Oci.CimsService.Cmdlets
{
    [Cmdlet("Confirm", "OCICimsUser")]
    [OutputType(new System.Type[] { typeof(Oci.CimsService.Models.ValidationResponse), typeof(Oci.CimsService.Responses.ValidateUserResponse) })]
    public class ConfirmOCICimsUser : OCIIncidentCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The Customer Support Identifier number for the support account.")]
        public string Csi { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"User OCID for Oracle Identity Cloud Service (IDCS) users who also have a federated Oracle Cloud Infrastructure account.")]
        public string Ocid { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The kind of support request.")]
        public string ProblemType { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The region of the tenancy.")]
        public string Homeregion { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ValidateUserRequest request;

            try
            {
                request = new ValidateUserRequest
                {
                    Csi = Csi,
                    Ocid = Ocid,
                    OpcRequestId = OpcRequestId,
                    ProblemType = ProblemType,
                    Homeregion = Homeregion
                };

                response = client.ValidateUser(request).GetAwaiter().GetResult();
                WriteOutput(response, response.ValidationResponse);
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

        private ValidateUserResponse response;
    }
}
