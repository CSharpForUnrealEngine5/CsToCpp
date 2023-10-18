namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Helper class that allows the user to explicitly request AR service installation and permission granting.</summary>
[CppInclude("ARDependencyHandler.h")]
public partial class UARDependencyHandler : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>@return the dependency handler for the current platform.</summary>
	public static UARDependencyHandler GetARDependencyHandler() { return default; }
	///<summary>Latent action to check AR availability on the current platform.</summary>
	public virtual void CheckARServiceAvailability(UObject WorldContextObject,FLatentActionInfo LatentInfo,EARServiceAvailability OutAvailability) {}
	///<summary>Latent action to install AR service on the current platform.</summary>
	public virtual void InstallARService(UObject WorldContextObject,FLatentActionInfo LatentInfo,EARServiceInstallRequestResult OutInstallResult) {}
	///<summary>Latent action to request permission to run the supplied session configuration.</summary>
	public virtual void RequestARSessionPermission(UObject WorldContextObject,UARSessionConfig SessionConfig,FLatentActionInfo LatentInfo,EARServicePermissionRequestResult OutPermissionResult) {}
	///<summary>Latent action to start AR session.</summary>
	public virtual void StartARSessionLatent(UObject WorldContextObject,UARSessionConfig SessionConfig,FLatentActionInfo LatentInfo) {}
}
