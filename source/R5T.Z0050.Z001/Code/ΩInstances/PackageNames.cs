using System;


namespace R5T.Z0050.Z001
{
    public class PackageNames : IPackageNames
    {
        #region Infrastructure

        public static IPackageNames Instance { get; } = new PackageNames();


        private PackageNames()
        {
        }

        #endregion
    }
}
