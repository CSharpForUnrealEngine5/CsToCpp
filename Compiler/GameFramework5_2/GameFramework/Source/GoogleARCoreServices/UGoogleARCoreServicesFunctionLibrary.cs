#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GoogleARCoreServicesFunctionLibrary.h")]
///<summary>A function library that provides static/Blueprint functions for Google ARCore Services.</summary>
public partial class UGoogleARCoreServicesFunctionLibrary : UBlueprintFunctionLibrary {
// GoogleARCoreServicesFunctionLibrary
	public static bool ConfigGoogleARCoreServices(FGoogleARCoreServicesConfig ServiceConfig) { return default; }
	public static void CreateAndHostCloudARPinLatentAction(UObject WorldContextObject,FLatentActionInfo LatentInfo,UARPin ARPinToHost,EARPinCloudTaskResult OutHostingResult,UCloudARPin OutCloudARPin) {}
	public static void CreateAndResolveCloudARPinLatentAction(UObject WorldContextObject,FLatentActionInfo LatentInfo,string CloudId,EARPinCloudTaskResult OutAcquiringResult,UCloudARPin OutCloudARPin) {}
	public static UCloudARPin CreateAndHostCloudARPin(UARPin ARPinToHost,EARPinCloudTaskResult OutTaskResult) { return default; }
	public static UCloudARPin CreateAndResolveCloudARPin(string CloudId,EARPinCloudTaskResult OutTaskResult) { return default; }
	public static void RemoveCloudARPin(UCloudARPin PinToRemove) {}
	public static TArray<UCloudARPin> GetAllCloudARPin() { return default; }
}
