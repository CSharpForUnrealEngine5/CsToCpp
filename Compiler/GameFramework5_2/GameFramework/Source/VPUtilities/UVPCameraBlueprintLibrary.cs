#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VPCameraBlueprintLibrary.h")]
public partial class UVPCameraBlueprintLibrary : UBlueprintFunctionLibrary {
// VPCameraBlueprintLibrary
	public static ACameraRig_Rail SpawnDollyTrackFromPoints(UObject WorldContextObject,TArray<FTransform> Points,ESplinePointType InterpType/*=ESplinePointType.Linear*/) { return default; }
	public static ACameraRig_Rail SpawnDollyTrackFromPointsSmooth(UObject WorldContextObject,TArray<FTransform> Points,ESplinePointType InterpType/*=ESplinePointType.Linear*/) { return default; }
	public static ACameraRig_Rail SpawnCameraRigFromActors(UObject WorldContextObject,FTransform RigTransform,TArray<AActor> Actors,FVPCameraRigSpawnParams Params) { return default; }
	public static ACameraRig_Rail SpawnCameraRigFromPoints(UObject WorldContextObject,FTransform RigTransform,TArray<FVector> Points,FVPCameraRigSpawnParams Params) { return default; }
	public static ACameraRig_Rail SpawnCameraRigFromSelectedActors(UObject WorldContextObject,FTransform RigTransform,FVPCameraRigSpawnParams Params) { return default; }
}
