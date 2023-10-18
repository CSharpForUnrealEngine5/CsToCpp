namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Libraries/VPCameraBlueprintLibrary.h")]
public partial class UVPCameraBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>SpawnDollyTrackFromPoints</summary>
	public static ACameraRig_Rail SpawnDollyTrackFromPoints(UObject WorldContextObject,TArray<FTransform> Points,ESplinePointType InterpType/*=ESplinePointType.Linear*/) { return default; }
	///<summary>SpawnDollyTrackFromPointsSmooth</summary>
	public static ACameraRig_Rail SpawnDollyTrackFromPointsSmooth(UObject WorldContextObject,TArray<FTransform> Points,ESplinePointType InterpType/*=ESplinePointType.Linear*/) { return default; }
	///<summary>SpawnCameraRigFromActors</summary>
	public static ACameraRig_Rail SpawnCameraRigFromActors(UObject WorldContextObject,FTransform RigTransform,TArray<AActor> Actors,FVPCameraRigSpawnParams Params) { return default; }
	///<summary>SpawnCameraRigFromPoints</summary>
	public static ACameraRig_Rail SpawnCameraRigFromPoints(UObject WorldContextObject,FTransform RigTransform,TArray<FVector> Points,FVPCameraRigSpawnParams Params) { return default; }
	///<summary>SpawnCameraRigFromSelectedActors</summary>
	public static ACameraRig_Rail SpawnCameraRigFromSelectedActors(UObject WorldContextObject,FTransform RigTransform,FVPCameraRigSpawnParams Params) { return default; }
}
