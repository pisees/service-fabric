// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Fabric;

namespace System.Fabric.Test.HttpGatewayTest
{
    [Serializable]
    [DataContract]
    class PropertyBatchDescription
    {

        public PropertyBatchDescription()
        {
            Operations = new List<PropertyBatchOperation>();
        }

        [DataMember]
        public List<PropertyBatchOperation> Operations
        {
            get;
            set;
        }
    }
}