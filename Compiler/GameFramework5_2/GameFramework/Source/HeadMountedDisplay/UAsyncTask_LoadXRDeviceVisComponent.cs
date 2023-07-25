#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("XRAssetFunctionLibrary.h")]
public partial class UAsyncTask_LoadXRDeviceVisComponent : UBlueprintAsyncActionBase {
// AsyncTask_LoadXRDeviceVisComponent
	public UObject AddNamedDeviceVisualizationComponentAsync(UObject Target,string SystemName,string DeviceName,bool bManualAttachment,FTransform RelativeTransform,FXRDeviceId XRDeviceId,UObject NewComponent) { return default; }
	public UObject AddDeviceVisualizationComponentAsync(UObject Target,FXRDeviceId XRDeviceId,bool bManualAttachment,FTransform RelativeTransform,UObject NewComponent) { return default; }
	public FDeviceModelLoadedDelegate OnModelLoaded;
	public FDeviceModelLoadedDelegate OnLoadFailure;
	public UPrimitiveComponent SpawnedComponent;
}
