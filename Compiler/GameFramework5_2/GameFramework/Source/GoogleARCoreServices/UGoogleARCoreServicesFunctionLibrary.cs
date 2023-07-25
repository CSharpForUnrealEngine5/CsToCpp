#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GoogleARCoreServicesFunctionLibrary.h")]
///<summary>A function library that provides static/Blueprint functions for Google ARCore Services.</summary>
public partial class UGoogleARCoreServicesFunctionLibrary : UBlueprintFunctionLibrary {
// GoogleARCoreServicesFunctionLibrary
	public bool ConfigGoogleARCoreServices(FGoogleARCoreServicesConfig ServiceConfig) { return default; }
	public void CreateAndHostCloudARPinLatentAction(UObject WorldContextObject,FLatentActionInfo LatentInfo,UObject ARPinToHost,EARPinCloudTaskResult OutHostingResult,UObject OutCloudARPin) {}
	public void CreateAndResolveCloudARPinLatentAction(UObject WorldContextObject,FLatentActionInfo LatentInfo,string CloudId,EARPinCloudTaskResult OutAcquiringResult,UObject OutCloudARPin) {}
	public UObject CreateAndHostCloudARPin(UObject ARPinToHost,EARPinCloudTaskResult OutTaskResult) { return default; }
	public UObject CreateAndResolveCloudARPin(string CloudId,EARPinCloudTaskResult OutTaskResult) { return default; }
	public void RemoveCloudARPin(UObject PinToRemove) {}
	public TArray<UObject> GetAllCloudARPin() { return default; }
}
