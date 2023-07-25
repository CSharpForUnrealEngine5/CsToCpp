#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MrcGarbageMatteCaptureComponent.h")]
public partial class UMrcGarbageMatteCaptureComponent : USceneCaptureComponent2D {
// MrcGarbageMatteCaptureComponent
	public void SetTrackingOrigin(UObject TrackingOrigin) {}
	public void ApplyCalibrationData(UObject ConfigData) {}
	public void SetGarbageMatteActor(UObject NewActor) {}
	public void GetGarbageMatteData(TArray<FMrcGarbageMatteSaveData> GarbageMatteDataOut) {}
	public void SetFocalDriver(object /*InFocalDriver*/ InFocalDriver) {}
	public UObject SpawnNewGarbageMatteActor(UObject TrackingOrigin) { return default; }
	public UClass GarbageMatteActorClass;
	public AMrcGarbageMatteActor GarbageMatteActor;
	public TArray<AMrcGarbageMatteActor> SpawnedActors;
	public TWeakObjectPtr<USceneComponent> TrackingOriginPtr;
	public object /*FocalDriver*/ FocalDriver;
}
