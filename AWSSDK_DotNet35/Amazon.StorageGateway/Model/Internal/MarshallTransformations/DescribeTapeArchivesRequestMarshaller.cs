/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.StorageGateway.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.StorageGateway.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Describe Tape Archives Request Marshaller
    /// </summary>       
    internal class DescribeTapeArchivesRequestMarshaller : IMarshaller<IRequest, DescribeTapeArchivesRequest> 
    {
        

        public IRequest Marshall(DescribeTapeArchivesRequest describeTapeArchivesRequest) 
        {

            IRequest request = new DefaultRequest(describeTapeArchivesRequest, "AmazonStorageGateway");
            string target = "StorageGateway_20130630.DescribeTapeArchives";
            request.Headers["X-Amz-Target"] = target;
            
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            
            string uriResourcePath = ""; 
            request.ResourcePath = uriResourcePath;
            
             
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                

                if (describeTapeArchivesRequest != null && describeTapeArchivesRequest.TapeARNs != null && describeTapeArchivesRequest.TapeARNs.Count > 0) 
                {
                    List<string> tapeARNsList = describeTapeArchivesRequest.TapeARNs;
                    writer.WritePropertyName("TapeARNs");
                    writer.WriteArrayStart();

                    foreach (string tapeARNsListValue in tapeARNsList) 
                    { 
                        writer.Write(StringUtils.FromString(tapeARNsListValue));
                    }

                    writer.WriteArrayEnd();
                }
                if (describeTapeArchivesRequest != null && describeTapeArchivesRequest.IsSetMarker()) 
                {
                    writer.WritePropertyName("Marker");
                    writer.Write(describeTapeArchivesRequest.Marker);
                }
                if (describeTapeArchivesRequest != null && describeTapeArchivesRequest.IsSetLimit()) 
                {
                    writer.WritePropertyName("Limit");
                    writer.Write(describeTapeArchivesRequest.Limit);
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }
        

            return request;
        }
    }
}
