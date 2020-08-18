/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20190415
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.MysqlService.Requests;
using Oci.MysqlService.Responses;
using Oci.MysqlService.Models;

namespace Oci.MysqlService.Cmdlets
{
    [Cmdlet("New", "OCIMysqlBackup")]
    [OutputType(new System.Type[] { typeof(Oci.MysqlService.Models.Backup), typeof(Oci.MysqlService.Responses.CreateBackupResponse) })]
    public class NewOCIMysqlBackup : OCIDbBackupsCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Create a Backup of a DB System.")]
        public CreateBackupDetails CreateBackupDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Customer-defined unique identifier for the request. If you need to contact Oracle about a specific request, please provide the request ID that you supplied in this header with the request.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A token that uniquely identifies a request so it can be retried in case of a timeout or server error without risk of executing that same action again. Retry tokens expire after 24 hours, but can be invalidated before then due to conflicting operations (for example, if a resource has been deleted and purged from the system, then a retry of the original creation request may be rejected).")]
        public string OpcRetryToken { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            CreateBackupRequest request;

            try
            {
                request = new CreateBackupRequest
                {
                    CreateBackupDetails = CreateBackupDetails,
                    OpcRequestId = OpcRequestId,
                    OpcRetryToken = OpcRetryToken
                };

                response = client.CreateBackup(request).GetAwaiter().GetResult();
                WriteOutput(response, response.Backup);
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

        private CreateBackupResponse response;
    }
}
