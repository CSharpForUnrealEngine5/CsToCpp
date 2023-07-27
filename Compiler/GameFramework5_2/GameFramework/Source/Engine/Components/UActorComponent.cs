#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/ActorComponent.h")]
///<summary>ActorComponent is the base class for components that define reusable behavior that can be added to different types of Actors.</summary>
public partial class UActorComponent : UObject {
// ActorComponent
	public FActorComponentTickFunction PrimaryComponentTick;
	public TArray<string> ComponentTags;
	public TArray<UAssetUserData> AssetUserData;
	public int UCSSerializationIndex;
	public bool bNetAddressable;
	public bool bReplicateUsingRegisteredSubObjectList;
	public bool bReplicates;
	public bool bCreatedByConstructionScript_DEPRECATED;
	public bool bInstanceComponent_DEPRECATED;
	public bool bAutoActivate;
	public bool bIsActive;
	public bool bEditableWhenInherited;
	public bool bCanEverAffectNavigation;
	public bool bIsEditorOnly;
	public bool bIsVisualizationComponent;
	public bool bNeedsUCSSerializationIndexEvaluted;
	public EComponentCreationMethod CreationMethod;
	public  bool IsBeingDestroyed() { return default; }
	public  void OnRep_IsActive() {}
	public  AActor GetOwner() { return default; }
	public  bool ComponentHasTag(string Tag) { return default; }
	public FActorComponentActivatedSignature OnComponentActivated;
	public FActorComponentDeactivateSignature OnComponentDeactivated;
	public TArray<FSimpleMemberReference> UCSModifiedProperties_DEPRECATED;
	public  void Activate(bool bReset/*=false*/) {}
	public  void Deactivate() {}
	public  void SetActive(bool bNewActive,bool bReset/*=false*/) {}
	public  void ToggleActive() {}
	public  bool IsActive() { return default; }
	public  void SetAutoActivate(bool bNewAutoActivate) {}
	public  void SetTickableWhenPaused(bool bTickableWhenPaused) {}
	public  void SetIsReplicated(bool ShouldReplicate) {}
	public  void ReceiveBeginPlay() {}
	public  void ReceiveEndPlay(EEndPlayReason EndPlayReason) {}
	public  void SetComponentTickEnabled(bool bEnabled) {}
	public  bool IsComponentTickEnabled() { return default; }
	public  void SetComponentTickInterval(float TickInterval) {}
	public  void SetComponentTickIntervalAndCooldown(float TickInterval) {}
	public  float GetComponentTickInterval() { return default; }
	public  void K2_DestroyComponent(UObject Object) {}
	public  void SetTickGroup(ETickingGroup NewTickGroup) {}
	public  void AddTickPrerequisiteActor(AActor PrerequisiteActor) {}
	public  void AddTickPrerequisiteComponent(UActorComponent PrerequisiteComponent) {}
	public  void RemoveTickPrerequisiteActor(AActor PrerequisiteActor) {}
	public  void RemoveTickPrerequisiteComponent(UActorComponent PrerequisiteComponent) {}
	public  void ReceiveTick(float DeltaSeconds) {}
	public  void ReceiveAsyncPhysicsTick(float DeltaSeconds,float SimSeconds) {}
}
