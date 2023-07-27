#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("XRCreativeAvatar.h")]
public partial class AXRCreativeAvatar : APawn {
// XRCreativeAvatar
	public  FTransform GetHeadTransform() { return default; }
	public  FTransform GetHeadTransformRoomSpace() { return default; }
	public  void SetComponentTickInEditor(UActorComponent Component,bool bShouldTickInEditor) {}
	public  void RegisterObjectForInput(UObject Object) {}
	public  void UnregisterObjectForInput(UObject Object) {}
	public  void AddInputMappingContext(UInputMappingContext Context,int Priority) {}
	public  void RemoveInputMappingContext(UInputMappingContext Context) {}
	public  void PlayHapticEffect(UHapticFeedbackEffect_Base HapticEffect,int ControllerID,EControllerHand Hand,float Scale,bool bLoop) {}
	public  void StopHapticEffect(EControllerHand Hand,int ControllerID) {}
	public  AActor SpawnTransientActor(UClass ActorClass,string ActorName) { return default; }
	public  ALevelSequenceActor OpenLevelSequence(ULevelSequence LevelSequence) { return default; }
	public UMotionControllerComponent LeftController;
	public UMotionControllerComponent LeftControllerAim;
	public UXRCreativePointerComponent LeftControllerPointer;
	public UMotionControllerComponent RightController;
	public UMotionControllerComponent RightControllerAim;
	public UXRCreativePointerComponent RightControllerPointer;
	public USkeletalMeshComponent LeftControllerModel;
	public USkeletalMeshComponent RightControllerModel;
	public UWidgetComponent MenuWidget;
	public UWidgetInteractionComponent WidgetInteraction;
	public UXRCreativeITFComponent ToolsComponent;
	public UXRCreativeToolset Toolset;
	public TArray<UXRCreativeTool> Tools;
}
