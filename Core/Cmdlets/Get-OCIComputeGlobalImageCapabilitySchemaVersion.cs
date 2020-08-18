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
    [Cmdlet("Get", "OCIComputeGlobalImageCapabilitySchemaVersion")]
    [OutputType(new System.Type[] { typeof(Oci.CoreService.Models.ComputeGlobalImageCapabilitySchemaVersion), typeof(Oci.CoreService.Responses.GetComputeGlobalImageCapabilitySchemaVersionResponse) })]
    public class GetOCIComputeGlobalImageCapabilitySchemaVersion : OCIComputeCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compute global image capability schema")]
        public string ComputeGlobalImageCapabilitySchemaId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The name of the compute global image capability schema version")]
        public string ComputeGlobalImageCapabilitySchemaVersionName { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GetComputeGlobalImageCapabilitySchemaVersionRequest request;

            try
            {
                request = new GetComputeGlobalImageCapabilitySchemaVersionRequest
                {
                    ComputeGlobalImageCapabilitySchemaId = ComputeGlobalImageCapabilitySchemaId,
                    ComputeGlobalImageCapabilitySchemaVersionName = ComputeGlobalImageCapabilitySchemaVersionName
                };

                response = client.GetComputeGlobalImageCapabilitySchemaVersion(request).GetAwaiter().GetResult();
                WriteOutput(response, response.ComputeGlobalImageCapabilitySchemaVersion);
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

        private GetComputeGlobalImageCapabilitySchemaVersionResponse response;
    }
}
