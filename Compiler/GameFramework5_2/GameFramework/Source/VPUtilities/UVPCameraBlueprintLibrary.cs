#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VPCameraBlueprintLibrary.h")]
public partial class UVPCameraBlueprintLibrary : UBlueprintFunctionLibrary {
// VPCameraBlueprintLibrary
	public UObject SpawnDollyTrackFromPoints(UObject WorldContextObject,TArray<FTransform> Points,ESplinePointType InterpType/*=ESplinePointType.Linear*/) { return default; }
	public UObject SpawnDollyTrackFromPointsSmooth(UObject WorldContextObject,TArray<FTransform> Points,ESplinePointType InterpType/*=ESplinePointType.Linear*/) { return default; }
	public UObject SpawnCameraRigFromActors(UObject WorldContextObject,FTransform RigTransform,TArray<UObject> Actors,FVPCameraRigSpawnParams Params) { return default; }
	public UObject SpawnCameraRigFromPoints(UObject WorldContextObject,FTransform RigTransform,TArray<FVector> Points,FVPCameraRigSpawnParams Params) { return default; }
	public UObject SpawnCameraRigFromSelectedActors(UObject WorldContextObject,FTransform RigTransform,FVPCameraRigSpawnParams Params) { return default; }
}
