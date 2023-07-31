#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("XRAssetFunctionLibrary.h")]
public partial class UAsyncTask_LoadXRDeviceVisComponent : UBlueprintAsyncActionBase {
	///<summary>AddNamedDeviceVisualizationComponentAsync</summary>
	public static UAsyncTask_LoadXRDeviceVisComponent AddNamedDeviceVisualizationComponentAsync(AActor Target,string SystemName,string DeviceName,bool bManualAttachment,FTransform RelativeTransform,FXRDeviceId XRDeviceId,UPrimitiveComponent NewComponent) { return default; }
	///<summary>AddDeviceVisualizationComponentAsync</summary>
	public static UAsyncTask_LoadXRDeviceVisComponent AddDeviceVisualizationComponentAsync(AActor Target,FXRDeviceId XRDeviceId,bool bManualAttachment,FTransform RelativeTransform,UPrimitiveComponent NewComponent) { return default; }
	///<summary>OnModelLoaded</summary>
	public FDeviceModelLoadedDelegate OnModelLoaded;
	///<summary>OnLoadFailure</summary>
	public FDeviceModelLoadedDelegate OnLoadFailure;
	///<summary>SpawnedComponent</summary>
	public UPrimitiveComponent SpawnedComponent;
}
