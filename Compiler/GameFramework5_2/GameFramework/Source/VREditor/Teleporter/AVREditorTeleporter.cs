#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>VR Editor teleport manager and the visual representation of the teleport</summary>
[CppInclude("Teleporter/VREditorTeleporter.h")]
public partial class AVREditorTeleporter : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>Initializes the teleporter</summary>
	public  void Init(UVREditorMode InMode) {}
	///<summary>Shuts down the teleporter</summary>
	public  void Shutdown() {}
	///<summary>Whether we are currently aiming to teleport.</summary>
	public  bool IsAiming() { return default; }
	///<summary>IsTeleporting</summary>
	public  bool IsTeleporting() { return default; }
	///<summary>GetVRMode</summary>
	public  UVREditorMode GetVRMode() { return default; }
	///<summary>Start teleporting, does a ray trace with the hand passed and calculates the locations for lerp movement in Teleport</summary>
	public  void StartTeleport() {}
	///<summary>Called when teleport is done for cleanup</summary>
	public  void TeleportDone() {}
	///<summary>Hide or show the teleporter visuals</summary>
	public  void SetVisibility(bool bVisible) {}
	///<summary>Sets the color for the teleporter visuals</summary>
	public  void SetColor(FLinearColor Color) {}
	///<summary>Get slide delta to push/pull or scale the teleporter</summary>
	public  float GetSlideDelta(UVREditorInteractor Interactor,bool Axis) { return default; }
	///<summary>Functions we call to handle teleporting in navigation mode</summary>
	public  void StartAiming(UViewportInteractor Interactor) {}
	///<summary>Cancel teleport aiming mode without doing the teleport</summary>
	public  void StopAiming() {}
	///<summary>Do and finalize teleport.</summary>
	public  void DoTeleport() {}
	///<summary>Get the actor we&#39;re currently trying to teleport with.</summary>
	public  UViewportInteractor GetInteractorTryingTeleport() { return default; }
	///<summary>The owning VR mode</summary>
	public UVREditorMode VRMode;
	///<summary>Visuals for the feet location of the teleporter with the same direction of the HMD yaw</summary>
	public UStaticMeshComponent TeleportDirectionMeshComponent;
	///<summary>Visuals for teleport HMD</summary>
	public UStaticMeshComponent HMDMeshComponent;
	///<summary>Visuals for teleport left motion controller</summary>
	public UStaticMeshComponent LeftMotionControllerMeshComponent;
	///<summary>Visuals for teleport right motion controller</summary>
	public UStaticMeshComponent RightMotionControllerMeshComponent;
	///<summary>Dynamic material for teleport visuals</summary>
	public UMaterialInstanceDynamic TeleportMID;
	///<summary>The interactor that started aiming to teleport</summary>
	public UViewportInteractor InteractorTryingTeleport;
}
