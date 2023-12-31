namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("XRAssetFunctionLibrary.h")]
public partial class UAsyncTask_LoadXRDeviceVisComponent : UBlueprintAsyncActionBase {
	public static UClass StaticClass() {return default;}
	///<summary>AddNamedDeviceVisualizationComponentAsync</summary>
	public static UAsyncTask_LoadXRDeviceVisComponent AddNamedDeviceVisualizationComponentAsync(AActor Target,FName SystemName,FName DeviceName,bool bManualAttachment,FTransform RelativeTransform,FXRDeviceId XRDeviceId,UPrimitiveComponent NewComponent) { return default; }
	///<summary>AddDeviceVisualizationComponentAsync</summary>
	public static UAsyncTask_LoadXRDeviceVisComponent AddDeviceVisualizationComponentAsync(AActor Target,FXRDeviceId XRDeviceId,bool bManualAttachment,FTransform RelativeTransform,UPrimitiveComponent NewComponent) { return default; }
	///<summary>OnModelLoaded</summary>
	public FDeviceModelLoadedDelegate OnModelLoaded;
	///<summary>OnLoadFailure</summary>
	public FDeviceModelLoadedDelegate OnLoadFailure;
	///<summary>SpawnedComponent</summary>
	public UPrimitiveComponent SpawnedComponent;
}
