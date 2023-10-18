namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A function library that provides static/Blueprint functions for AzureSpatialAnchors.</summary>
[CppInclude("AzureSpatialAnchorsFunctionLibrary.h")]
public partial class UAzureSpatialAnchorsLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Create an ASA session.</summary>
	public static bool CreateSession() { return default; }
	///<summary>Configure the ASA session.</summary>
	public static bool ConfigSession(string AccountId,string AccountKey,FCoarseLocalizationSettings CoarseLocalizationSettings,EAzureSpatialAnchorsLogVerbosity LogVerbosity) { return default; }
	///<summary>Configure the ASA session.</summary>
	public static bool ConfigSession2(FAzureSpatialAnchorsSessionConfiguration SessionConfiguration,FCoarseLocalizationSettings CoarseLocalizationSettings,EAzureSpatialAnchorsLogVerbosity LogVerbosity) { return default; }
	///<summary>Start a Session running.</summary>
	public static bool StartSession() { return default; }
	///<summary>The session will stop, it can be started again.</summary>
	public static bool StopSession() { return default; }
	///<summary>The session will be destroyed.</summary>
	public static bool DestroySession() { return default; }
	///<summary>Get the azure spatial anchors session status struct.</summary>
	public static bool GetCachedSessionStatus(FAzureSpatialAnchorsSessionStatus OutStatus) { return default; }
	///<summary>Get the AzureSpatialAnchors Session&#39;s Status.</summary>
	public static void GetSessionStatus(UObject WorldContextObject,FLatentActionInfo LatentInfo,FAzureSpatialAnchorsSessionStatus OutStatus,EAzureSpatialAnchorsResult OutResult,string OutErrorString) {}
	///<summary>Get the cloud anchor associated with a particular ARPin.</summary>
	public static void GetCloudAnchor(UARPin ARPin,UAzureCloudSpatialAnchor OutAzureCloudSpatialAnchor) {}
	///<summary>Get list of all CloudAnchors.</summary>
	public static void GetCloudAnchors(TArray<UAzureCloudSpatialAnchor> OutCloudAnchors) {}
	///<summary>Save the pin to the cloud.</summary>
	public static void SavePinToCloud(UObject WorldContextObject,FLatentActionInfo LatentInfo,UARPin ARPin,float Lifetime,UAzureCloudSpatialAnchor OutAzureCloudSpatialAnchor,EAzureSpatialAnchorsResult OutResult,string OutErrorString) {}
	///<summary>Save the pin to the cloud.</summary>
	public static void SavePinToCloudWithAppProperties(UObject WorldContextObject,FLatentActionInfo LatentInfo,UARPin ARPin,float Lifetime,TMap<string,string> InAppProperties,UAzureCloudSpatialAnchor OutAzureCloudSpatialAnchor,EAzureSpatialAnchorsResult OutResult,string OutErrorString) {}
	///<summary>Delete the cloud anchor in the cloud.</summary>
	public static void DeleteCloudAnchor(UObject WorldContextObject,FLatentActionInfo LatentInfo,UAzureCloudSpatialAnchor CloudSpatialAnchor,EAzureSpatialAnchorsResult OutResult,string OutErrorString) {}
	///<summary>Load a pin from the cloud..</summary>
	public static void LoadCloudAnchor(UObject WorldContextObject,FLatentActionInfo LatentInfo,string CloudIdentifier,string PinId,UARPin OutARPin,UAzureCloudSpatialAnchor OutAzureCloudSpatialAnchor,EAzureSpatialAnchorsResult OutResult,string OutErrorString) {}
	///<summary>Construct a cloud anchor for the pin.  This is not yet stored in the cloud.</summary>
	public static void ConstructCloudAnchor(UARPin ARPin,UAzureCloudSpatialAnchor OutAzureCloudSpatialAnchor,EAzureSpatialAnchorsResult OutResult,string OutErrorString) {}
	///<summary>Save the cloud anchor to the cloud.</summary>
	public static void SaveCloudAnchor(UObject WorldContextObject,FLatentActionInfo LatentInfo,UAzureCloudSpatialAnchor InAzureCloudSpatialAnchor,EAzureSpatialAnchorsResult OutResult,string OutErrorString) {}
	///<summary>Save the cloud anchor&#39;s properties to the cloud.</summary>
	public static void UpdateCloudAnchorProperties(UObject WorldContextObject,FLatentActionInfo LatentInfo,UAzureCloudSpatialAnchor InAzureCloudSpatialAnchor,EAzureSpatialAnchorsResult OutResult,string OutErrorString) {}
	///<summary>Get the latest cloud anchor properties from the cloud.</summary>
	public static void RefreshCloudAnchorProperties(UObject WorldContextObject,FLatentActionInfo LatentInfo,UAzureCloudSpatialAnchor InAzureCloudSpatialAnchor,EAzureSpatialAnchorsResult OutResult,string OutErrorString) {}
	///<summary>Create and start a &#39;Watcher&#39; searching for azure cloud spatial anchors as specified in the locate criteria.  Use an AzureSpatialAnchorsEventComponent&#39;s events to get</summary>
	public static void CreateWatcher(UObject WorldContextObject,FAzureSpatialAnchorsLocateCriteria InLocateCriteria,int OutWatcherIdentifier,EAzureSpatialAnchorsResult OutResult,string OutErrorString) {}
	///<summary>Stop the specified Watcher looking for anchors, if it still exists.</summary>
	public static bool StopWatcher(int InWatcherIdentifier) { return default; }
	///<summary>Create an ARPin around an already existing cloud anchor.</summary>
	public static bool CreateARPinAroundAzureCloudSpatialAnchor(string PinId,UAzureCloudSpatialAnchor InAzureCloudSpatialAnchor,UARPin OutARPin) { return default; }
}
