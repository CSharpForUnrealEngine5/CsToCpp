#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MrcGarbageMatteCaptureComponent.h")]
public partial class AMrcGarbageMatteActor : AActor {
// MrcGarbageMatteActor
	public void ApplyCalibrationData(TArray<FMrcGarbageMatteSaveData> GarbageMatteData) {}
	public UObject AddNewGabageMatte(FMrcGarbageMatteSaveData GarbageMatteData) { return default; }
	public UObject CreateGarbageMatte(FMrcGarbageMatteSaveData GarbageMatteData) { return default; }
	public void GetGarbageMatteData(TArray<FMrcGarbageMatteSaveData> GarbageMatteDataOut) {}
	public UStaticMesh GarbageMatteMesh;
	public UMaterial GarbageMatteMaterial;
	public TArray<UPrimitiveComponent> GarbageMattes;
}
