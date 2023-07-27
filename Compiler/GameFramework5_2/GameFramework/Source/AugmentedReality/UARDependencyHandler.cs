#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARDependencyHandler.h")]
///<summary>Helper class that allows the user to explicitly request AR service installation and permission granting.</summary>
public partial class UARDependencyHandler : UObject {
// ARDependencyHandler
	public static UARDependencyHandler GetARDependencyHandler() { return default; }
	public  void CheckARServiceAvailability(UObject WorldContextObject,FLatentActionInfo LatentInfo,EARServiceAvailability OutAvailability) {}
	public  void InstallARService(UObject WorldContextObject,FLatentActionInfo LatentInfo,EARServiceInstallRequestResult OutInstallResult) {}
	public  void RequestARSessionPermission(UObject WorldContextObject,UARSessionConfig SessionConfig,FLatentActionInfo LatentInfo,EARServicePermissionRequestResult OutPermissionResult) {}
	public  void StartARSessionLatent(UObject WorldContextObject,UARSessionConfig SessionConfig,FLatentActionInfo LatentInfo) {}
}
