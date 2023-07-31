#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Actor is the base class for an Object that can be placed or spawned in a level.</summary>
[CppInclude("GameFramework/Actor.h")]
public partial class AActor : UObject {
	///<summary>Primary Actor tick function, which calls TickActor().</summary>
	public FActorTickFunction PrimaryActorTick;
	///<summary>If true, when the actor is spawned it will be sent to the client but receive no further replication updates from the server afterwards.</summary>
	public bool bNetTemporary;
	///<summary>If true, this actor is only relevant to its owner. If this flag is changed during play, all non-owner channels would need to be explicitly closed.</summary>
	public bool bOnlyRelevantToOwner;
	///<summary>Always relevant for network (overrides bOnlyRelevantToOwner).</summary>
	public bool bAlwaysRelevant;
	///<summary>Called on client when updated bReplicateMovement value is received for this actor.</summary>
	public  void OnRep_ReplicateMovement() {}
	///<summary>If true, replicate movement/location related properties.</summary>
	public bool bReplicateMovement;
	///<summary>bCallPreReplication</summary>
	public bool bCallPreReplication;
	///<summary>bCallPreReplicationForReplay</summary>
	public bool bCallPreReplicationForReplay;
	///<summary>Allows us to only see this Actor in the Editor, and not in the actual game.</summary>
	public bool bHidden;
	///<summary>bTearOff</summary>
	public bool bTearOff;
	///<summary>When set, indicates that external guarantees ensure that this actor&#39;s name is deterministic between server and client, and as such can be addressed by its full path</summary>
	public bool bForceNetAddressable;
	///<summary>Whether this actor belongs to a level instance which is currently being edited.</summary>
	public bool bIsInEditingLevelInstance;
	///<summary>Networking - Server - TearOff this actor to stop replication to clients. Will set bTearOff to true.</summary>
	public  void TearOff() {}
	///<summary>Whether we have already exchanged Role/RemoteRole on the client, as when removing then re-adding a streaming level.</summary>
	public bool bExchangedRoles;
	///<summary>This actor will be loaded on network clients during map load</summary>
	public bool bNetLoadOnClient;
	///<summary>If actor has valid Owner, call Owner&#39;s IsNetRelevantFor and GetNetPriority</summary>
	public bool bNetUseOwnerRelevancy;
	///<summary>If true, this actor will be replicated to network replays (default is true)</summary>
	public bool bRelevantForNetworkReplays;
	///<summary>If true, this actor&#39;s component&#39;s bounds will be included in the level&#39;s</summary>
	public bool bRelevantForLevelBounds;
	///<summary>If true, this actor will only be destroyed during scrubbing if the replay is set to a time before the actor existed.</summary>
	public bool bReplayRewindable;
	///<summary>Whether we allow this Actor to tick before it receives the BeginPlay event.</summary>
	public bool bAllowTickBeforeBeginPlay;
	///<summary>If true then destroy self when &quot;finished&quot;, meaning all relevant components report that they are done and no timelines or timers are in flight.</summary>
	public bool bAutoDestroyWhenFinished;
	///<summary>Whether this actor can take damage. Must be true for damage events (e.g. ReceiveDamage()) to be called.</summary>
	public bool bCanBeDamaged;
	///<summary>If true, all input on the stack below this actor will not be considered</summary>
	public bool bBlockInput;
	///<summary>This actor collides with the world when placing in the editor, even if RootComponent collision is disabled. Does not affect spawning, See: SpawnCollisionHandlingMethod</summary>
	public bool bCollideWhenPlacing;
	///<summary>If true, this actor should search for an owned camera component to view through when used as a view target.</summary>
	public bool bFindCameraComponentWhenViewTarget;
	///<summary>If true, this actor will generate overlap Begin/End events when spawned as part of level streaming, which includes initial level load.</summary>
	public bool bGenerateOverlapEventsDuringLevelStreaming;
	///<summary>Whether this actor should not be affected by world origin shifting.</summary>
	public bool bIgnoresOriginShifting;
	///<summary>Whether this actor should be considered or not during HLOD generation.</summary>
	public bool bEnableAutoLODGeneration;
	///<summary>Whether this actor is editor-only. Use with care, as if this actor is referenced by anything else that reference will be NULL in cooked builds</summary>
	public bool bIsEditorOnlyActor;
	///<summary>Indicates the actor was pulled through a seamless travel.</summary>
	public bool bActorSeamlessTraveled;
	///<summary>SetAutoDestroyWhenFinished</summary>
	public  void SetAutoDestroyWhenFinished(bool bVal) {}
	///<summary>If true, this actor will replicate to remote machines</summary>
	public bool bReplicates;
	///<summary>Called when owner changes, does nothing by default but can be overridden</summary>
	public  void OnRep_Owner() {}
	///<summary>If true, this actor can be put inside of a GC Cluster to improve Garbage Collection performance</summary>
	public bool bCanBeInCluster;
	///<summary>If false, the Blueprint ReceiveTick() event will be disabled on dedicated servers.</summary>
	public bool bAllowReceiveTickEventOnDedicatedServer;
	///<summary>When true the replication system will only replicate the registered subobjects and the replicated actor components list</summary>
	public bool bReplicateUsingRegisteredSubObjectList;
	///<summary>Enables any collision on this actor.</summary>
	public bool bActorEnableCollision;
	///<summary>Set when actor is about to be deleted. Needs to be a FProperty so it is included in transactions.</summary>
	public bool bActorIsBeingDestroyed;
	///<summary>Whether to use use the async physics tick with this actor.</summary>
	public bool bAsyncPhysicsTickEnabled;
	///<summary>Condition for calling UpdateOverlaps() to initialize overlap state when loaded in during level streaming.</summary>
	public EActorUpdateOverlapsMethod UpdateOverlapsMethodDuringLevelStreaming;
	///<summary>Default value taken from config file for this class when &#39;UseConfigDefault&#39; is chosen for</summary>
	public EActorUpdateOverlapsMethod DefaultUpdateOverlapsMethodDuringLevelStreaming;
	///<summary>Set whether this actor replicates to network clients. When this actor is spawned on the server it will be sent to clients as well.</summary>
	public  void SetReplicates(bool bInReplicates) {}
	///<summary>Set whether this actor&#39;s movement replicates to network clients.</summary>
	public  void SetReplicateMovement(bool bInReplicateMovement) {}
	///<summary>Returns how much control the local machine has over this actor.</summary>
	public  ENetRole GetLocalRole() { return default; }
	///<summary>Returns how much control the remote machine has over this actor.</summary>
	public  ENetRole GetRemoteRole() { return default; }
	///<summary>How long this Actor lives before dying, 0=forever. Note this is the INITIAL value and should not be modified once play has begun.</summary>
	public float InitialLifeSpan;
	///<summary>Allow each actor to run at a different time speed. The DeltaTime for a frame is multiplied by the global TimeDilation (in WorldSettings) and this CustomTimeDilation for this actor&#39;s tick.</summary>
	public float CustomTimeDilation;
	///<summary>Describes how much control the remote machine has over the actor.</summary>
	public ENetRole RemoteRole;
	///<summary>The RayTracingGroupId this actor and its components belong to. (For components that did not specify any)</summary>
	public int RayTracingGroupId;
	///<summary>GridPlacement_DEPRECATED</summary>
	public EActorGridPlacement GridPlacement_DEPRECATED;
	///<summary>Determine in which partition grid this actor will be placed in the partition (if the world is partitioned).</summary>
	public string RuntimeGrid;
	///<summary>Used for replicating attachment of this actor&#39;s RootComponent to another actor.</summary>
	public FRepAttachment AttachmentReplication;
	///<summary>Used for replication of our RootComponent&#39;s position and velocity</summary>
	public FRepMovement ReplicatedMovement;
	///<summary>Owner of this Actor, used primarily for replication (bNetUseOwnerRelevancy &amp; bOnlyRelevantToOwner) and visibility (PrimitiveComponent bOwnerNoSee and bOnlyOwnerSee)</summary>
	public AActor Owner;
	///<summary>Used to specify the net driver to replicate on (NAME_None || NAME_GameNetDriver is the default net driver)</summary>
	public string NetDriverName;
	///<summary>Called on client when updated AttachmentReplication value is received for this actor.</summary>
	public  void OnRep_AttachmentReplication() {}
	///<summary>Describes how much control the local machine has over the actor.</summary>
	public ENetRole Role;
	///<summary>Dormancy setting for actor to take itself off of the replication list without being destroyed on clients.</summary>
	public ENetDormancy NetDormancy;
	///<summary>Controls how to handle spawning this actor in a situation where it&#39;s colliding with something else. &quot;Default&quot; means AlwaysSpawn here.</summary>
	public ESpawnActorCollisionHandlingMethod SpawnCollisionHandlingMethod;
	///<summary>Automatically registers this actor to receive input from a player.</summary>
	public EAutoReceiveInput AutoReceiveInput;
	///<summary>The priority of this input component when pushed in to the stack.</summary>
	public int InputPriority;
	///<summary>Component that handles input for this actor, if input is enabled.</summary>
	public UInputComponent InputComponent;
	///<summary>Square of the max distance from the client&#39;s viewpoint that this actor is relevant and will be replicated.</summary>
	public float NetCullDistanceSquared;
	///<summary>Internal - used by UNetDriver</summary>
	public int NetTag;
	///<summary>How often (per second) this actor will be considered for replication, used to determine NetUpdateTime</summary>
	public float NetUpdateFrequency;
	///<summary>Used to determine what rate to throttle down to when replicated properties are changing infrequently</summary>
	public float MinNetUpdateFrequency;
	///<summary>Priority for this actor when checking for replication in a low bandwidth or saturated situation, higher priority means it is more likely to replicate</summary>
	public float NetPriority;
	///<summary>Pawn responsible for damage and other gameplay events caused by this actor.</summary>
	public APawn Instigator;
	///<summary>Called on clients when Instigator is replicated.</summary>
	public  void OnRep_Instigator() {}
	///<summary>Array of all Actors whose Owner is this actor, these are not necessarily spawned by UChildActorComponent</summary>
	public TArray<AActor> Children;
	///<summary>The component that defines the transform (location, rotation, scale) of this Actor in the world, all other components must be attached to this one somehow</summary>
	public USceneComponent RootComponent;
	///<summary>Local space pivot offset for the actor, only used in the editor</summary>
	public FVector PivotOffset;
	///<summary>Specify a RayTracingGroupId for this actors. Components with invalid RayTracingGroupId will inherit the actors.</summary>
	public  void SetRayTracingGroupId(int InRaytracingGroupId) {}
	///<summary>Return the RayTracingGroupId for this actor.</summary>
	public  int GetRayTracingGroupId() { return default; }
	///<summary>The UHLODLayer in which this actor should be included.</summary>
	public UHLODLayer HLODLayer;
	///<summary>Layers the actor belongs to.  This is outside of the editoronly data to allow hiding of LD-specified layers at runtime for profiling.</summary>
	public TArray<string> Layers;
	///<summary>@deprecated Use ParentComponent instead</summary>
	public TWeakObjectPtr<AActor> ParentComponentActor_DEPRECATED;
	///<summary>The UChildActorComponent that owns this Actor.</summary>
	public TWeakObjectPtr<UChildActorComponent> ParentComponent;
	///<summary>The GUID for this actor.</summary>
	public FGuid ActorGuid;
	///<summary>The GUID for this actor&#39;s content bundle.</summary>
	public FGuid ContentBundleGuid;
	///<summary>DataLayers the actor belongs to.</summary>
	public TArray<FActorDataLayer> DataLayers;
	///<summary>DataLayerAssets</summary>
	public TArray<UDataLayerAsset> DataLayerAssets;
	///<summary>The editor-only group this actor is a part of.</summary>
	public AActor GroupActor;
	///<summary>The scale to apply to any billboard components in editor builds (happens in any WITH_EDITOR build, including non-cooked games).</summary>
	public float SpriteScale;
	///<summary>Bitflag to represent which views this actor is hidden in, via per-view layer visibility.</summary>
	public ulong HiddenEditorViews;
	///<summary>The friendly name for this actor, displayed in the editor.  You should always use AActor::GetActorLabel() to access the actual label to display,</summary>
	public string ActorLabel;
	///<summary>The folder path of this actor in the world.</summary>
	public string FolderPath;
	///<summary>If the actor&#39;s level uses the actor folder objects feature, contains the actor folder unique identifier (invalid=root).</summary>
	public FGuid FolderGuid;
	///<summary>Whether this actor is hidden within the editor viewport.</summary>
	public bool bHiddenEd;
	///<summary>True if this actor is the preview actor dragged out of the content browser</summary>
	public bool bIsEditorPreviewActor;
	///<summary>Whether this actor is hidden by the layer browser.</summary>
	public bool bHiddenEdLayer;
	///<summary>Whether this actor is hidden by the level browser.</summary>
	public bool bHiddenEdLevel;
	///<summary>If true, prevents the actor from being moved in the editor viewport.</summary>
	public bool bLockLocation;
	///<summary>Is the actor label editable by the user?</summary>
	public bool bActorLabelEditable;
	///<summary>Whether the actor can be manipulated by editor operations.</summary>
	public bool bEditable;
	///<summary>Whether this actor should be listed in the scene outliner.</summary>
	public bool bListedInSceneOutliner;
	///<summary>Whether to cook additional data to speed up spawn events at runtime for any Blueprint classes based on this Actor. This option may slightly increase memory usage in a cooked build.</summary>
	public bool bOptimizeBPComponentData;
	///<summary>Whether the actor can be used as a PlayFromHere origin (OnPlayFromHere() will be called on that actor)</summary>
	public bool bCanPlayFromHere;
	///<summary>Determine if this actor is spatially loaded when placed in a partitioned world.</summary>
	public bool bIsSpatiallyLoaded;
	///<summary>Whether this actor is temporarily hidden within the editor; used for show/hide/etc functionality w/o dirtying the actor.</summary>
	public bool bHiddenEdTemporary;
	///<summary>bForceExternalActorLevelReferenceForPIE</summary>
	public bool bForceExternalActorLevelReferenceForPIE;
	///<summary>Array of tags that can be used for grouping and categorizing.</summary>
	public TArray<string> Tags;
	///<summary>Called when the actor is damaged in any way.</summary>
	public FTakeAnyDamageSignature OnTakeAnyDamage;
	///<summary>Called when the actor is damaged by point damage.</summary>
	public FTakePointDamageSignature OnTakePointDamage;
	///<summary>Called when the actor is damaged by radial damage.</summary>
	public FTakeRadialDamageSignature OnTakeRadialDamage;
	///<summary>Called when another actor begins to overlap this actor, for example a player walking into a trigger.</summary>
	public FActorBeginOverlapSignature OnActorBeginOverlap;
	///<summary>Called when another actor stops overlapping this actor.</summary>
	public FActorEndOverlapSignature OnActorEndOverlap;
	///<summary>Called when the mouse cursor is moved over this actor if mouse over events are enabled in the player controller.</summary>
	public FActorBeginCursorOverSignature OnBeginCursorOver;
	///<summary>Called when the mouse cursor is moved off this actor if mouse over events are enabled in the player controller.</summary>
	public FActorEndCursorOverSignature OnEndCursorOver;
	///<summary>Called when the left mouse button is clicked while the mouse is over this actor and click events are enabled in the player controller.</summary>
	public FActorOnClickedSignature OnClicked;
	///<summary>Called when the left mouse button is released while the mouse is over this actor and click events are enabled in the player controller.</summary>
	public FActorOnReleasedSignature OnReleased;
	///<summary>Called when a touch input is received over this actor when touch events are enabled in the player controller.</summary>
	public FActorOnInputTouchBeginSignature OnInputTouchBegin;
	///<summary>Called when a touch input is received over this component when touch events are enabled in the player controller.</summary>
	public FActorOnInputTouchEndSignature OnInputTouchEnd;
	///<summary>Called when a finger is moved over this actor when touch over events are enabled in the player controller.</summary>
	public FActorBeginTouchOverSignature OnInputTouchEnter;
	///<summary>Called when a finger is moved off this actor when touch over events are enabled in the player controller.</summary>
	public FActorEndTouchOverSignature OnInputTouchLeave;
	///<summary>Called when this Actor hits (or is hit by) something solid. This could happen due to things like Character movement, using Set Location with &#39;sweep&#39; enabled, or physics simulation.</summary>
	public FActorHitSignature OnActorHit;
	///<summary>Pushes this actor on to the stack of input being handled by a PlayerController.</summary>
	public  void EnableInput(APlayerController PlayerController) {}
	///<summary>Creates an input component from the input component passed in</summary>
	public  void CreateInputComponent(UClass InputComponentToCreate) {}
	///<summary>Removes this actor from the stack of input being handled by a PlayerController.</summary>
	public  void DisableInput(APlayerController PlayerController) {}
	///<summary>Gets the value of the input axis if input is enabled for this actor.</summary>
	public  float GetInputAxisValue(string InputAxisName) { return default; }
	///<summary>Gets the value of the input axis key if input is enabled for this actor.</summary>
	public  float GetInputAxisKeyValue(FKey InputAxisKey) { return default; }
	///<summary>Gets the value of the input axis key if input is enabled for this actor.</summary>
	public  FVector GetInputVectorAxisValue(FKey InputAxisKey) { return default; }
	///<summary>Returns the instigator for this actor, or nullptr if there is none.</summary>
	public  APawn GetInstigator() { return default; }
	///<summary>Returns the instigator&#39;s controller for this actor, or nullptr if there is none.</summary>
	public  AController GetInstigatorController() { return default; }
	///<summary>Get the actor-to-world transform.</summary>
	public  FTransform GetTransform() { return default; }
	///<summary>Returns the location of the RootComponent of this Actor</summary>
	public  FVector K2_GetActorLocation() { return default; }
	///<summary>Move the Actor to the specified location.</summary>
	public  bool K2_SetActorLocation(FVector NewLocation,bool bSweep,FHitResult SweepHitResult,bool bTeleport) { return default; }
	///<summary>Returns rotation of the RootComponent of this Actor.</summary>
	public  FRotator K2_GetActorRotation() { return default; }
	///<summary>Get the forward (X) vector (length 1.0) from this Actor, in world space.</summary>
	public  FVector GetActorForwardVector() { return default; }
	///<summary>Get the up (Z) vector (length 1.0) from this Actor, in world space.</summary>
	public  FVector GetActorUpVector() { return default; }
	///<summary>Get the right (Y) vector (length 1.0) from this Actor, in world space.</summary>
	public  FVector GetActorRightVector() { return default; }
	///<summary>Returns the bounding box of all components that make up this Actor (excluding ChildActorComponents).</summary>
	public  void GetActorBounds(bool bOnlyCollidingComponents,FVector Origin,FVector BoxExtent,bool bIncludeFromChildActors/*=false*/) {}
	///<summary>Returns the RootComponent of this Actor</summary>
	public  USceneComponent K2_GetRootComponent() { return default; }
	///<summary>Returns velocity (in cm/s (Unreal Units/second) of the rootcomponent if it is either using physics or has an associated MovementComponent</summary>
	public  FVector GetVelocity() { return default; }
	///<summary>Set the Actor&#39;s rotation instantly to the specified rotation.</summary>
	public  bool K2_SetActorRotation(FRotator NewRotation,bool bTeleportPhysics) { return default; }
	///<summary>Move the actor instantly to the specified location and rotation.</summary>
	public  bool K2_SetActorLocationAndRotation(FVector NewLocation,FRotator NewRotation,bool bSweep,FHitResult SweepHitResult,bool bTeleport) { return default; }
	///<summary>Set the Actor&#39;s world-space scale.</summary>
	public  void SetActorScale3D(FVector NewScale3D) {}
	///<summary>Returns the Actor&#39;s world-space scale.</summary>
	public  FVector GetActorScale3D() { return default; }
	///<summary>Returns the distance from this Actor to OtherActor.</summary>
	public  float GetDistanceTo(AActor OtherActor) { return default; }
	///<summary>Returns the squared distance from this Actor to OtherActor.</summary>
	public  float GetSquaredDistanceTo(AActor OtherActor) { return default; }
	///<summary>Returns the distance from this Actor to OtherActor, ignoring Z.</summary>
	public  float GetHorizontalDistanceTo(AActor OtherActor) { return default; }
	///<summary>Returns the squared distance from this Actor to OtherActor, ignoring Z.</summary>
	public  float GetSquaredHorizontalDistanceTo(AActor OtherActor) { return default; }
	///<summary>Returns the distance from this Actor to OtherActor, ignoring XY.</summary>
	public  float GetVerticalDistanceTo(AActor OtherActor) { return default; }
	///<summary>Returns the dot product from this Actor to OtherActor. Returns -2.0 on failure. Returns 0.0 for coincidental actors.</summary>
	public  float GetDotProductTo(AActor OtherActor) { return default; }
	///<summary>Returns the dot product from this Actor to OtherActor, ignoring Z. Returns -2.0 on failure. Returns 0.0 for coincidental actors.</summary>
	public  float GetHorizontalDotProductTo(AActor OtherActor) { return default; }
	///<summary>Adds a delta to the location of this actor in world space.</summary>
	public  void K2_AddActorWorldOffset(FVector DeltaLocation,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	///<summary>Adds a delta to the rotation of this actor in world space.</summary>
	public  void K2_AddActorWorldRotation(FRotator DeltaRotation,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	///<summary>Adds a delta to the transform of this actor in world space. Ignores scale and sets it to (1,1,1).</summary>
	public  void K2_AddActorWorldTransform(FTransform DeltaTransform,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	///<summary>Adds a delta to the transform of this actor in world space. Scale is unchanged.</summary>
	public  void K2_AddActorWorldTransformKeepScale(FTransform DeltaTransform,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	///<summary>Set the Actors transform to the specified one.</summary>
	public  bool K2_SetActorTransform(FTransform NewTransform,bool bSweep,FHitResult SweepHitResult,bool bTeleport) { return default; }
	///<summary>Adds a delta to the location of this component in its local reference frame.</summary>
	public  void K2_AddActorLocalOffset(FVector DeltaLocation,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	///<summary>Adds a delta to the rotation of this component in its local reference frame</summary>
	public  void K2_AddActorLocalRotation(FRotator DeltaRotation,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	///<summary>Adds a delta to the transform of this component in its local reference frame</summary>
	public  void K2_AddActorLocalTransform(FTransform NewTransform,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	///<summary>Set the actor&#39;s RootComponent to the specified relative location.</summary>
	public  void K2_SetActorRelativeLocation(FVector NewRelativeLocation,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	///<summary>Set the actor&#39;s RootComponent to the specified relative rotation</summary>
	public  void K2_SetActorRelativeRotation(FRotator NewRelativeRotation,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	///<summary>Set the actor&#39;s RootComponent to the specified relative transform</summary>
	public  void K2_SetActorRelativeTransform(FTransform NewRelativeTransform,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	///<summary>Set the actor&#39;s RootComponent to the specified relative scale 3d</summary>
	public  void SetActorRelativeScale3D(FVector NewRelativeScale) {}
	///<summary>Return the actor&#39;s relative scale 3d</summary>
	public  FVector GetActorRelativeScale3D() { return default; }
	///<summary>Sets the actor to be hidden in the game</summary>
	public  void SetActorHiddenInGame(bool bNewHidden) {}
	///<summary>Allows enabling/disabling collision for the whole actor</summary>
	public  void SetActorEnableCollision(bool bNewActorEnableCollision) {}
	///<summary>Get current state of collision for the whole actor</summary>
	public  bool GetActorEnableCollision() { return default; }
	///<summary>Destroy the actor</summary>
	public  void K2_DestroyActor() {}
	///<summary>Returns whether this actor has network authority</summary>
	public  bool HasAuthority() { return default; }
	///<summary>Creates a new component and assigns ownership to the Actor this is</summary>
	public  UActorComponent AddComponent(string TemplateName,bool bManualAttachment,FTransform RelativeTransform,UObject ComponentTemplateContext,bool bDeferredFinish/*=false*/) { return default; }
	///<summary>Creates a new component and assigns ownership to the Actor this is</summary>
	public  UActorComponent AddComponentByClass(UClass Class,bool bManualAttachment,FTransform RelativeTransform,bool bDeferredFinish) { return default; }
	///<summary>Completes the creation of a new actor component. Called either from blueprint after</summary>
	public  void FinishAddComponent(UActorComponent Component,bool bManualAttachment,FTransform RelativeTransform) {}
	///<summary>K2_AttachRootComponentTo</summary>
	public  void K2_AttachRootComponentTo(USceneComponent InParent,string InSocketName/*=NAME_None*/,EAttachLocation AttachLocationType/*=EAttachLocation.KeepRelativeOffset*/,bool bWeldSimulatedBodies/*=true*/) {}
	///<summary>Attaches the RootComponent of this Actor to the supplied component, optionally at a named socket. It is not valid to call this on components that are not Registered.</summary>
	public  bool K2_AttachToComponent(USceneComponent Parent,string SocketName,EAttachmentRule LocationRule,EAttachmentRule RotationRule,EAttachmentRule ScaleRule,bool bWeldSimulatedBodies) { return default; }
	///<summary>K2_AttachRootComponentToActor</summary>
	public  void K2_AttachRootComponentToActor(AActor InParentActor,string InSocketName/*=NAME_None*/,EAttachLocation AttachLocationType/*=EAttachLocation.KeepRelativeOffset*/,bool bWeldSimulatedBodies/*=true*/) {}
	///<summary>Attaches the RootComponent of this Actor to the supplied actor, optionally at a named socket.</summary>
	public  bool K2_AttachToActor(AActor ParentActor,string SocketName,EAttachmentRule LocationRule,EAttachmentRule RotationRule,EAttachmentRule ScaleRule,bool bWeldSimulatedBodies) { return default; }
	///<summary>DetachRootComponentFromParent</summary>
	public  void DetachRootComponentFromParent(bool bMaintainWorldPosition/*=true*/) {}
	///<summary>Detaches the RootComponent of this Actor from any SceneComponent it is currently attached to.</summary>
	public  void K2_DetachFromActor(EDetachmentRule LocationRule/*=EDetachmentRule.KeepRelative*/,EDetachmentRule RotationRule/*=EDetachmentRule.KeepRelative*/,EDetachmentRule ScaleRule/*=EDetachmentRule.KeepRelative*/) {}
	///<summary>See if this actor&#39;s Tags array contains the supplied name tag</summary>
	public  bool ActorHasTag(string Tag) { return default; }
	///<summary>Get ActorTimeDilation - this can be used for input control or speed control for slomo.</summary>
	public  float GetActorTimeDilation() { return default; }
	///<summary>Make this actor tick after PrerequisiteActor. This only applies to this actor&#39;s tick function; dependencies for owned components must be set up separately if desired.</summary>
	public  void AddTickPrerequisiteActor(AActor PrerequisiteActor) {}
	///<summary>Make this actor tick after PrerequisiteComponent. This only applies to this actor&#39;s tick function; dependencies for owned components must be set up separately if desired.</summary>
	public  void AddTickPrerequisiteComponent(UActorComponent PrerequisiteComponent) {}
	///<summary>Remove tick dependency on PrerequisiteActor.</summary>
	public  void RemoveTickPrerequisiteActor(AActor PrerequisiteActor) {}
	///<summary>Remove tick dependency on PrerequisiteComponent.</summary>
	public  void RemoveTickPrerequisiteComponent(UActorComponent PrerequisiteComponent) {}
	///<summary>Gets whether this actor can tick when paused.</summary>
	public  bool GetTickableWhenPaused() { return default; }
	///<summary>Sets whether this actor can tick when paused.</summary>
	public  void SetTickableWhenPaused(bool bTickableWhenPaused) {}
	///<summary>The number of seconds (in game time) since this Actor was created, relative to Get Game Time In Seconds.</summary>
	public  float GetGameTimeSinceCreation() { return default; }
	///<summary>Event when play begins for this actor.</summary>
	public  void ReceiveBeginPlay() {}
	///<summary>Event to notify blueprints this actor is being deleted or removed from a level.</summary>
	public  void ReceiveEndPlay(EEndPlayReason EndPlayReason) {}
	///<summary>Returns true if this actor is currently being destroyed, some gameplay events may be unsafe</summary>
	public  bool IsActorBeingDestroyed() { return default; }
	///<summary>Event when this actor takes ANY damage</summary>
	public  void ReceiveAnyDamage(float Damage,UDamageType DamageType,AController InstigatedBy,AActor DamageCauser) {}
	///<summary>Event when this actor takes RADIAL damage</summary>
	public  void ReceiveRadialDamage(float DamageReceived,UDamageType DamageType,FVector Origin,FHitResult HitInfo,AController InstigatedBy,AActor DamageCauser) {}
	///<summary>Event when this actor takes POINT damage</summary>
	public  void ReceivePointDamage(float Damage,UDamageType DamageType,FVector HitLocation,FVector HitNormal,UPrimitiveComponent HitComponent,string BoneName,FVector ShotFromDirection,AController InstigatedBy,AActor DamageCauser,FHitResult HitInfo) {}
	///<summary>Event called every frame, if ticking is enabled</summary>
	public  void ReceiveTick(float DeltaSeconds) {}
	///<summary>Event called every physics tick if bAsyncPhysicsTickEnabled is true</summary>
	public  void ReceiveAsyncPhysicsTick(float DeltaSeconds,float SimSeconds) {}
	///<summary>Event when this actor overlaps another actor, for example a player walking into a trigger.</summary>
	public  void ReceiveActorBeginOverlap(AActor OtherActor) {}
	///<summary>Event when an actor no longer overlaps another actor, and they have separated.</summary>
	public  void ReceiveActorEndOverlap(AActor OtherActor) {}
	///<summary>Event when this actor has the mouse moved over it with the clickable interface.</summary>
	public  void ReceiveActorBeginCursorOver() {}
	///<summary>Event when this actor has the mouse moved off of it with the clickable interface.</summary>
	public  void ReceiveActorEndCursorOver() {}
	///<summary>Event when this actor is clicked by the mouse when using the clickable interface.</summary>
	public  void ReceiveActorOnClicked(FKey ButtonPressed) {}
	///<summary>Event when this actor is under the mouse when left mouse button is released while using the clickable interface.</summary>
	public  void ReceiveActorOnReleased(FKey ButtonReleased) {}
	///<summary>Event when this actor is touched when click events are enabled.</summary>
	public  void ReceiveActorOnInputTouchBegin(ETouchIndex FingerIndex) {}
	///<summary>Event when this actor is under the finger when untouched when click events are enabled.</summary>
	public  void ReceiveActorOnInputTouchEnd(ETouchIndex FingerIndex) {}
	///<summary>Event when this actor has a finger moved over it with the clickable interface.</summary>
	public  void ReceiveActorOnInputTouchEnter(ETouchIndex FingerIndex) {}
	///<summary>Event when this actor has a finger moved off of it with the clickable interface.</summary>
	public  void ReceiveActorOnInputTouchLeave(ETouchIndex FingerIndex) {}
	///<summary>Returns list of actors this actor is overlapping (any component overlapping any component). Does not return itself.</summary>
	public  void GetOverlappingActors(TArray<AActor> OverlappingActors,UClass ClassFilter/*=nullptr*/) {}
	///<summary>Returns list of components this actor is overlapping.</summary>
	public  void GetOverlappingComponents(TArray<UPrimitiveComponent> OverlappingComponents) {}
	///<summary>Event when this actor bumps into a blocking object, or blocks another actor that bumps into it.</summary>
	public  void ReceiveHit(UPrimitiveComponent MyComp,AActor Other,UPrimitiveComponent OtherComp,bool bSelfMoved,FVector HitLocation,FVector HitNormal,FVector NormalImpulse,FHitResult Hit) {}
	///<summary>Set the lifespan of this actor. When it expires the object will be destroyed. If requested lifespan is 0, the timer is cleared and the actor will not be destroyed.</summary>
	public  void SetLifeSpan(float InLifespan) {}
	///<summary>Get the remaining lifespan of this actor. If zero is returned the actor lives forever.</summary>
	public  float GetLifeSpan() { return default; }
	///<summary>Construction script, the place to spawn components and do other setup.</summary>
	public  void UserConstructionScript() {}
	///<summary>Called when the actor has been explicitly destroyed.</summary>
	public  void ReceiveDestroyed() {}
	///<summary>Event triggered when the actor has been explicitly destroyed.</summary>
	public FActorDestroyedSignature OnDestroyed;
	///<summary>Event triggered when the actor is being deleted or removed from a level.</summary>
	public FActorEndPlaySignature OnEndPlay;
	///<summary>Returns true if the actor is hidden upon editor startup/by default, false if it is not</summary>
	public  bool IsHiddenEdAtStartup() { return default; }
	///<summary>Returns true if this actor is hidden in the editor viewports, also checking temporary flags.</summary>
	public  bool IsHiddenEd() { return default; }
	///<summary>Explicitly sets whether or not this actor is hidden in the editor for the duration of the current editor session</summary>
	public  void SetIsTemporarilyHiddenInEditor(bool bIsHidden) {}
	///<summary>Returns whether or not this actor was explicitly hidden in the editor for the duration of the current editor session</summary>
	public  bool IsTemporarilyHiddenInEditor(bool bIncludeParent/*=false*/) { return default; }
	///<summary>Returns true if this actor is allowed to be displayed, selected and manipulated by the editor.</summary>
	public  bool IsEditable() { return default; }
	///<summary>Returns true if this actor can EVER be selected in a level in the editor.  Can be overridden by specific actors to make them unselectable.</summary>
	public  bool IsSelectable() { return default; }
	///<summary>Returns this actor&#39;s default label (does not include any numeric suffix).  Actor labels are only available in development builds.</summary>
	public  string GetDefaultActorLabel() { return default; }
	///<summary>Returns this actor&#39;s current label.  Actor labels are only available in development builds.</summary>
	public  string GetActorLabel(bool bCreateIfNone/*=true*/) { return default; }
	///<summary>Assigns a new label to this actor.  Actor labels are only available in development builds.</summary>
	public  void SetActorLabel(string NewActorLabel,bool bMarkDirty/*=true*/) {}
	///<summary>Returns this actor&#39;s folder path. Actor folder paths are only available in development builds.</summary>
	public  string GetFolderPath() { return default; }
	///<summary>Assigns a new folder to this actor. Actor folder paths are only available in development builds.</summary>
	public  void SetFolderPath(string NewFolderPath) {}
	///<summary>Set this actor&#39;s tick functions to be enabled or disabled. Only has an effect if the function is registered</summary>
	public  void SetActorTickEnabled(bool bEnabled) {}
	///<summary>Returns whether this actor has tick enabled or not</summary>
	public  bool IsActorTickEnabled() { return default; }
	///<summary>Sets the tick interval of this actor&#39;s primary tick function. Will not enable a disabled tick function. Takes effect on next tick.</summary>
	public  void SetActorTickInterval(float TickInterval) {}
	///<summary>Returns the tick interval of this actor&#39;s primary tick function</summary>
	public  float GetActorTickInterval() { return default; }
	///<summary>ReplicatedMovement struct replication event</summary>
	public  void OnRep_ReplicatedMovement() {}
	///<summary>Set the owner of this Actor, used primarily for network replication.</summary>
	public  void SetOwner(AActor NewOwner) {}
	///<summary>Get the owner of this Actor, used primarily for network replication.</summary>
	public  AActor GetOwner() { return default; }
	///<summary>Check whether any component of this Actor is overlapping any component of another Actor.</summary>
	public  bool IsOverlappingActor(AActor Other) { return default; }
	///<summary>Puts actor in dormant networking state</summary>
	public  void SetNetDormancy(ENetDormancy NewDormancy) {}
	///<summary>Forces dormant actor to replicate but doesn&#39;t change NetDormancy state (i.e., they will go dormant again if left dormant)</summary>
	public  void FlushNetDormancy() {}
	///<summary>Returns whether this Actor was spawned by a child actor component</summary>
	public  bool IsChildActor() { return default; }
	///<summary>Returns a list of all actors spawned by our Child Actor Components, including children of children.</summary>
	public  void GetAllChildActors(TArray<AActor> ChildActors,bool bIncludeDescendants/*=true*/) {}
	///<summary>If this Actor was created by a Child Actor Component returns that Child Actor Component</summary>
	public  UChildActorComponent GetParentComponent() { return default; }
	///<summary>If this Actor was created by a Child Actor Component returns the Actor that owns that Child Actor Component</summary>
	public  AActor GetParentActor() { return default; }
	///<summary>Teleport this actor to a new location. If the actor doesn&#39;t fit exactly at the location specified, tries to slightly move it out of walls and such.</summary>
	public  bool K2_TeleportTo(FVector DestLocation,FRotator DestRotation) { return default; }
	///<summary>Return the ULevel that this Actor is part of.</summary>
	public  ULevel GetLevel() { return default; }
	///<summary>Return the FTransform of the level this actor is a part of.</summary>
	public  FTransform GetLevelTransform() { return default; }
	///<summary>Walk up the attachment chain from RootComponent until we encounter a different actor, and return it. If we are not attached to a component in a different actor, returns nullptr</summary>
	public  AActor GetAttachParentActor() { return default; }
	///<summary>Walk up the attachment chain from RootComponent until we encounter a different actor, and return the socket name in the component. If we are not attached to a component in a different actor, returns NAME_None</summary>
	public  string GetAttachParentSocketName() { return default; }
	///<summary>Find all Actors which are attached directly to a component in this actor</summary>
	public  void GetAttachedActors(TArray<AActor> OutActors,bool bResetArray/*=true*/,bool bRecursivelyIncludeAttachedActors/*=false*/) {}
	///<summary>Sets the ticking group for this actor.</summary>
	public  void SetTickGroup(ETickingGroup NewTickGroup) {}
	///<summary>Event called when this Actor becomes the view target for the given PlayerController.</summary>
	public  void K2_OnBecomeViewTarget(APlayerController PC) {}
	///<summary>Event called when this Actor is no longer the view target for the given PlayerController.</summary>
	public  void K2_OnEndViewTarget(APlayerController PC) {}
	///<summary>Event called when this Actor is reset to its initial state - used when restarting level without reloading.</summary>
	public  void K2_OnReset() {}
	///<summary>Returns true if this actor has been rendered &quot;recently&quot;, with a tolerance in seconds to define what &quot;recent&quot; means.</summary>
	public  bool WasRecentlyRendered(float Tolerance/*=0.2f*/) { return default; }
	///<summary>Force actor to be updated to clients/demo net drivers</summary>
	public  void ForceNetUpdate() {}
	///<summary>Calls PrestreamTextures() for all the actor&#39;s meshcomponents.</summary>
	public  void PrestreamTextures(float Seconds,bool bEnableStreaming,int CinematicTextureGroups/*=0*/) {}
	///<summary>Returns the point of view of the actor.</summary>
	public  void GetActorEyesViewPoint(FVector OutLocation,FRotator OutRotation) {}
	///<summary>Searches components array and returns first encountered component of the specified class</summary>
	public  UActorComponent GetComponentByClass(UClass ComponentClass) { return default; }
	///<summary>Gets all the components that inherit from the given class.</summary>
	public  TArray<UActorComponent> K2_GetComponentsByClass(UClass ComponentClass) { return default; }
	///<summary>Gets all the components that inherit from the given class with a given tag.</summary>
	public  TArray<UActorComponent> GetComponentsByTag(UClass ComponentClass,string Tag) { return default; }
	///<summary>Gets all the components that implements the given interface.</summary>
	public  TArray<UActorComponent> GetComponentsByInterface(UClass Interface) { return default; }
	///<summary>Array of ActorComponents that have been added by the user on a per-instance basis.</summary>
	public TArray<UActorComponent> InstanceComponents;
	///<summary>Array of ActorComponents that are created by blueprints and serialized per-instance.</summary>
	public TArray<UActorComponent> BlueprintCreatedComponents;
	///<summary>Trigger a noise caused by a given Pawn, at a given location.</summary>
	public  void MakeNoise(float Loudness/*=1.0f*/,APawn NoiseInstigator/*=nullptr*/,FVector NoiseLocation/*=FVector.ZeroVector*/,float MaxRange/*=0.0f*/,string Tag/*=NAME_None*/) {}
}
