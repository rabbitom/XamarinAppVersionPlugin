using System;
namespace AppVersionPlugin
{
    public interface IAppVersion
    {
        string VersionName { get; }
        string VersionCode { get; }
    }
}
