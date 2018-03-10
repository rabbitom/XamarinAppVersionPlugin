using System;
namespace Net.Erabbit.Xam.Plugin.AppVersion
{
    public interface IAppVersion
    {
        string VersionName { get; }
        string VersionCode { get; }
    }
}
