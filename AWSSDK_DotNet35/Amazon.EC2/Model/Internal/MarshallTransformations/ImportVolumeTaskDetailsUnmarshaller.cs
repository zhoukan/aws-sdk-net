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
using System.Collections.Generic;

using Amazon.EC2.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   ImportVolumeTaskDetails Unmarshaller
     /// </summary>
    internal class ImportVolumeTaskDetailsUnmarshaller : IUnmarshaller<ImportVolumeTaskDetails, XmlUnmarshallerContext>, IUnmarshaller<ImportVolumeTaskDetails, JsonUnmarshallerContext> 
    {
        public ImportVolumeTaskDetails Unmarshall(XmlUnmarshallerContext context) 
        {
            ImportVolumeTaskDetails importVolumeTaskDetails = new ImportVolumeTaskDetails();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 1;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("bytesConverted", targetDepth))
                    {
                        importVolumeTaskDetails.BytesConverted = LongUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("availabilityZone", targetDepth))
                    {
                        importVolumeTaskDetails.AvailabilityZone = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("description", targetDepth))
                    {
                        importVolumeTaskDetails.Description = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("image", targetDepth))
                    {
                        importVolumeTaskDetails.Image = DiskImageDescriptionUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("volume", targetDepth))
                    {
                        importVolumeTaskDetails.Volume = DiskImageVolumeDescriptionUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return importVolumeTaskDetails;
                }
            }
                        


            return importVolumeTaskDetails;
        }

        public ImportVolumeTaskDetails Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static ImportVolumeTaskDetailsUnmarshaller instance;

        public static ImportVolumeTaskDetailsUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ImportVolumeTaskDetailsUnmarshaller();

            return instance;
        }
    }
}
    
