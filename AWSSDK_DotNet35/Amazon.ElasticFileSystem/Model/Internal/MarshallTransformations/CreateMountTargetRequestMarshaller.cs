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

/*
 * Do not modify this file. This file is generated from the efs-2015-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticFileSystem.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ElasticFileSystem.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateMountTarget Request Marshaller
    /// </summary>       
    public class CreateMountTargetRequestMarshaller : IMarshaller<IRequest, CreateMountTargetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateMountTargetRequest)input);
        }

        public IRequest Marshall(CreateMountTargetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticFileSystem");
            request.Headers["Content-Type"] = "application/x-amz-json-";
            request.HttpMethod = "POST";

            string uriResourcePath = "/2015-02-01/mount-targets";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetFileSystemId())
                {
                    context.Writer.WritePropertyName("FileSystemId");
                    context.Writer.Write(publicRequest.FileSystemId);
                }

                if(publicRequest.IsSetIpAddress())
                {
                    context.Writer.WritePropertyName("IpAddress");
                    context.Writer.Write(publicRequest.IpAddress);
                }

                if(publicRequest.IsSetSecurityGroups())
                {
                    context.Writer.WritePropertyName("SecurityGroups");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSecurityGroupsListValue in publicRequest.SecurityGroups)
                    {
                            context.Writer.Write(publicRequestSecurityGroupsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetSubnetId())
                {
                    context.Writer.WritePropertyName("SubnetId");
                    context.Writer.Write(publicRequest.SubnetId);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }


    }
}