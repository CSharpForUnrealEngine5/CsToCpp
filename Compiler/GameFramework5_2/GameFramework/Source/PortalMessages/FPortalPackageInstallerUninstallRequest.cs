namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PortalPackageInstallerMessages.h")]
public partial struct FPortalPackageInstallerUninstallRequest {
	public string AppName;
	public string BuildLabel;
	public string InstallationPath;
	public bool RemoveUserFiles;
}
