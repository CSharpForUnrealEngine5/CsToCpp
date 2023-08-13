namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UXRAssetFunctionLibrary</summary>
[CppInclude("XRAssetFunctionLibrary.h")]
public partial class UXRAssetFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Spawns a render component for the specified XR device.</summary>
	public static UPrimitiveComponent AddDeviceVisualizationComponentBlocking(AActor Target,FXRDeviceId XRDeviceId,bool bManualAttachment,FTransform RelativeTransform) { return default; }
	///<summary>Spawns a render component for the specified XR device.</summary>
	public static UPrimitiveComponent AddNamedDeviceVisualizationComponentBlocking(AActor Target,string SystemName,string DeviceName,bool bManualAttachment,FTransform RelativeTransform,FXRDeviceId XRDeviceId) { return default; }
}
