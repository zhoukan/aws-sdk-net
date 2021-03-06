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
    using System.IO;
    using ThirdParty.Json.LitJson;
    using Amazon.Kinesis.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// RecordUnmarshaller
      /// </summary>
      internal class RecordUnmarshaller : IUnmarshaller<Record, XmlUnmarshallerContext>, IUnmarshaller<Record, JsonUnmarshallerContext>
      {
        Record IUnmarshaller<Record, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public Record Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            Record record = new Record();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("SequenceNumber", targetDepth))
              {
                record.SequenceNumber = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Data", targetDepth))
              {
                record.Data = MemoryStreamUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("PartitionKey", targetDepth))
              {
                record.PartitionKey = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
            }
          
            return record;
        }

        private static RecordUnmarshaller instance;
        public static RecordUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new RecordUnmarshaller();
            return instance;
        }
    }
}
  
