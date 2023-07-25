#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("XRCreativeAvatar.h")]
public partial class AXRCreativeAvatar : APawn {
// XRCreativeAvatar
	public FTransform GetHeadTransform() { return default; }
	public FTransform GetHeadTransformRoomSpace() { return default; }
	public void SetComponentTickInEditor(UObject Component,bool bShouldTickInEditor) {}
	public void RegisterObjectForInput(UObject Object) {}
	public void UnregisterObjectForInput(UObject Object) {}
	public void AddInputMappingContext(UObject Context,int Priority) {}
	public void RemoveInputMappingContext(UObject Context) {}
	public void PlayHapticEffect(UObject HapticEffect,int ControllerID,EControllerHand Hand,float Scale,bool bLoop) {}
	public void StopHapticEffect(EControllerHand Hand,int ControllerID) {}
	public UObject SpawnTransientActor(UClass ActorClass,string ActorName) { return default; }
	public UObject OpenLevelSequence(UObject LevelSequence) { return default; }
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
