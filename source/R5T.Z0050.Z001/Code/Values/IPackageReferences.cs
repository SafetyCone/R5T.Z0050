using System;

using R5T.T0131;
using R5T.T0206;


namespace R5T.Z0050.Z001
{
    [ValuesMarker]
    public partial interface IPackageReferences : IValuesMarker
    {
        /// <summary>
        /// <para><value><inheritdoc cref="IPackageNames.Microsoft_AspNetCore_Components_Web" path="/descendant::value"/>, 8.0.0</value></para>
        /// </summary>
        public PackageReference Microsoft_AspNetCore_Components_Web_8_0_1 => new PackageReference
        {
            Name = Instances.PackageNames.Microsoft_AspNetCore_Components_Web,
            Version = new Version(8, 0, 1),
        };

        /// <summary>
        /// <para><value><inheritdoc cref="IPackageNames.Microsoft_AspNetCore_Components_WebAssembly" path="/descendant::value"/>, 8.0.0</value></para>
        /// </summary>
        public PackageReference Microsoft_AspNetCore_Components_WebAssembly_8_0_0 => new PackageReference
        {
            Name = Instances.PackageNames.Microsoft_AspNetCore_Components_WebAssembly,
            Version = new Version(8, 0, 0),
        };

        /// <summary>
        /// <para><value><inheritdoc cref="IPackageNames.Microsoft_AspNetCore_Components_WebAssembly" path="/descendant::value"/>, 8.0.1</value></para>
        /// </summary>
        public PackageReference Microsoft_AspNetCore_Components_WebAssembly_8_0_1 => new PackageReference
        {
            Name = Instances.PackageNames.Microsoft_AspNetCore_Components_WebAssembly,
            Version = new Version(8, 0, 1),
        };

        /// <summary>
        /// <para><value><inheritdoc cref="IPackageNames.Microsoft_AspNetCore_Components_WebAssembly_Server" path="/descendant::value"/>, 8.0.1</value></para>
        /// </summary>
        public PackageReference Microsoft_AspNetCore_Components_WebAssembly_Server_8_0_1 => new PackageReference
        {
            Name = Instances.PackageNames.Microsoft_AspNetCore_Components_WebAssembly_Server,
            Version = new Version(8, 0, 1),
        };
    }
}
