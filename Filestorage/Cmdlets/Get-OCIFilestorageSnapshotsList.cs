/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20171215
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.FilestorageService.Requests;
using Oci.FilestorageService.Responses;
using Oci.FilestorageService.Models;

namespace Oci.FilestorageService.Cmdlets
{
    [Cmdlet("Get", "OCIFilestorageSnapshotsList")]
    [OutputType(new System.Type[] { typeof(Oci.FilestorageService.Models.SnapshotSummary), typeof(Oci.FilestorageService.Responses.ListSnapshotsResponse) })]
    public class GetOCIFilestorageSnapshotsList : OCIFileStorageCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the file system.")]
        public string FileSystemId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For list pagination. The maximum number of results per page, or items to return in a paginated ""List"" call. 1 is the minimum, 100 is the maximum.

For important details about how pagination works, see [List Pagination](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#nine).

Example: `100`", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For list pagination. The value of the `opc-next-page` response header from the previous ""List"" call.

For important details about how pagination works, see [List Pagination](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#nine).")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Filter results by the specified lifecycle state. Must be a valid state for the resource type.")]
        public System.Nullable<Oci.FilestorageService.Requests.ListSnapshotsRequest.LifecycleStateEnum> LifecycleState { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Filter results by OCID. Must be an OCID of the correct type for the resouce type.")]
        public string Id { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The sort order to use, either 'asc' or 'desc', where 'asc' is ascending and 'desc' is descending. The default order is 'desc' except for numeric values.")]
        public System.Nullable<Oci.FilestorageService.Requests.ListSnapshotsRequest.SortOrderEnum> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListSnapshotsRequest request;

            try
            {
                request = new ListSnapshotsRequest
                {
                    FileSystemId = FileSystemId,
                    Limit = Limit,
                    Page = Page,
                    LifecycleState = LifecycleState,
                    Id = Id,
                    SortOrder = SortOrder,
                    OpcRequestId = OpcRequestId
                };
                IEnumerable<ListSnapshotsResponse> responses = GetRequestDelegate().Invoke(request);
                foreach (var item in responses)
                {
                    response = item;
                    WriteOutput(response, response.Items, true);
                }
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

        private RequestDelegate GetRequestDelegate()
        {
            IEnumerable<ListSnapshotsResponse> DefaultRequest(ListSnapshotsRequest request) => Enumerable.Repeat(client.ListSnapshots(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListSnapshotsResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListSnapshotsResponse response;
        private delegate IEnumerable<ListSnapshotsResponse> RequestDelegate(ListSnapshotsRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
