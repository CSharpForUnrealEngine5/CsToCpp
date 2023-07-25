#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ViewportWorldInteraction.h")]
public partial class UViewportWorldInteraction : UEditorWorldExtension {
// ViewportWorldInteraction
	public void AddInteractor(UObject Interactor) {}
	public void RemoveInteractor(UObject Interactor) {}
	public void AddActorToExcludeFromHitTests(UObject ActorToExcludeFromHitTests) {}
	public FTransform GetRoomTransform() { return default; }
	public FTransform GetRoomSpaceHeadTransform() { return default; }
	public FTransform GetHeadTransform() { return default; }
	public void SetHeadTransform(FTransform NewHeadTransform) {}
	public void SetRoomTransformForNextFrame(FTransform NewRoomTransform) {}
	public float GetWorldScaleFactor() { return default; }
	public void SetWorldToMetersScale(float NewWorldToMetersScale,bool bCompensateRoomWorldScale/*=false*/) {}
	public UObject GetTransformGizmoActor() { return default; }
	public TArray<UObject> GetInteractors() { return default; }
	public TArray<UViewportInteractor> Interactors;
	public UViewportTransformer ViewportTransformer;
	public ABaseTransformGizmo TransformGizmoActor;
	public AActor SnapGridActor;
	public UStaticMeshComponent SnapGridMeshComponent;
	public UMaterialInstanceDynamic SnapGridMID;
	public UMouseCursorInteractor DefaultMouseCursorInteractor;
	public TArray<TWeakObjectPtr<AActor>> ActorsToExcludeFromHitTest;
	public UViewportInteractionAssetContainer AssetContainer;
}
