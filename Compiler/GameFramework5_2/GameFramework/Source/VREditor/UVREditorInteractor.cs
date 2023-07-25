#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VREditorInteractor.h")]
///<summary>VREditor default interactor</summary>
public partial class UVREditorInteractor : UViewportInteractor {
// VREditorInteractor
	public void Init(UObject InVRMode) {}
	public void SetupComponent(UObject OwningActor) {}
	public string GetHMDDeviceType() { return default; }
	public UObject GetMotionControllerComponent() { return default; }
	public void SetControllerHandSide(string InControllerHandSide) {}
	public string GetControllerHandSide() { return default; }
	public float GetSlideDelta() { return default; }
	public void SetForceShowLaser(bool bInForceShow) {}
	public bool IsTouchingTrackpad() { return default; }
	public FVector2D GetTrackpadPosition() { return default; }
	public FVector2D GetLastTrackpadPosition() { return default; }
	public FVector GetLaserStart() { return default; }
	public FVector GetLaserEnd() { return default; }
	public void SetForceLaserColor(FLinearColor InColor) {}
	public UObject GetTeleportActor() { return default; }
	public EControllerHand GetControllerSide() { return default; }
	public EControllerType GetControllerType() { return default; }
	public void SetControllerType(EControllerType InControllerType) {}
	public bool TryOverrideControllerType(EControllerType InControllerType) { return default; }
	public bool IsHoveringOverUI() { return default; }
	public bool IsClickingOnUI() { return default; }
	public float GetSelectAndMoveTriggerValue() { return default; }
	public void ReplaceHandMeshComponent(UObject NewMesh,FVector MeshScale/*=new FVector(1.0f,1.0f,1.0f)*/) {}
	public bool bIsUndoRedoSwipeEnabled;
	public UMotionControllerComponent MotionControllerComponent;
	public UMotionControllerComponent LaserMotionControllerComponent;
	public UStaticMeshComponent HandMeshComponent;
	public void UpdateHandMeshRelativeTransform() {}
	public USplineComponent LaserSplineComponent;
	public TArray<USplineMeshComponent> LaserSplineMeshComponents;
	public UMaterialInstanceDynamic LaserPointerMID;
	public UMaterialInstanceDynamic TranslucentLaserPointerMID;
	public UStaticMeshComponent HoverMeshComponent;
	public UPointLightComponent HoverPointLightComponent;
	public UMaterialInstanceDynamic HandMeshMID;
	public AActor OwningAvatar;
	public EControllerType ControllerType;
	public EControllerType OverrideControllerType;
	public string ControllerMotionSource;
	public UVREditorMode VRMode;
}
