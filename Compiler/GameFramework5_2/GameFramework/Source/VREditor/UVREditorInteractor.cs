namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>VREditor default interactor</summary>
[CppInclude("VREditorInteractor.h")]
public partial class UVREditorInteractor : UViewportInteractor {
	public static UClass StaticClass() {return default;}
	///<summary>Initialize default values</summary>
	public void Init(UVREditorMode InVRMode) {}
	///<summary>Sets up all components</summary>
	public void SetupComponent(AActor OwningActor) {}
	///<summary>@return Returns the type of HMD we&#39;re dealing with</summary>
	public FName GetHMDDeviceType() { return default; }
	///<summary>Get the motioncontroller component of this interactor</summary>
	public UMotionControllerComponent GetMotionControllerComponent() { return default; }
	///<summary>Sets the EControllerHand for this motioncontroller</summary>
	public void SetControllerHandSide(FName InControllerHandSide) {}
	///<summary>Sets the EControllerHand for this motioncontroller</summary>
	public FName GetControllerHandSide() { return default; }
	///<summary>Returns the slide delta for pushing and pulling objects. Needs to be implemented by derived classes (e.g. touchpad for vive controller or scrollweel for mouse )</summary>
	public float GetSlideDelta() { return default; }
	///<summary>Set if we want to force to show the laser</summary>
	public void SetForceShowLaser(bool bInForceShow) {}
	///<summary>Check if the touchpad is currently touched</summary>
	public bool IsTouchingTrackpad() { return default; }
	///<summary>Get the current position of the trackpad or analog stick</summary>
	public FVector2D GetTrackpadPosition() { return default; }
	///<summary>Get the last position of the trackpad or analog stick</summary>
	public FVector2D GetLastTrackpadPosition() { return default; }
	///<summary>Getters and setters</summary>
	public FVector GetLaserStart() { return default; }
	///<summary>GetLaserEnd</summary>
	public FVector GetLaserEnd() { return default; }
	///<summary>Next frame this will be used as color for the laser</summary>
	public void SetForceLaserColor(FLinearColor InColor) {}
	///<summary>GetTeleportActor</summary>
	public AVREditorTeleporter GetTeleportActor() { return default; }
	///<summary>Get the side of the controller</summary>
	public EControllerHand GetControllerSide() { return default; }
	///<summary>Returns what controller type this is for asymmetric control schemes</summary>
	public EControllerType GetControllerType() { return default; }
	///<summary>Set what controller type this is for asymmetric control schemes</summary>
	public void SetControllerType(EControllerType InControllerType) {}
	///<summary>Temporary set what controller type this is for asymmetric control schemes.</summary>
	public bool TryOverrideControllerType(EControllerType InControllerType) { return default; }
	///<summary>Gets if this interactor is hovering over UI</summary>
	public bool IsHoveringOverUI() { return default; }
	///<summary>Gets if the interactor is clicking on any UI</summary>
	public bool IsClickingOnUI() { return default; }
	///<summary>Gets the trigger value</summary>
	public float GetSelectAndMoveTriggerValue() { return default; }
	///<summary>Replace the default VR controller mesh with a custom one.</summary>
	public void ReplaceHandMeshComponent(UStaticMesh NewMesh,FVector MeshScale/*=new FVector(1.0f,1.0f,1.0f)*/) {}
	///<summary>Whether swiping left/right on touchpad/joystick triggers undo/redo</summary>
	public bool bIsUndoRedoSwipeEnabled;
	///<summary>Motion controller component which handles late-frame transform updates of all parented sub-components</summary>
	public UMotionControllerComponent MotionControllerComponent;
	///<summary>Separate motion controller component set to the &quot;aim&quot; pose motion source, used for the laser pointer.</summary>
	public UMotionControllerComponent LaserMotionControllerComponent;
	///<summary>Access to the current handmesh. Use ReplaceHandMeshComponent() to update the entire StaticMeshComponent.</summary>
	public UStaticMeshComponent HandMeshComponent;
	///<summary>UpdateHandMeshRelativeTransform</summary>
	public void UpdateHandMeshRelativeTransform() {}
	///<summary>Spline for this hand&#39;s laser pointer</summary>
	public USplineComponent LaserSplineComponent;
	///<summary>Spline meshes for curved laser</summary>
	public TArray<USplineMeshComponent> LaserSplineMeshComponents;
	///<summary>MID for laser pointer material (opaque parts)</summary>
	public UMaterialInstanceDynamic LaserPointerMID;
	///<summary>MID for laser pointer material (translucent parts)</summary>
	public UMaterialInstanceDynamic TranslucentLaserPointerMID;
	///<summary>Hover impact indicator mesh</summary>
	public UStaticMeshComponent HoverMeshComponent;
	///<summary>Hover point light</summary>
	public UPointLightComponent HoverPointLightComponent;
	///<summary>MID for hand mesh</summary>
	public UMaterialInstanceDynamic HandMeshMID;
	///<summary>Avatar actor that we&#39;re attached to. Cached so that we can change the HandMeshComponent via BP at runtime.</summary>
	public AActor OwningAvatar;
	///<summary>For asymmetrical systems - what type of controller this is</summary>
	public EControllerType ControllerType;
	///<summary>What was our previous controller type</summary>
	public EControllerType OverrideControllerType;
	///<summary>Right or left hand</summary>
	public FName ControllerMotionSource;
	///<summary>The mode that owns this interactor</summary>
	public UVREditorMode VRMode;
}
