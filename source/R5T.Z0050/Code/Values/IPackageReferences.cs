using System;

using R5T.T0131;
using R5T.T0205;
using R5T.T0205.Extensions;


namespace R5T.Z0050
{
    [ValuesMarker]
    public partial interface IPackageReferences : IValuesMarker
    {
        /// <summary>
        /// Microsoft.AspNetCore.Components.Web, 6.0.11
        /// </summary>
        private static readonly Lazy<PackageReference> zMicrosoft_AspNetCore_Components_Web_6_0_11 = new Lazy<PackageReference>(() => new PackageReference
        {
            Name = "Microsoft.AspNetCore.Components.Web".ToPackageName(),
            Version = "6.0.11".ToPackageVersion(),
        });

        /// <inheritdoc cref="zMicrosoft_AspNetCore_Components_Web_6_0_11"/>
        public PackageReference Microsoft_AspNetCore_Components_Web_6_0_11 => IPackageReferences.zMicrosoft_AspNetCore_Components_Web_6_0_11.Value;

        /// <summary>
        /// <para><inheritdoc cref="Microsoft_AspNetCore_Components_Web_6_0_11" path="/summary"/></para>
        /// Chooses <see cref="Microsoft_AspNetCore_Components_Web_6_0_11"/> as the default.
        /// </summary>
        public PackageReference Microsoft_AspNetCore_Components_Web => this.Microsoft_AspNetCore_Components_Web_6_0_11;


        /// <summary>
        /// Microsoft.AspNetCore.Components.WebAssembly, 6.0.11
        /// </summary>
        private static readonly Lazy<PackageReference> zMicrosoft_AspNetCore_Components_WebAssembly_6_0_11 = new Lazy<PackageReference>(() => new PackageReference
        {
            Name = "Microsoft.AspNetCore.Components.WebAssembly".ToPackageName(),
            Version = "6.0.11".ToPackageVersion(),
        });

        /// <inheritdoc cref="zMicrosoft_AspNetCore_Components_WebAssembly_6_0_11"/>
        public PackageReference Microsoft_AspNetCore_Components_WebAssembly_6_0_11 => IPackageReferences.zMicrosoft_AspNetCore_Components_WebAssembly_6_0_11.Value;

        /// <summary>
        /// <para><inheritdoc cref="Microsoft_AspNetCore_Components_WebAssembly_6_0_11" path="/summary"/></para>
        /// Chooses <see cref="Microsoft_AspNetCore_Components_WebAssembly_6_0_11"/> as the default.
        /// </summary>
        public PackageReference Microsoft_AspNetCore_Components_WebAssembly => this.Microsoft_AspNetCore_Components_WebAssembly_6_0_11;


        /// <summary>
        /// Microsoft.AspNetCore.Components.WebAssembly.DevServer, 6.0.11
        /// </summary>
        private static readonly Lazy<PackageReference> zMicrosoft_AspNetCore_Components_WebAssembly_DevServer_6_0_11 = new Lazy<PackageReference>(() => new PackageReference
        {
            Name = "Microsoft.AspNetCore.Components.WebAssembly.DevServer".ToPackageName(),
            Version = "6.0.11".ToPackageVersion(),
        });

        /// <inheritdoc cref="zMicrosoft_AspNetCore_Components_WebAssembly_DevServer_6_0_11"/>
        public PackageReference Microsoft_AspNetCore_Components_WebAssembly_DevServer_6_0_11 => IPackageReferences.zMicrosoft_AspNetCore_Components_WebAssembly_DevServer_6_0_11.Value;

        /// <summary>
        /// <para><inheritdoc cref="Microsoft_AspNetCore_Components_WebAssembly_DevServer_6_0_11" path="/summary"/></para>
        /// Chooses <see cref="Microsoft_AspNetCore_Components_WebAssembly_DevServer_6_0_11"/> as the default.
        /// </summary>
        public PackageReference Microsoft_AspNetCore_Components_WebAssembly_DevServer => this.Microsoft_AspNetCore_Components_WebAssembly_DevServer_6_0_11;


        /// <summary>
        /// Microsoft.AspNetCore.Components.WebAssembly.Server, 6.0.11
        /// </summary>
        private static readonly Lazy<PackageReference> zMicrosoft_AspNetCore_Components_WebAssembly_Server_6_0_11 = new Lazy<PackageReference>(() => new PackageReference
        {
            Name = "Microsoft.AspNetCore.Components.WebAssembly.Server".ToPackageName(),
            Version = "6.0.11".ToPackageVersion(),
        });

        /// <inheritdoc cref="zMicrosoft_AspNetCore_Components_WebAssembly_Server_6_0_11"/>
        public PackageReference Microsoft_AspNetCore_Components_WebAssembly_Server_6_0_11 => IPackageReferences.zMicrosoft_AspNetCore_Components_WebAssembly_Server_6_0_11.Value;

        /// <summary>
        /// <para><inheritdoc cref="zMicrosoft_AspNetCore_Components_WebAssembly_Server_6_0_11" path="/summary"/></para>
        /// Chooses <see cref="zMicrosoft_AspNetCore_Components_WebAssembly_Server_6_0_11"/> as the default.
        /// </summary>
        public PackageReference Microsoft_AspNetCore_Components_WebAssembly_Server => this.Microsoft_AspNetCore_Components_WebAssembly_Server_6_0_11;


        /// <summary>
        /// Microsoft.NET.Test.Sdk, 17.0.0
        /// </summary>
        private static readonly Lazy<PackageReference> zMicrosoft_NET_Test_Sdk_17_0_0 = new Lazy<PackageReference>(() => new PackageReference
        {
            Name = "Microsoft.NET.Test.Sdk".ToPackageName(),
            Version = "17.0.0".ToPackageVersion(),
        });

        /// <inheritdoc cref="zMicrosoft_NET_Test_Sdk_17_0_0"/>
        public PackageReference Microsoft_NET_Test_Sdk_17_0_0 => IPackageReferences.zMicrosoft_NET_Test_Sdk_17_0_0.Value;

        /// <summary>
        /// <para><inheritdoc cref="Microsoft_NET_Test_Sdk_17_0_0" path="/summary"/></para>
        /// Chooses <see cref="Microsoft_NET_Test_Sdk_17_0_0"/> as the default.
        /// </summary>
        public PackageReference Microsoft_NET_Test_Sdk => this.Microsoft_NET_Test_Sdk_17_0_0;


        /// <summary>
        /// MSTest.TestAdapter, 2.2.8
        /// </summary>
        private static readonly Lazy<PackageReference> zMSTest_TestAdapter_2_2_8 = new Lazy<PackageReference>(() => new PackageReference
        {
            Name = "MSTest.TestAdapter".ToPackageName(),
            Version = "2.2.8".ToPackageVersion(),
        });
        /// <inheritdoc cref="zMSTest_TestAdapter_2_2_8"/>
        public PackageReference MSTest_TestAdapter_2_2_8 => IPackageReferences.zMSTest_TestAdapter_2_2_8.Value;

        /// <summary>
        /// <para><inheritdoc cref="MSTest_TestAdapter_2_2_8" path="/summary"/></para>
        /// Chooses <see cref="MSTest_TestAdapter_2_2_8"/> as the default.
        /// </summary>
        public PackageReference MSTest_TestAdapter => this.MSTest_TestAdapter_2_2_8;
    }
}
