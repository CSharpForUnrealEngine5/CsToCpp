#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AzureSpatialAnchorsFunctionLibrary.h")]
///<summary>A function library that provides static/Blueprint functions for AzureSpatialAnchors.</summary>
public partial class UAzureSpatialAnchorsLibrary : UBlueprintFunctionLibrary {
// AzureSpatialAnchorsLibrary
	public bool CreateSession() { return default; }
	public bool ConfigSession(string AccountId,string AccountKey,FCoarseLocalizationSettings CoarseLocalizationSettings,EAzureSpatialAnchorsLogVerbosity LogVerbosity) { return default; }
	public bool ConfigSession2(FAzureSpatialAnchorsSessionConfiguration SessionConfiguration,FCoarseLocalizationSettings CoarseLocalizationSettings,EAzureSpatialAnchorsLogVerbosity LogVerbosity) { return default; }
	public bool StartSession() { return default; }
	public bool StopSession() { return default; }
	public bool DestroySession() { return default; }
	public bool GetCachedSessionStatus(FAzureSpatialAnchorsSessionStatus OutStatus) { return default; }
	public void GetSessionStatus(UObject WorldContextObject,FLatentActionInfo LatentInfo,FAzureSpatialAnchorsSessionStatus OutStatus,EAzureSpatialAnchorsResult OutResult,string OutErrorString) {}
	public void GetCloudAnchor(UObject ARPin,UObject OutAzureCloudSpatialAnchor) {}
	public void GetCloudAnchors(TArray<UObject> OutCloudAnchors) {}
	public void SavePinToCloud(UObject WorldContextObject,FLatentActionInfo LatentInfo,UObject ARPin,float Lifetime,UObject OutAzureCloudSpatialAnchor,EAzureSpatialAnchorsResult OutResult,string OutErrorString) {}
	public void SavePinToCloudWithAppProperties(UObject WorldContextObject,FLatentActionInfo LatentInfo,UObject ARPin,float Lifetime,TMap<string,string> InAppProperties,UObject OutAzureCloudSpatialAnchor,EAzureSpatialAnchorsResult OutResult,string OutErrorString) {}
	public void DeleteCloudAnchor(UObject WorldContextObject,FLatentActionInfo LatentInfo,UObject CloudSpatialAnchor,EAzureSpatialAnchorsResult OutResult,string OutErrorString) {}
	public void LoadCloudAnchor(UObject WorldContextObject,FLatentActionInfo LatentInfo,string CloudIdentifier,string PinId,UObject OutARPin,UObject OutAzureCloudSpatialAnchor,EAzureSpatialAnchorsResult OutResult,string OutErrorString) {}
	public void ConstructCloudAnchor(UObject ARPin,UObject OutAzureCloudSpatialAnchor,EAzureSpatialAnchorsResult OutResult,string OutErrorString) {}
	public void SaveCloudAnchor(UObject WorldContextObject,FLatentActionInfo LatentInfo,UObject InAzureCloudSpatialAnchor,EAzureSpatialAnchorsResult OutResult,string OutErrorString) {}
	public void UpdateCloudAnchorProperties(UObject WorldContextObject,FLatentActionInfo LatentInfo,UObject InAzureCloudSpatialAnchor,EAzureSpatialAnchorsResult OutResult,string OutErrorString) {}
	public void RefreshCloudAnchorProperties(UObject WorldContextObject,FLatentActionInfo LatentInfo,UObject InAzureCloudSpatialAnchor,EAzureSpatialAnchorsResult OutResult,string OutErrorString) {}
	public void CreateWatcher(UObject WorldContextObject,FAzureSpatialAnchorsLocateCriteria InLocateCriteria,int OutWatcherIdentifier,EAzureSpatialAnchorsResult OutResult,string OutErrorString) {}
	public bool StopWatcher(int InWatcherIdentifier) { return default; }
	public bool CreateARPinAroundAzureCloudSpatialAnchor(string PinId,UObject InAzureCloudSpatialAnchor,UObject OutARPin) { return default; }
}
