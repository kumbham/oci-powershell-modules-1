/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20181201
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.FunctionsService.Requests;
using Oci.FunctionsService.Responses;
using Oci.FunctionsService.Models;

namespace Oci.FunctionsService.Cmdlets
{
    [Cmdlet("New", "OCIFunctionsFunction")]
    [OutputType(new System.Type[] { typeof(Oci.FunctionsService.Models.Function), typeof(Oci.FunctionsService.Responses.CreateFunctionResponse) })]
    public class NewOCIFunctionsFunction : OCIFunctionsManagementCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Specification of the function to create")]
        public CreateFunctionDetails CreateFunctionDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            CreateFunctionRequest request;

            try
            {
                request = new CreateFunctionRequest
                {
                    CreateFunctionDetails = CreateFunctionDetails,
                    OpcRequestId = OpcRequestId
                };

                response = client.CreateFunction(request).GetAwaiter().GetResult();
                WriteOutput(response, response.Function);
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

        private CreateFunctionResponse response;
    }
}
