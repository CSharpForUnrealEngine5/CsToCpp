#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/DebugCameraController.h")]
///<summary>Camera controller that allows you to fly around a level mostly unrestricted by normal movement rules.</summary>
public partial class ADebugCameraController : APlayerController {
// DebugCameraController
	public bool bShowSelectedInfo;
	public bool bIsFrozenRendering;
	public bool bIsOrbitingSelectedActor;
	public bool bOrbitPivotUseCenter;
	public bool bEnableBufferVisualization;
	public bool bEnableBufferVisualizationFullMode;
	public bool bIsBufferVisualizationInputSetup;
	public bool bLastDisplayEnabled;
	public UDrawFrustumComponent DrawFrustum;
	public  void ShowDebugSelectedInfo() {}
	public  void ToggleDisplay() {}
	public TWeakObjectPtr<AActor> SelectedActor;
	public  AActor GetSelectedActor() { return default; }
	public TWeakObjectPtr<UPrimitiveComponent> SelectedComponent;
	public FHitResult SelectedHitPoint;
	public APlayerController OriginalControllerRef;
	public UPlayer OriginalPlayer;
	public float SpeedScale;
	public  void SetPawnMovementSpeedScale(float NewSpeedScale) {}
	public float InitialMaxSpeed;
	public float InitialAccel;
	public float InitialDecel;
	public  void ReceiveOnActivate(APlayerController OriginalPC) {}
	public  void ReceiveOnDeactivate(APlayerController RestoredPC) {}
	public  void ReceiveOnActorSelected(AActor NewSelectedActor,FVector SelectHitLocation,FVector SelectHitNormal,FHitResult Hit) {}
}
