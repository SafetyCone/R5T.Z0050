using System;


namespace R5T.Z0050
{
    public class PackageReferences : IPackageReferences
    {
        #region Infrastructure

        public static IPackageReferences Instance { get; } = new PackageReferences();


        private PackageReferences()
        {
        }

        #endregion
    }
}
