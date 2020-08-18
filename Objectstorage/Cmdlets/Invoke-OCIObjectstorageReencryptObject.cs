/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20160918
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.ObjectstorageService.Requests;
using Oci.ObjectstorageService.Responses;
using Oci.ObjectstorageService.Models;

namespace Oci.ObjectstorageService.Cmdlets
{
    [Cmdlet("Invoke", "OCIObjectstorageReencryptObject")]
    [OutputType(new System.Type[] { typeof(void), typeof(Oci.ObjectstorageService.Responses.ReencryptObjectResponse) })]
    public class InvokeOCIObjectstorageReencryptObject : OCIObjectStorageCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The Object Storage namespace used for the request.")]
        public string NamespaceName { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The name of the bucket. Avoid entering confidential information. Example: `my-new-bucket1`")]
        public string BucketName { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The name of the object. Avoid entering confidential information. Example: `test/object1.log`")]
        public string ObjectName { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Request object for re-encrypting the data encryption key associated with an object.")]
        public ReencryptObjectDetails ReencryptObjectDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"VersionId used to identify a particular version of the object")]
        public string VersionId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcClientRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ReencryptObjectRequest request;

            try
            {
                request = new ReencryptObjectRequest
                {
                    NamespaceName = NamespaceName,
                    BucketName = BucketName,
                    ObjectName = ObjectName,
                    ReencryptObjectDetails = ReencryptObjectDetails,
                    VersionId = VersionId,
                    OpcClientRequestId = OpcClientRequestId
                };

                response = client.ReencryptObject(request).GetAwaiter().GetResult();
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

        private ReencryptObjectResponse response;
    }
}
