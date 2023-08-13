namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Service discovery messages</summary>
[CppInclude("PortalPackageInstallerMessages.h")]
public partial struct FPortalPackageInstallerInstallRequest {
	public string AppName;
	public string BuildLabel;
	public string DestinationPath;
}
