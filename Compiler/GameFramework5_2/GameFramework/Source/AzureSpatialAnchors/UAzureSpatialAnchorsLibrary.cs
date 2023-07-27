#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AzureSpatialAnchorsFunctionLibrary.h")]
///<summary>A function library that provides static/Blueprint functions for AzureSpatialAnchors.</summary>
public partial class UAzureSpatialAnchorsLibrary : UBlueprintFunctionLibrary {
// AzureSpatialAnchorsLibrary
	public static bool CreateSession() { return default; }
	public static bool ConfigSession(string AccountId,string AccountKey,FCoarseLocalizationSettings CoarseLocalizationSettings,EAzureSpatialAnchorsLogVerbosity LogVerbosity) { return default; }
	public static bool ConfigSession2(FAzureSpatialAnchorsSessionConfiguration SessionConfiguration,FCoarseLocalizationSettings CoarseLocalizationSettings,EAzureSpatialAnchorsLogVerbosity LogVerbosity) { return default; }
	public static bool StartSession() { return default; }
	public static bool StopSession() { return default; }
	public static bool DestroySession() { return default; }
	public static bool GetCachedSessionStatus(FAzureSpatialAnchorsSessionStatus OutStatus) { return default; }
	public static void GetSessionStatus(UObject WorldContextObject,FLatentActionInfo LatentInfo,FAzureSpatialAnchorsSessionStatus OutStatus,EAzureSpatialAnchorsResult OutResult,string OutErrorString) {}
	public static void GetCloudAnchor(UARPin ARPin,UAzureCloudSpatialAnchor OutAzureCloudSpatialAnchor) {}
	public static void GetCloudAnchors(TArray<UAzureCloudSpatialAnchor> OutCloudAnchors) {}
	public static void SavePinToCloud(UObject WorldContextObject,FLatentActionInfo LatentInfo,UARPin ARPin,float Lifetime,UAzureCloudSpatialAnchor OutAzureCloudSpatialAnchor,EAzureSpatialAnchorsResult OutResult,string OutErrorString) {}
	public static void SavePinToCloudWithAppProperties(UObject WorldContextObject,FLatentActionInfo LatentInfo,UARPin ARPin,float Lifetime,TMap<string,string> InAppProperties,UAzureCloudSpatialAnchor OutAzureCloudSpatialAnchor,EAzureSpatialAnchorsResult OutResult,string OutErrorString) {}
	public static void DeleteCloudAnchor(UObject WorldContextObject,FLatentActionInfo LatentInfo,UAzureCloudSpatialAnchor CloudSpatialAnchor,EAzureSpatialAnchorsResult OutResult,string OutErrorString) {}
	public static void LoadCloudAnchor(UObject WorldContextObject,FLatentActionInfo LatentInfo,string CloudIdentifier,string PinId,UARPin OutARPin,UAzureCloudSpatialAnchor OutAzureCloudSpatialAnchor,EAzureSpatialAnchorsResult OutResult,string OutErrorString) {}
	public static void ConstructCloudAnchor(UARPin ARPin,UAzureCloudSpatialAnchor OutAzureCloudSpatialAnchor,EAzureSpatialAnchorsResult OutResult,string OutErrorString) {}
	public static void SaveCloudAnchor(UObject WorldContextObject,FLatentActionInfo LatentInfo,UAzureCloudSpatialAnchor InAzureCloudSpatialAnchor,EAzureSpatialAnchorsResult OutResult,string OutErrorString) {}
	public static void UpdateCloudAnchorProperties(UObject WorldContextObject,FLatentActionInfo LatentInfo,UAzureCloudSpatialAnchor InAzureCloudSpatialAnchor,EAzureSpatialAnchorsResult OutResult,string OutErrorString) {}
	public static void RefreshCloudAnchorProperties(UObject WorldContextObject,FLatentActionInfo LatentInfo,UAzureCloudSpatialAnchor InAzureCloudSpatialAnchor,EAzureSpatialAnchorsResult OutResult,string OutErrorString) {}
	public static void CreateWatcher(UObject WorldContextObject,FAzureSpatialAnchorsLocateCriteria InLocateCriteria,int OutWatcherIdentifier,EAzureSpatialAnchorsResult OutResult,string OutErrorString) {}
	public static bool StopWatcher(int InWatcherIdentifier) { return default; }
	public static bool CreateARPinAroundAzureCloudSpatialAnchor(string PinId,UAzureCloudSpatialAnchor InAzureCloudSpatialAnchor,UARPin OutARPin) { return default; }
}
