namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MrcGarbageMatteCaptureComponent.h")]
public partial class AMrcGarbageMatteActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>ApplyCalibrationData</summary>
	public void ApplyCalibrationData(TArray<FMrcGarbageMatteSaveData> GarbageMatteData) {}
	///<summary>AddNewGabageMatte</summary>
	public UPrimitiveComponent AddNewGabageMatte(FMrcGarbageMatteSaveData GarbageMatteData) { return default; }
	///<summary>CreateGarbageMatte</summary>
	public UPrimitiveComponent CreateGarbageMatte(FMrcGarbageMatteSaveData GarbageMatteData) { return default; }
	///<summary>GetGarbageMatteData</summary>
	public void GetGarbageMatteData(TArray<FMrcGarbageMatteSaveData> GarbageMatteDataOut) {}
	///<summary>GarbageMatteMesh</summary>
	public UStaticMesh GarbageMatteMesh;
	///<summary>GarbageMatteMaterial</summary>
	public UMaterial GarbageMatteMaterial;
	///<summary>GarbageMattes</summary>
	public TArray<UPrimitiveComponent> GarbageMattes;
}
