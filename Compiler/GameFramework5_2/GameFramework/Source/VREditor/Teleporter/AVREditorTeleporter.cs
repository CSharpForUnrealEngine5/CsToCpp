#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Teleporter/VREditorTeleporter.h")]
///<summary>VR Editor teleport manager and the visual representation of the teleport</summary>
public partial class AVREditorTeleporter : AActor {
// VREditorTeleporter
	public  void Init(UVREditorMode InMode) {}
	public  void Shutdown() {}
	public  bool IsAiming() { return default; }
	public  bool IsTeleporting() { return default; }
	public  UVREditorMode GetVRMode() { return default; }
	public  void StartTeleport() {}
	public  void TeleportDone() {}
	public  void SetVisibility(bool bVisible) {}
	public  void SetColor(FLinearColor Color) {}
	public  float GetSlideDelta(UVREditorInteractor Interactor,bool Axis) { return default; }
	public  void StartAiming(UViewportInteractor Interactor) {}
	public  void StopAiming() {}
	public  void DoTeleport() {}
	public  UViewportInteractor GetInteractorTryingTeleport() { return default; }
	public UVREditorMode VRMode;
	public UStaticMeshComponent TeleportDirectionMeshComponent;
	public UStaticMeshComponent HMDMeshComponent;
	public UStaticMeshComponent LeftMotionControllerMeshComponent;
	public UStaticMeshComponent RightMotionControllerMeshComponent;
	public UMaterialInstanceDynamic TeleportMID;
	public UViewportInteractor InteractorTryingTeleport;
}
