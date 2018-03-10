using System;
using Android.Content;

namespace Net.Erabbit.Xam.Plugin.AppVersion
{
    public class AppVersion : IAppVersion
    {
        static Context _context;

        public static void Init(Context context)
        {
            if (context != null)
            {
                _context = context;
            }
        }

        public AppVersion()
        {
        }

        public string VersionName {
            get {
                if (_context == null)
                    throw new Exception("AppVersion not inited");
                else
                    return _context.PackageManager.GetPackageInfo(_context.PackageName, 0).VersionName;
            }
        }

        public string VersionCode {
            get
            {
                if (_context == null)
                    throw new Exception("AppVersion not inited");
                else
                    return _context.PackageManager.GetPackageInfo(_context.PackageName, 0).VersionCode.ToString();
            }
        }
    }
}
