#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("XRCreativeAvatar.h")]
public partial class AXRCreativeAvatar : APawn {
	///<summary>GetHeadTransform</summary>
	public  FTransform GetHeadTransform() { return default; }
	///<summary>GetHeadTransformRoomSpace</summary>
	public  FTransform GetHeadTransformRoomSpace() { return default; }
	///<summary>SetComponentTickInEditor</summary>
	public  void SetComponentTickInEditor(UActorComponent Component,bool bShouldTickInEditor) {}
	///<summary>Registers the given object with the Avatar&#39;s Input Component</summary>
	public  void RegisterObjectForInput(UObject Object) {}
	///<summary>Unregisters the given object with the Avatar&#39;s Input Component</summary>
	public  void UnregisterObjectForInput(UObject Object) {}
	///<summary>Adds an explicitly provided Input Mapping Context to the input system</summary>
	public  void AddInputMappingContext(UInputMappingContext Context,int Priority) {}
	///<summary>Removes an explicitly provided Input Mapping Context to the input system</summary>
	public  void RemoveInputMappingContext(UInputMappingContext Context) {}
	///<summary>Play haptic feedback asset on a given hand - only left and right supported</summary>
	public  void PlayHapticEffect(UHapticFeedbackEffect_Base HapticEffect,int ControllerID,EControllerHand Hand,float Scale,bool bLoop) {}
	///<summary>Instantly stop a haptic feedback for a given hand - only left and right supported</summary>
	public  void StopHapticEffect(EControllerHand Hand,int ControllerID) {}
	///<summary>Includes special handling to not dirty editor worlds.</summary>
	public  AActor SpawnTransientActor(UClass ActorClass,string ActorName) { return default; }
	///<summary>OpenLevelSequence</summary>
	public  ALevelSequenceActor OpenLevelSequence(ULevelSequence LevelSequence) { return default; }
	///<summary>LeftController</summary>
	public UMotionControllerComponent LeftController;
	///<summary>LeftControllerAim</summary>
	public UMotionControllerComponent LeftControllerAim;
	///<summary>LeftControllerPointer</summary>
	public UXRCreativePointerComponent LeftControllerPointer;
	///<summary>RightController</summary>
	public UMotionControllerComponent RightController;
	///<summary>RightControllerAim</summary>
	public UMotionControllerComponent RightControllerAim;
	///<summary>RightControllerPointer</summary>
	public UXRCreativePointerComponent RightControllerPointer;
	///<summary>LeftControllerModel</summary>
	public USkeletalMeshComponent LeftControllerModel;
	///<summary>RightControllerModel</summary>
	public USkeletalMeshComponent RightControllerModel;
	///<summary>MenuWidget</summary>
	public UWidgetComponent MenuWidget;
	///<summary>WidgetInteraction</summary>
	public UWidgetInteractionComponent WidgetInteraction;
	///<summary>ToolsComponent</summary>
	public UXRCreativeITFComponent ToolsComponent;
	///<summary>Toolset</summary>
	public UXRCreativeToolset Toolset;
	///<summary>Tools</summary>
	public TArray<UXRCreativeTool> Tools;
}
