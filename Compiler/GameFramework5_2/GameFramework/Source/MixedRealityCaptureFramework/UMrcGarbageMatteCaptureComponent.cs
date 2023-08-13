namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MrcGarbageMatteCaptureComponent.h")]
public partial class UMrcGarbageMatteCaptureComponent : USceneCaptureComponent2D {
	public static UClass StaticClass() {return default;}
	///<summary>SetTrackingOrigin</summary>
	public void SetTrackingOrigin(USceneComponent TrackingOrigin) {}
	///<summary>ApplyCalibrationData</summary>
	public void ApplyCalibrationData(UMrcCalibrationData ConfigData) {}
	///<summary>SetGarbageMatteActor</summary>
	public void SetGarbageMatteActor(AMrcGarbageMatteActor NewActor) {}
	///<summary>GetGarbageMatteData</summary>
	public void GetGarbageMatteData(TArray<FMrcGarbageMatteSaveData> GarbageMatteDataOut) {}
	///<summary>SetFocalDriver</summary>
	public void SetFocalDriver(object /*InFocalDriver*/ InFocalDriver) {}
	///<summary>SpawnNewGarbageMatteActor</summary>
	public AMrcGarbageMatteActor SpawnNewGarbageMatteActor(USceneComponent TrackingOrigin) { return default; }
	///<summary>GarbageMatteActorClass</summary>
	public UClass GarbageMatteActorClass;
	///<summary>GarbageMatteActor</summary>
	public AMrcGarbageMatteActor GarbageMatteActor;
	///<summary>SpawnedActors</summary>
	public TArray<AMrcGarbageMatteActor> SpawnedActors;
	///<summary>TrackingOriginPtr</summary>
	public TWeakObjectPtr<USceneComponent> TrackingOriginPtr;
	///<summary>FocalDriver</summary>
	public object /*FocalDriver*/ FocalDriver;
}
