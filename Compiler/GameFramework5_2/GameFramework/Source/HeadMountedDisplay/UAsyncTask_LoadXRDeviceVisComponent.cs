#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("XRAssetFunctionLibrary.h")]
public partial class UAsyncTask_LoadXRDeviceVisComponent : UBlueprintAsyncActionBase {
// AsyncTask_LoadXRDeviceVisComponent
	public static UAsyncTask_LoadXRDeviceVisComponent AddNamedDeviceVisualizationComponentAsync(AActor Target,string SystemName,string DeviceName,bool bManualAttachment,FTransform RelativeTransform,FXRDeviceId XRDeviceId,UPrimitiveComponent NewComponent) { return default; }
	public static UAsyncTask_LoadXRDeviceVisComponent AddDeviceVisualizationComponentAsync(AActor Target,FXRDeviceId XRDeviceId,bool bManualAttachment,FTransform RelativeTransform,UPrimitiveComponent NewComponent) { return default; }
	public FDeviceModelLoadedDelegate OnModelLoaded;
	public FDeviceModelLoadedDelegate OnLoadFailure;
	public UPrimitiveComponent SpawnedComponent;
}
