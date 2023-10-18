namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A function library that provides static/Blueprint functions for Google ARCore Services.</summary>
[CppInclude("GoogleARCoreServicesFunctionLibrary.h")]
public partial class UGoogleARCoreServicesFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Configure the current Unreal AR session with the desired GoogleARCoreServices configuration.</summary>
	public static bool ConfigGoogleARCoreServices(FGoogleARCoreServicesConfig ServiceConfig) { return default; }
	///<summary>This will start a Latent Action to host the ARPin and creating a UCloudARPin from it.</summary>
	public static void CreateAndHostCloudARPinLatentAction(UObject WorldContextObject,FLatentActionInfo LatentInfo,UARPin ARPinToHost,int LifetimeInDays,EARPinCloudTaskResult OutHostingResult,UCloudARPin OutCloudARPin) {}
	///<summary>This will start a Latent Action to create UCloudARPin using the given CloudId. The complete flow</summary>
	public static void CreateAndResolveCloudARPinLatentAction(UObject WorldContextObject,FLatentActionInfo LatentInfo,string CloudId,EARPinCloudTaskResult OutAcquiringResult,UCloudARPin OutCloudARPin) {}
	///<summary>Creating and hosting a CloudARPin and return it immediately.</summary>
	public static UCloudARPin CreateAndHostCloudARPin(UARPin ARPinToHost,int LifetimeInDays,EARPinCloudTaskResult OutTaskResult) { return default; }
	///<summary>Creating and Resolving a CloudARPin and return it immediately.</summary>
	public static UCloudARPin CreateAndResolveCloudARPin(string CloudId,EARPinCloudTaskResult OutTaskResult) { return default; }
	///<summary>Remove the given CloudARPin from the current ARSession.</summary>
	public static void RemoveCloudARPin(UCloudARPin PinToRemove) {}
	///<summary>Get a list of all CloudARPin in the current ARSession.</summary>
	public static TArray<UCloudARPin> GetAllCloudARPin() { return default; }
}
