/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the AttachVpnGateway operation.
    /// <para>Attaches a virtual private gateway to a VPC. For more information, see <a
    /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html" >Adding a Hardware Virtual Private Gateway to Your VPC</a> in the
    /// <i>Amazon Virtual Private Cloud User Guide</i> .</para>
    /// </summary>
    public partial class AttachVpnGatewayRequest : AmazonEC2Request
    {
        private string vpnGatewayId;
        private string vpcId;


        /// <summary>
        /// The ID of the virtual private gateway.
        ///  
        /// </summary>
        public string VpnGatewayId
        {
            get { return this.vpnGatewayId; }
            set { this.vpnGatewayId = value; }
        }

        // Check to see if VpnGatewayId property is set
        internal bool IsSetVpnGatewayId()
        {
            return this.vpnGatewayId != null;
        }

        /// <summary>
        /// The ID of the VPC.
        ///  
        /// </summary>
        public string VpcId
        {
            get { return this.vpcId; }
            set { this.vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this.vpcId != null;
        }

    }
}
    
