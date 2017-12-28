﻿using System;
using Foundation;

namespace AppVersionPlugin
{
    public class AppVersion : IAppVersion
    {
        public AppVersion()
        {
        }

        public string VersionName => NSBundle.MainBundle.InfoDictionary["CFBundleShortVersionString"].ToString();

        public string VersionCode => NSBundle.MainBundle.InfoDictionary["CFBundleVersion"].ToString();
    }
}
