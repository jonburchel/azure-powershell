// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Extensions;

    /// <summary>The approval settings.</summary>
    public partial class ApprovalSettings
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Json.JsonObject into a new instance of <see cref="ApprovalSettings" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ApprovalSettings(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_isApprovalRequired = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Json.JsonBoolean>("isApprovalRequired"), out var __jsonIsApprovalRequired) ? (bool?)__jsonIsApprovalRequired : IsApprovalRequired;}
            {_isApprovalRequiredForExtension = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Json.JsonBoolean>("isApprovalRequiredForExtension"), out var __jsonIsApprovalRequiredForExtension) ? (bool?)__jsonIsApprovalRequiredForExtension : IsApprovalRequiredForExtension;}
            {_isRequestorJustificationRequired = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Json.JsonBoolean>("isRequestorJustificationRequired"), out var __jsonIsRequestorJustificationRequired) ? (bool?)__jsonIsRequestorJustificationRequired : IsRequestorJustificationRequired;}
            {_approvalMode = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Json.JsonString>("approvalMode"), out var __jsonApprovalMode) ? (string)__jsonApprovalMode : (string)ApprovalMode;}
            {_approvalStage = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Json.JsonArray>("approvalStages"), out var __jsonApprovalStages) ? If( __jsonApprovalStages as Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IApprovalStage[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IApprovalStage) (Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.ApprovalStage.FromJson(__u) )) ))() : null : ApprovalStage;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IApprovalSettings.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IApprovalSettings.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IApprovalSettings FromJson(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Json.JsonObject json ? new ApprovalSettings(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="ApprovalSettings" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ApprovalSettings" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._isApprovalRequired ? (Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Json.JsonBoolean((bool)this._isApprovalRequired) : null, "isApprovalRequired" ,container.Add );
            AddIf( null != this._isApprovalRequiredForExtension ? (Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Json.JsonBoolean((bool)this._isApprovalRequiredForExtension) : null, "isApprovalRequiredForExtension" ,container.Add );
            AddIf( null != this._isRequestorJustificationRequired ? (Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Json.JsonBoolean((bool)this._isRequestorJustificationRequired) : null, "isRequestorJustificationRequired" ,container.Add );
            AddIf( null != (((object)this._approvalMode)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Json.JsonString(this._approvalMode.ToString()) : null, "approvalMode" ,container.Add );
            if (null != this._approvalStage)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Json.XNodeArray();
                foreach( var __x in this._approvalStage )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("approvalStages",__w);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}