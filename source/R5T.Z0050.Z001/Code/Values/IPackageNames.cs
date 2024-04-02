using System;

using R5T.T0131;


namespace R5T.Z0050.Z001
{
    [ValuesMarker]
    public partial interface IPackageNames : IValuesMarker
    {
        /// <summary>
        /// <para><value>Microsoft.AspNetCore.Components.Web</value></para>
        /// </summary>
        public string Microsoft_AspNetCore_Components_Web => "Microsoft.AspNetCore.Components.Web";

        /// <summary>
        /// <para><value>Microsoft.AspNetCore.Components.WebAssembly</value></para>
        /// </summary>
        public string Microsoft_AspNetCore_Components_WebAssembly => "Microsoft.AspNetCore.Components.WebAssembly";

        /// <summary>
        /// <para><value>Microsoft.AspNetCore.Components.WebAssembly.Server</value></para>
        /// </summary>
        public string Microsoft_AspNetCore_Components_WebAssembly_Server => "Microsoft.AspNetCore.Components.WebAssembly.Server";
    }
}
