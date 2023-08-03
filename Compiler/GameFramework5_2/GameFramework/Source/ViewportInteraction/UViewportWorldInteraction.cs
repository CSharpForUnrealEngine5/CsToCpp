#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ViewportWorldInteraction.h")]
public partial class UViewportWorldInteraction : UEditorWorldExtension {
	public static UClass StaticClass() {return default;}
	///<summary>Adds interactor to the worldinteraction</summary>
	public  void AddInteractor(UViewportInteractor Interactor) {}
	///<summary>Removes interactor from the worldinteraction and removes the interactor from its paired interactor if any</summary>
	public  void RemoveInteractor(UViewportInteractor Interactor) {}
	///<summary>Adds an actor to the list of actors to never allow an interactor to hit in the scene.  No selection.  No hover.</summary>
	public  void AddActorToExcludeFromHitTests(AActor ActorToExcludeFromHitTests) {}
	///<summary>Gets the world space transform of the calibrated VR room origin.  When using a seated VR device, this will feel like the</summary>
	public  FTransform GetRoomTransform() { return default; }
	///<summary>Gets the transform of the viewport / user&#39;s HMD in room space</summary>
	public  FTransform GetRoomSpaceHeadTransform() { return default; }
	///<summary>Gets the transform of the viewport / user&#39;s HMD in world space</summary>
	public  FTransform GetHeadTransform() { return default; }
	///<summary>Sets a new transform for the room so that the HMD is aligned to the new transform.</summary>
	public  void SetHeadTransform(FTransform NewHeadTransform) {}
	///<summary>SetRoomTransformForNextFrame</summary>
	public  void SetRoomTransformForNextFrame(FTransform NewRoomTransform) {}
	///<summary>Gets the world scale factor, which can be multiplied by a scale vector to convert to room space</summary>
	public  float GetWorldScaleFactor() { return default; }
	///<summary>Sets GNewWorldToMetersScale</summary>
	public  void SetWorldToMetersScale(float NewWorldToMetersScale,bool bCompensateRoomWorldScale/*=false*/) {}
	///<summary>Gets the transform gizmo actor, or returns null if we currently don&#39;t have one</summary>
	public  ABaseTransformGizmo GetTransformGizmoActor() { return default; }
	///<summary>Gets all the interactors</summary>
	public  TArray<UViewportInteractor> GetInteractors() { return default; }
	///<summary>All the interactors registered to modify the world</summary>
	public TArray<UViewportInteractor> Interactors;
	///<summary>The active system being used to transform objects</summary>
	public UViewportTransformer ViewportTransformer;
	///<summary>Transform gizmo actor, for manipulating selected actor(s)</summary>
	public ABaseTransformGizmo TransformGizmoActor;
	///<summary>Actor for the snap grid</summary>
	public AActor SnapGridActor;
	///<summary>The plane mesh we use to draw a snap grid under selected objects</summary>
	public UStaticMeshComponent SnapGridMeshComponent;
	///<summary>MID for the snap grid, so we can update snap values on the fly</summary>
	public UMaterialInstanceDynamic SnapGridMID;
	///<summary>The default mouse cursor interactor, activated on demand</summary>
	public UMouseCursorInteractor DefaultMouseCursorInteractor;
	///<summary>List of actors which should never be hit by an interactor, such as the &#39;avatar mesh actor&#39; in VR</summary>
	public TArray<TWeakObjectPtr<AActor>> ActorsToExcludeFromHitTest;
	///<summary>Container of assets</summary>
	public UViewportInteractionAssetContainer AssetContainer;
}
