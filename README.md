A NuGet plugin for Xamarin.iOS, Xamarin.Android and Xamarin.Forms projects to get app version.

# Usage in Xamarin.Forms project

1. Add package to your PCL and platform specific projects, see [how](docs/how-to-compile-a-nuget-plugin-and-add-it.md);
1. In your Xamarin.Android project(if any), initialize AppVersion in MainActivity.cs:
    ```
    using AppVersionPlugin;
    
    public class MainAcitivity
    {
        AppVersion.Init(this);
    }
    ```
1. In your cross-platform project, new an instance of AppVersion and get the VersionName and VersionCode property:
    ```
    using AppVersionPlugin;

    AppVersion version = new AppVersion();
    versionLabel.Text = version.VersionName + " build " + version.VersionCode;
    ```