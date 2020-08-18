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
using Oci.Common.Waiters;

namespace Oci.CoreService.Cmdlets
{
    [Cmdlet("Get", "OCIVirtualNetworkVirtualCircuit", DefaultParameterSetName = Default)]
    [OutputType(new System.Type[] { typeof(Oci.CoreService.Models.VirtualCircuit), typeof(Oci.CoreService.Responses.GetVirtualCircuitResponse) })]
    public class GetOCIVirtualNetworkVirtualCircuit : OCIVirtualNetworkCmdlet
    {
        
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the virtual circuit.", ParameterSetName = LifecycleStateParamSet)]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the virtual circuit.", ParameterSetName = Default)]
        public string VirtualCircuitId { get; set; }

        [Parameter(Mandatory = true, HelpMessage = @"This operation creates, modifies or deletes a resource that has a defined lifecycle state. Specify this option to perform the action and then wait until the resource reaches a given lifecycle state. Multiple states can be specified, returning on the first state.", ParameterSetName = LifecycleStateParamSet)]
        public Oci.CoreService.Models.VirtualCircuit.LifecycleStateEnum[] WaitForLifecycleState { get; set; }

        [Parameter(Mandatory = false, HelpMessage = @"Check every WaitIntervalSeconds to see whether the resource has reached a desired state.", ParameterSetName = LifecycleStateParamSet)]
        public int WaitIntervalSeconds { get; set; } = WAIT_INTERVAL_SECONDS;

        [Parameter(Mandatory = false, HelpMessage = @"Maximum number of attempts to be made until the resource reaches a desired state.", ParameterSetName = LifecycleStateParamSet)]
        public int MaxWaitAttempts { get; set; } = MAX_WAITER_ATTEMPTS;

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GetVirtualCircuitRequest request;

            try
            {
                request = new GetVirtualCircuitRequest
                {
                    VirtualCircuitId = VirtualCircuitId
                };

                HandleOutput(request);
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

        private void HandleOutput(GetVirtualCircuitRequest request)
        {
            var waiterConfig = new WaiterConfiguration
            {
                MaxAttempts = MaxWaitAttempts,
                GetNextDelayInSeconds = (_) => WaitIntervalSeconds
            };

            switch (ParameterSetName)
            { 
                case LifecycleStateParamSet:
                    response = client.Waiters.ForVirtualCircuit(request, waiterConfig, WaitForLifecycleState).Execute();
                    break;

                case Default:
                    response = client.GetVirtualCircuit(request).GetAwaiter().GetResult();
                    break;
            }
            WriteOutput(response, response.VirtualCircuit);
        }

        private GetVirtualCircuitResponse response;
        private const string LifecycleStateParamSet = "LifecycleStateParamSet";
        private const string Default = "Default";
    }
}
