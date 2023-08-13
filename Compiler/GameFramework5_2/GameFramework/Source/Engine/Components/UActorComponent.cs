namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>ActorComponent is the base class for components that define reusable behavior that can be added to different types of Actors.</summary>
[CppInclude("Components/ActorComponent.h")]
public partial class UActorComponent : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Main tick function for the Component</summary>
	public FActorComponentTickFunction PrimaryComponentTick;
	///<summary>Array of tags that can be used for grouping and categorizing. Can also be accessed from scripting.</summary>
	public TArray<string> ComponentTags;
	///<summary>Array of user data stored with the component</summary>
	public TArray<UAssetUserData> AssetUserData;
	///<summary>Populated when the component is created and tracks the often used order of creation on a per archetype/per actor basis</summary>
	public int UCSSerializationIndex;
	///<summary>Is this component safe to ID over the network by name?</summary>
	public bool bNetAddressable;
	///<summary>When true the replication system will only replicate the registered subobjects list</summary>
	public bool bReplicateUsingRegisteredSubObjectList;
	///<summary>Is this component currently replicating? Should the network code consider it for replication? Owning Actor must be replicating first!</summary>
	public bool bReplicates;
	///<summary>@deprecated Replaced by CreationMethod</summary>
	public bool bCreatedByConstructionScript_DEPRECATED;
	///<summary>@deprecated Replaced by CreationMethod</summary>
	public bool bInstanceComponent_DEPRECATED;
	///<summary>Whether the component is activated at creation or must be explicitly activated.</summary>
	public bool bAutoActivate;
	///<summary>Whether the component is currently active.</summary>
	public bool bIsActive;
	///<summary>True if this component can be modified when it was inherited from a parent actor class</summary>
	public bool bEditableWhenInherited;
	///<summary>Whether this component can potentially influence navigation</summary>
	public bool bCanEverAffectNavigation;
	///<summary>If true, the component will be excluded from non-editor builds</summary>
	public bool bIsEditorOnly;
	///<summary>True if this component is only used for visualization, usually a sprite or text</summary>
	public bool bIsVisualizationComponent;
	///<summary>Marks this component pending kill once PostLoad occurs. Used to clean up old native default subobjects that were removed from code</summary>
	public bool bNeedsUCSSerializationIndexEvaluted;
	///<summary>Describes how a component instance will be created</summary>
	public EComponentCreationMethod CreationMethod;
	///<summary>Returns whether the component is in the process of being destroyed.</summary>
	public bool IsBeingDestroyed() { return default; }
	///<summary>Handles replication of active state, handles ticking by default but should be overridden as needed</summary>
	public virtual void OnRep_IsActive() {}
	///<summary>Follow the Outer chain to get the  AActor  that &#39;Owns&#39; this component</summary>
	public AActor GetOwner() { return default; }
	///<summary>See if this component contains the supplied tag</summary>
	public bool ComponentHasTag(string Tag) { return default; }
	///<summary>Called when the component has been activated, with parameter indicating if it was from a reset</summary>
	public FActorComponentActivatedSignature OnComponentActivated;
	///<summary>Called when the component has been deactivated</summary>
	public FActorComponentDeactivateSignature OnComponentDeactivated;
	///<summary>UCSModifiedProperties_DEPRECATED</summary>
	public TArray<FSimpleMemberReference> UCSModifiedProperties_DEPRECATED;
	///<summary>Activates the SceneComponent, should be overridden by native child classes.</summary>
	public virtual void Activate(bool bReset/*=false*/) {}
	///<summary>Deactivates the SceneComponent.</summary>
	public virtual void Deactivate() {}
	///<summary>Sets whether the component is active or not</summary>
	public virtual void SetActive(bool bNewActive,bool bReset/*=false*/) {}
	///<summary>Toggles the active state of the component</summary>
	public virtual void ToggleActive() {}
	///<summary>Returns whether the component is active or not</summary>
	public bool IsActive() { return default; }
	///<summary>Sets whether the component should be auto activate or not. Only safe during construction scripts.</summary>
	public virtual void SetAutoActivate(bool bNewAutoActivate) {}
	///<summary>Sets whether this component can tick when paused.</summary>
	public void SetTickableWhenPaused(bool bTickableWhenPaused) {}
	///<summary>Enable or disable replication. This is the equivalent of RemoteRole for actors (only a bool is required for components)</summary>
	public void SetIsReplicated(bool ShouldReplicate) {}
	///<summary>Blueprint implementable event for when the component is beginning play, called before its owning actor&#39;s BeginPlay</summary>
	public void ReceiveBeginPlay() {}
	///<summary>Blueprint implementable event for when the component ends play, generally via destruction or its Actor&#39;s EndPlay.</summary>
	public void ReceiveEndPlay(EEndPlayReason EndPlayReason) {}
	///<summary>Set this component&#39;s tick functions to be enabled or disabled. Only has an effect if the function is registered</summary>
	public virtual void SetComponentTickEnabled(bool bEnabled) {}
	///<summary>Returns whether this component has tick enabled or not</summary>
	public virtual bool IsComponentTickEnabled() { return default; }
	///<summary>Sets the tick interval for this component&#39;s primary tick function. Does not enable the tick interval. Takes effect on next tick.</summary>
	public void SetComponentTickInterval(float TickInterval) {}
	///<summary>Sets the tick interval for this component&#39;s primary tick function. Does not enable the tick interval. Takes effect imediately.</summary>
	public void SetComponentTickIntervalAndCooldown(float TickInterval) {}
	///<summary>Returns the tick interval for this component&#39;s primary tick function, which is the frequency in seconds at which it will be executed</summary>
	public float GetComponentTickInterval() { return default; }
	///<summary>Unregister and mark for pending kill a component.  This may not be used to destroy a component that is owned by an actor unless the owning actor is calling the function.</summary>
	public void K2_DestroyComponent(UObject Object) {}
	///<summary>Changes the ticking group for this component</summary>
	public void SetTickGroup(ETickingGroup NewTickGroup) {}
	///<summary>Make this component tick after PrerequisiteActor</summary>
	public virtual void AddTickPrerequisiteActor(AActor PrerequisiteActor) {}
	///<summary>Make this component tick after PrerequisiteComponent.</summary>
	public virtual void AddTickPrerequisiteComponent(UActorComponent PrerequisiteComponent) {}
	///<summary>Remove tick dependency on PrerequisiteActor.</summary>
	public virtual void RemoveTickPrerequisiteActor(AActor PrerequisiteActor) {}
	///<summary>Remove tick dependency on PrerequisiteComponent.</summary>
	public virtual void RemoveTickPrerequisiteComponent(UActorComponent PrerequisiteComponent) {}
	///<summary>Event called every frame if tick is enabled</summary>
	public void ReceiveTick(float DeltaSeconds) {}
	///<summary>Event called every async physics tick if bAsyncPhysicsTickEnabled is true</summary>
	public void ReceiveAsyncPhysicsTick(float DeltaSeconds,float SimSeconds) {}
}
