#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MotionControllerComponent.h")]
public partial class UMotionControllerComponent : UPrimitiveComponent {
// MotionControllerComponent
	public int PlayerIndex;
	public EControllerHand Hand_DEPRECATED;
	public string MotionSource;
	public bool bDisableLowLatencyUpdate;
	public ETrackingStatus CurrentTrackingStatus;
	public bool bDisplayDeviceModel;
	public string DisplayModelSource;
	public UStaticMesh CustomDisplayMesh;
	public TArray<UMaterialInterface> DisplayMeshMaterialOverrides;
	public  void SetShowDeviceModel(bool bShowControllerModel) {}
	public  void SetDisplayModelSource(string NewDisplayModelSource) {}
	public  void SetCustomDisplayMesh(UStaticMesh NewDisplayMesh) {}
	public  bool IsTracked() { return default; }
	public  void SetTrackingSource(EControllerHand NewSource) {}
	public  EControllerHand GetTrackingSource() { return default; }
	public  void SetTrackingMotionSource(string NewSource) {}
	public  void SetAssociatedPlayerIndex(int NewPlayer) {}
	public UPrimitiveComponent DisplayComponent;
	public  void OnMotionControllerUpdated() {}
	public  float GetParameterValue(string InName,bool bValueFound) { return default; }
	public  FVector GetHandJointPosition(int jointIndex,bool bValueFound) { return default; }
}
