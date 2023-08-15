namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>PrimitiveComponents are SceneComponents that contain or generate some sort of geometry, generally to be rendered or used as collision data.</summary>
[CppInclude("Components/PrimitiveComponent.h")]
public partial class UPrimitiveComponent : USceneComponent {
	public static UClass StaticClass() {return default;}
	///<summary>The minimum distance at which the primitive should be rendered,</summary>
	public float MinDrawDistance;
	///<summary>Max draw distance exposed to LDs. The real max draw distance is the min (disregarding 0) of this and volumes affecting this object.</summary>
	public float LDMaxDrawDistance;
	///<summary>The distance to cull this primitive at.</summary>
	public float CachedMaxDrawDistance;
	///<summary>The scene depth priority group to draw the primitive in.</summary>
	public ESceneDepthPriorityGroup DepthPriorityGroup;
	///<summary>The scene depth priority group to draw the primitive in, if it&#39;s being viewed by its owner.</summary>
	public ESceneDepthPriorityGroup ViewOwnerDepthPriorityGroup;
	///<summary>Quality of indirect lighting for Movable primitives.  This has a large effect on Indirect Lighting Cache update time.</summary>
	public EIndirectLightingCacheQuality IndirectLightingCacheQuality;
	///<summary>Controls the type of lightmap used for this component.</summary>
	public ELightmapType LightmapType;
	///<summary>Determines how the geometry of a component will be incorporated in proxy (simplified) HLODs.</summary>
	public EHLODBatchingPolicy HLODBatchingPolicy;
	///<summary>Whether to include this component in HLODs or not.</summary>
	public bool bEnableAutoLODGeneration;
	///<summary>Indicates that the texture streaming built data is local to the Actor (see UActorTextureStreamingBuildDataComponent).</summary>
	public bool bIsActorTextureStreamingBuiltData;
	///<summary>Indicates to the texture streaming wether it can use the pre-built texture streaming data (even if empty).</summary>
	public bool bIsValidTextureStreamingBuiltData;
	///<summary>When enabled this object will not be culled by distance. This is ignored if a child of a HLOD.</summary>
	public bool bNeverDistanceCull;
	///<summary>Indicates if we&#39;d like to create physics state all the time (for collision and simulation).</summary>
	public bool bAlwaysCreatePhysicsState;
	///<summary>If true, this component will generate overlap events when it is overlapping other components (eg Begin Overlap).</summary>
	public bool GetGenerateOverlapEvents() { return default; }
	///<summary>Modifies value returned by GetGenerateOverlapEvents()</summary>
	public void SetGenerateOverlapEvents(bool bInGenerateOverlapEvents) {}
	///<summary>SetLightingChannels</summary>
	public void SetLightingChannels(bool bChannel0,bool bChannel1,bool bChannel2) {}
	///<summary>Invalidates Lumen surface cache and forces it to be refreshed. Useful to make material updates more responsive.</summary>
	public void InvalidateLumenSurfaceCache() {}
	///<summary>bGenerateOverlapEvents</summary>
	public bool bGenerateOverlapEvents;
	///<summary>If true, this component will generate individual overlaps for each overlapping physics body if it is a multi-body component. When false, this component will</summary>
	public bool bMultiBodyOverlap;
	///<summary>If true, component sweeps with this component should trace against complex collision during movement (for example, each triangle of a mesh).</summary>
	public bool bTraceComplexOnMove;
	///<summary>If true, component sweeps will return the material in their hit result.</summary>
	public bool bReturnMaterialOnMove;
	///<summary>True if the primitive should be rendered using ViewOwnerDepthPriorityGroup if viewed by its owner.</summary>
	public bool bUseViewOwnerDepthPriorityGroup;
	///<summary>Whether to accept cull distance volumes to modify cached cull distance.</summary>
	public bool bAllowCullDistanceVolume;
	///<summary>If true, this component will be visible in reflection captures.</summary>
	public bool bVisibleInReflectionCaptures;
	///<summary>If true, this component will be visible in real-time sky light reflection captures.</summary>
	public bool bVisibleInRealTimeSkyCaptures;
	///<summary>If true, this component will be visible in ray tracing effects. Turning this off will remove it from ray traced reflections, shadows, etc.</summary>
	public bool bVisibleInRayTracing;
	///<summary>If true, this component will be rendered in the main pass (z prepass, basepass, transparency)</summary>
	public bool bRenderInMainPass;
	///<summary>If true, this component will be rendered in the depth pass even if it&#39;s not rendered in the main pass</summary>
	public bool bRenderInDepthPass;
	///<summary>Whether the primitive receives decals.</summary>
	public bool bReceivesDecals;
	///<summary>If this is True, this primitive will render black with an alpha of 0, but all secondary effects (shadows, reflections, indirect lighting) remain. This feature is currently only implemented in the Path Tracer.</summary>
	public bool bHoldout;
	///<summary>If this is True, this component won&#39;t be visible when the view actor is the component&#39;s owner, directly or indirectly.</summary>
	public bool bOwnerNoSee;
	///<summary>If this is True, this component will only be visible when the view actor is the component&#39;s owner, directly or indirectly.</summary>
	public bool bOnlyOwnerSee;
	///<summary>Treat this primitive as part of the background for occlusion purposes. This can be used as an optimization to reduce the cost of rendering skyboxes, large ground planes that are part of the vista, etc.</summary>
	public bool bTreatAsBackgroundForOcclusion;
	///<summary>Whether to render the primitive in the depth only pass.</summary>
	public bool bUseAsOccluder;
	///<summary>If this is True, this component can be selected in the editor.</summary>
	public bool bSelectable;
	///<summary>If true, this component will be considered for placement when dragging and placing items in the editor even if it is not visible, such as in the case of hidden collision meshes</summary>
	public bool bConsiderForActorPlacementWhenHidden;
	///<summary>If true, forces mips for textures used by this component to be resident when this component&#39;s level is loaded.</summary>
	public bool bForceMipStreaming;
	///<summary>If true a hit-proxy will be generated for each instance of instanced static meshes</summary>
	public bool bHasPerInstanceHitProxies;
	///<summary>Controls whether the primitive component should cast a shadow or not.</summary>
	public bool CastShadow;
	///<summary>Whether the primitive will be used as an emissive light source.</summary>
	public bool bEmissiveLightSource;
	///<summary>Controls whether the primitive should influence indirect lighting.</summary>
	public bool bAffectDynamicIndirectLighting;
	///<summary>Controls whether the primitive should affect indirect lighting when hidden. This flag is only used if bAffectDynamicIndirectLighting is true.</summary>
	public bool bAffectIndirectLightingWhileHidden;
	///<summary>Controls whether the primitive should affect dynamic distance field lighting methods.  This flag is only used if CastShadow is true. *</summary>
	public bool bAffectDistanceFieldLighting;
	///<summary>Controls whether the primitive should cast shadows in the case of non precomputed shadowing.  This flag is only used if CastShadow is true. *</summary>
	public bool bCastDynamicShadow;
	///<summary>Whether the object should cast a static shadow from shadow casting lights.  This flag is only used if CastShadow is true.</summary>
	public bool bCastStaticShadow;
	///<summary>Whether the object should cast a volumetric translucent shadow.</summary>
	public bool bCastVolumetricTranslucentShadow;
	///<summary>Whether the object should cast contact shadows.</summary>
	public bool bCastContactShadow;
	///<summary>When enabled, the component will only cast a shadow on itself and not other components in the world.</summary>
	public bool bSelfShadowOnly;
	///<summary>When enabled, the component will be rendering into the far shadow cascades (only for directional lights).</summary>
	public bool bCastFarShadow;
	///<summary>Whether this component should create a per-object shadow that gives higher effective shadow resolution.</summary>
	public bool bCastInsetShadow;
	///<summary>Whether this component should cast shadows from lights that have bCastShadowsFromCinematicObjectsOnly enabled.</summary>
	public bool bCastCinematicShadow;
	///<summary>If true, the primitive will cast shadows even if bHidden is true.</summary>
	public bool bCastHiddenShadow;
	///<summary>Whether this primitive should cast dynamic shadows as if it were a two sided material.</summary>
	public bool bCastShadowAsTwoSided;
	///<summary>@deprecated Replaced by LightmapType</summary>
	public bool bLightAsIfStatic_DEPRECATED;
	///<summary>Whether to light this component and any attachments as a group.  This only has effect on the root component of an attachment tree.</summary>
	public bool bLightAttachmentsAsGroup;
	///<summary>If set, then it overrides any bLightAttachmentsAsGroup set in a parent.</summary>
	public bool bExcludeFromLightAttachmentGroup;
	///<summary>Mobile only:</summary>
	public bool bReceiveMobileCSMShadows;
	///<summary>Whether the whole component should be shadowed as one from stationary lights, which makes shadow receiving much cheaper.</summary>
	public bool bSingleSampleShadowFromStationaryLights;
	///<summary>Will ignore radial impulses applied to this component.</summary>
	public bool bIgnoreRadialImpulse;
	///<summary>Will ignore radial forces applied to this component.</summary>
	public bool bIgnoreRadialForce;
	///<summary>True for damage to this component to apply physics impulse, false to opt out of these impulses.</summary>
	public bool bApplyImpulseOnDamage;
	///<summary>True if physics should be replicated to autonomous proxies. This should be true for</summary>
	public bool bReplicatePhysicsToAutonomousProxy;
	///<summary>If set, navmesh will not be generated under the surface of the geometry</summary>
	public bool bFillCollisionUnderneathForNavmesh;
	///<summary>If this is True, this component must always be loaded on clients, even if Hidden and CollisionEnabled is NoCollision.</summary>
	public bool AlwaysLoadOnClient;
	///<summary>If this is True, this component must always be loaded on servers, even if Hidden and CollisionEnabled is NoCollision</summary>
	public bool AlwaysLoadOnServer;
	///<summary>Composite the drawing of this component onto the scene after post processing (only applies to editor drawing)</summary>
	public bool bUseEditorCompositing;
	///<summary>Set to true while the editor is moving the component, which notifies the Renderer to track velocities even if the component is Static.</summary>
	public bool bIsBeingMovedByEditor;
	///<summary>If true, this component will be rendered in the CustomDepth pass (usually used for outlines)</summary>
	public bool bRenderCustomDepth;
	///<summary>When true, will only be visible in Scene Capture</summary>
	public bool bVisibleInSceneCaptureOnly;
	///<summary>When true, will not be captured by Scene Capture</summary>
	public bool bHiddenInSceneCapture;
	///<summary>If true, this component will be available to ray trace as a far field primitive even if hidden.</summary>
	public bool bRayTracingFarField;
	///<summary>bHasNoStreamableTextures</summary>
	public bool bHasNoStreamableTextures;
	///<summary>When false, the underlying physics body will contain all sim data (mass, inertia tensor, etc) even if mobility is not set to Moveable</summary>
	public bool bStaticWhenNotMoveable;
	///<summary>If true then DoCustomNavigableGeometryExport will be called to collect navigable geometry of this component.</summary>
	public EHasCustomNavigableGeometry bHasCustomNavigableGeometry;
	///<summary>HitProxyPriority</summary>
	public EHitProxyPriority HitProxyPriority;
	///<summary>ExcludeForSpecificHLODLevels_DEPRECATED</summary>
	public TArray<int> ExcludeForSpecificHLODLevels_DEPRECATED;
	///<summary>Whether this primitive is excluded from the specified HLOD level</summary>
	public bool IsExcludedFromHLODLevel(EHLODLevelExclusion HLODLevel) { return default; }
	///<summary>Exclude this primitive from the specified HLOD level</summary>
	public void SetExcludedFromHLODLevel(EHLODLevelExclusion HLODLevel,bool bExcluded) {}
	///<summary>SetExcludeForSpecificHLODLevels</summary>
	public void SetExcludeForSpecificHLODLevels(TArray<int> InExcludeForSpecificHLODLevels) {}
	///<summary>GetExcludeForSpecificHLODLevels</summary>
	public TArray<int> GetExcludeForSpecificHLODLevels() { return default; }
	///<summary>CanBeCharacterBase_DEPRECATED</summary>
	public ECanBeCharacterBase CanBeCharacterBase_DEPRECATED;
	///<summary>Deprecated - represented by HLODBatchingPolicy == EHLODBatchingPolicy::MeshSection</summary>
	public bool bUseMaxLODAsImposter_DEPRECATED;
	///<summary>Deprecated - represented by HLODBatchingPolicy == EHLODBatchingPolicy::Instancing</summary>
	public bool bBatchImpostersAsInstances_DEPRECATED;
	///<summary>Determine whether a Character can step up onto this component.</summary>
	public ECanBeCharacterBase CanCharacterStepUpOn;
	///<summary>Channels that this component should be in.  Lights with matching channels will affect the component.</summary>
	public FLightingChannels LightingChannels;
	///<summary>Defines run-time groups of components. For example allows to assemble multiple parts of a building at runtime.</summary>
	public int RayTracingGroupId;
	///<summary>Used for precomputed visibility</summary>
	public int VisibilityId;
	///<summary>Optionally write this 0-255 value to the stencil buffer in CustomDepth pass (Requires project setting or r.CustomDepth == 3)</summary>
	public int CustomDepthStencilValue;
	///<summary>Optional user defined default values for the custom primitive data of this primitive</summary>
	public FCustomPrimitiveData CustomPrimitiveData;
	///<summary>Custom data that can be read by a material through a material parameter expression. Set data using SetCustomPrimitiveData* functions</summary>
	public FCustomPrimitiveData CustomPrimitiveDataInternal;
	///<summary>Translucent objects with a lower sort priority draw behind objects with a higher priority.</summary>
	public int TranslucencySortPriority;
	///<summary>Modified sort distance offset for translucent objects in world units.</summary>
	public float TranslucencySortDistanceOffset;
	///<summary>Array of runtime virtual textures into which we draw the mesh for this actor.</summary>
	public TArray<URuntimeVirtualTexture> RuntimeVirtualTextures;
	///<summary>Bias to the LOD selected for rendering to runtime virtual textures.</summary>
	public short VirtualTextureLodBias;
	///<summary>Number of lower mips in the runtime virtual texture to skip for rendering this primitive.</summary>
	public short VirtualTextureCullMips;
	///<summary>Set the minimum pixel coverage before culling from the runtime virtual texture.</summary>
	public short VirtualTextureMinCoverage;
	///<summary>Controls if this component draws in the main pass as well as in the virtual texture.</summary>
	public ERuntimeVirtualTextureMainPassType VirtualTextureRenderPassType;
	///<summary>Scales the bounds of the object.</summary>
	public float BoundsScale;
	///<summary>Returns true if this component has been rendered &quot;recently&quot;, with a tolerance in seconds to define what &quot;recent&quot; means.</summary>
	public bool WasRecentlyRendered(float Tolerance/*=0.2f*/) { return default; }
	///<summary>Set of actors to ignore during component sweeps in MoveComponent().</summary>
	public TArray<AActor> MoveIgnoreActors;
	///<summary>Tells this component whether to ignore collision with all components of a specific Actor when this component is moved.</summary>
	public void IgnoreActorWhenMoving(AActor Actor,bool bShouldIgnore) {}
	///<summary>Returns the list of actors we currently ignore when moving.</summary>
	public TArray<AActor> CopyArrayOfMoveIgnoreActors() { return default; }
	///<summary>Clear the list of actors we ignore when moving.</summary>
	public void ClearMoveIgnoreActors() {}
	///<summary>Set of components to ignore during component sweeps in MoveComponent().</summary>
	public TArray<UPrimitiveComponent> MoveIgnoreComponents;
	///<summary>Tells this component whether to ignore collision with another component when this component is moved.</summary>
	public void IgnoreComponentWhenMoving(UPrimitiveComponent Component,bool bShouldIgnore) {}
	///<summary>Returns the list of actors we currently ignore when moving.</summary>
	public TArray<UPrimitiveComponent> CopyArrayOfMoveIgnoreComponents() { return default; }
	///<summary>Clear the list of components we ignore when moving.</summary>
	public void ClearMoveIgnoreComponents() {}
	///<summary>Gets the index of the scalar parameter for the custom primitive data array</summary>
	public int GetCustomPrimitiveDataIndexForScalarParameter(FName ParameterName) { return default; }
	///<summary>Gets the index of the vector parameter for the custom primitive data array</summary>
	public int GetCustomPrimitiveDataIndexForVectorParameter(FName ParameterName) { return default; }
	///<summary>Set a scalar parameter for custom primitive data. This sets the run-time data only, so it doesn&#39;t serialize.</summary>
	public void SetScalarParameterForCustomPrimitiveData(FName ParameterName,float Value) {}
	///<summary>Set a vector parameter for custom primitive data. This sets the run-time data only, so it doesn&#39;t serialize.</summary>
	public void SetVectorParameterForCustomPrimitiveData(FName ParameterName,FVector4 Value) {}
	///<summary>Set custom primitive data at index DataIndex. This sets the run-time data only, so it doesn&#39;t serialize.</summary>
	public void SetCustomPrimitiveDataFloat(int DataIndex,float Value) {}
	///<summary>Set custom primitive data, two floats at once, from index DataIndex to index DataIndex + 1. This sets the run-time data only, so it doesn&#39;t serialize.</summary>
	public void SetCustomPrimitiveDataVector2(int DataIndex,FVector2D Value) {}
	///<summary>Set custom primitive data, three floats at once, from index DataIndex to index DataIndex + 2. This sets the run-time data only, so it doesn&#39;t serialize.</summary>
	public void SetCustomPrimitiveDataVector3(int DataIndex,FVector Value) {}
	///<summary>Set custom primitive data, four floats at once, from index DataIndex to index DataIndex + 3. This sets the run-time data only, so it doesn&#39;t serialize.</summary>
	public void SetCustomPrimitiveDataVector4(int DataIndex,FVector4 Value) {}
	///<summary>Set a scalar parameter for default custom primitive data. This will be serialized and is useful in construction scripts.</summary>
	public void SetScalarParameterForDefaultCustomPrimitiveData(FName ParameterName,float Value) {}
	///<summary>Set a vector parameter for default custom primitive data. This will be serialized and is useful in construction scripts.</summary>
	public void SetVectorParameterForDefaultCustomPrimitiveData(FName ParameterName,FVector4 Value) {}
	///<summary>Set default custom primitive data at index DataIndex, and marks the render state dirty</summary>
	public void SetDefaultCustomPrimitiveDataFloat(int DataIndex,float Value) {}
	///<summary>Set default custom primitive data, two floats at once, from index DataIndex to index DataIndex + 1, and marks the render state dirty</summary>
	public void SetDefaultCustomPrimitiveDataVector2(int DataIndex,FVector2D Value) {}
	///<summary>Set default custom primitive data, three floats at once, from index DataIndex to index DataIndex + 2, and marks the render state dirty</summary>
	public void SetDefaultCustomPrimitiveDataVector3(int DataIndex,FVector Value) {}
	///<summary>Set default custom primitive data, four floats at once, from index DataIndex to index DataIndex + 3, and marks the render state dirty</summary>
	public void SetDefaultCustomPrimitiveDataVector4(int DataIndex,FVector4 Value) {}
	///<summary>Check whether this component is overlapping another component.</summary>
	public bool IsOverlappingComponent(UPrimitiveComponent OtherComp) { return default; }
	///<summary>Check whether this component is overlapping any component of the given Actor.</summary>
	public bool IsOverlappingActor(AActor Other) { return default; }
	///<summary>Returns a list of actors that this component is overlapping.</summary>
	public void GetOverlappingActors(TArray<AActor> OverlappingActors,UClass ClassFilter/*=nullptr*/) {}
	///<summary>Returns unique list of components this component is overlapping.</summary>
	public void GetOverlappingComponents(TArray<UPrimitiveComponent> OutOverlappingComponents) {}
	///<summary>Physics scene information for this component, holds a single rigid body with multiple shapes.</summary>
	public FBodyInstance BodyInstance;
	///<summary>Event called when a component hits (or is hit by) something solid. This could happen due to things like Character movement, using Set Location with &#39;sweep&#39; enabled, or physics simulation.</summary>
	public FComponentHitSignature OnComponentHit;
	///<summary>Event called when something starts to overlaps this component, for example a player walking into a trigger.</summary>
	public FComponentBeginOverlapSignature OnComponentBeginOverlap;
	///<summary>Event called when something stops overlapping this component</summary>
	public FComponentEndOverlapSignature OnComponentEndOverlap;
	///<summary>Event called when the underlying physics objects is woken up</summary>
	public FComponentWakeSignature OnComponentWake;
	///<summary>Event called when the underlying physics objects is put to sleep</summary>
	public FComponentSleepSignature OnComponentSleep;
	///<summary>Event called when physics state is created or destroyed for this component</summary>
	public FComponentPhysicsStateChanged OnComponentPhysicsStateChanged;
	///<summary>Event called when the mouse cursor is moved over this component and mouse over events are enabled in the player controller</summary>
	public FComponentBeginCursorOverSignature OnBeginCursorOver;
	///<summary>Event called when the mouse cursor is moved off this component and mouse over events are enabled in the player controller</summary>
	public FComponentEndCursorOverSignature OnEndCursorOver;
	///<summary>Event called when the left mouse button is clicked while the mouse is over this component and click events are enabled in the player controller</summary>
	public FComponentOnClickedSignature OnClicked;
	///<summary>Event called when the left mouse button is released while the mouse is over this component click events are enabled in the player controller</summary>
	public FComponentOnReleasedSignature OnReleased;
	///<summary>Event called when a touch input is received over this component when touch events are enabled in the player controller</summary>
	public FComponentOnInputTouchBeginSignature OnInputTouchBegin;
	///<summary>Event called when a touch input is released over this component when touch events are enabled in the player controller</summary>
	public FComponentOnInputTouchEndSignature OnInputTouchEnd;
	///<summary>Event called when a finger is moved over this component when touch over events are enabled in the player controller</summary>
	public FComponentBeginTouchOverSignature OnInputTouchEnter;
	///<summary>Event called when a finger is moved off this component when touch over events are enabled in the player controller</summary>
	public FComponentEndTouchOverSignature OnInputTouchLeave;
	///<summary>Defines how quickly it should be culled. For example buildings should have a low priority, but small dressing should have a high priority.</summary>
	public ERayTracingGroupCullingPriority RayTracingGroupCullingPriority;
	///<summary>Mask used for stencil buffer writes.</summary>
	public ERendererStencilMask CustomDepthStencilWriteMask;
	///<summary>Scale the bounds of this object, used for frustum culling. Useful for features like WorldPositionOffset.</summary>
	public void SetBoundsScale(float NewBoundsScale/*=1.0f*/) {}
	///<summary>Returns the material used by the element at the specified index</summary>
	public virtual UMaterialInterface GetMaterial(int ElementIndex) { return default; }
	///<summary>Changes the material applied to an element of the mesh.</summary>
	public virtual void SetMaterial(int ElementIndex,UMaterialInterface Material) {}
	///<summary>Changes the material applied to an element of the mesh.</summary>
	public virtual void SetMaterialByName(FName MaterialSlotName,UMaterialInterface Material) {}
	///<summary>Creates a Dynamic Material Instance for the specified element index.  The parent of the instance is set to the material being replaced.</summary>
	public virtual UMaterialInstanceDynamic CreateAndSetMaterialInstanceDynamic(int ElementIndex) { return default; }
	///<summary>Creates a Dynamic Material Instance for the specified element index.  The parent of the instance is set to the material being replaced.</summary>
	public virtual UMaterialInstanceDynamic CreateAndSetMaterialInstanceDynamicFromMaterial(int ElementIndex,UMaterialInterface Parent) { return default; }
	///<summary>Creates a Dynamic Material Instance for the specified element index, optionally from the supplied material.</summary>
	public virtual UMaterialInstanceDynamic CreateDynamicMaterialInstance(int ElementIndex,UMaterialInterface SourceMaterial/*=NULL*/,FName OptionalName/*=NAME_None*/) { return default; }
	///<summary>Try and retrieve the material applied to a particular collision face of mesh. Used with face index returned from collision trace.</summary>
	public virtual UMaterialInterface GetMaterialFromCollisionFaceIndex(int FaceIndex,int SectionIndex) { return default; }
	///<summary>Returns the slope override struct for this component.</summary>
	public FWalkableSlopeOverride GetWalkableSlopeOverride() { return default; }
	///<summary>Sets a new slope override for this component instance.</summary>
	public virtual void SetWalkableSlopeOverride(FWalkableSlopeOverride NewOverride) {}
	///<summary>Sets whether or not a single body should use physics simulation, or should be &#39;fixed&#39; (kinematic).</summary>
	public virtual void SetSimulatePhysics(bool bSimulate) {}
	///<summary>SetStaticWhenNotMoveable</summary>
	public void SetStaticWhenNotMoveable(bool bInStaticWhenNotMoveable) {}
	///<summary>GetStaticWhenNotMoveable</summary>
	public bool GetStaticWhenNotMoveable() { return default; }
	///<summary>Sets the constraint mode of the component.</summary>
	public virtual void SetConstraintMode(EDOFMode ConstraintMode) {}
	///<summary>Add an impulse to a single rigid body. Good for one time instant burst.</summary>
	public virtual void AddImpulse(FVector Impulse,FName BoneName/*=NAME_None*/,bool bVelChange/*=false*/) {}
	///<summary>Add an angular impulse to a single rigid body. Good for one time instant burst.</summary>
	public virtual void AddAngularImpulseInRadians(FVector Impulse,FName BoneName/*=NAME_None*/,bool bVelChange/*=false*/) {}
	///<summary>Add an angular impulse to a single rigid body. Good for one time instant burst.</summary>
	public void AddAngularImpulseInDegrees(FVector Impulse,FName BoneName/*=NAME_None*/,bool bVelChange/*=false*/) {}
	///<summary>Add an impulse to a single rigid body at a specific location.</summary>
	public virtual void AddImpulseAtLocation(FVector Impulse,FVector Location,FName BoneName/*=NAME_None*/) {}
	///<summary>Add an impulse to a single rigid body at a specific location. The Strength is taken as a change in angular velocity instead of an impulse (ie. mass will have no effect).</summary>
	public virtual void AddVelocityChangeImpulseAtLocation(FVector Impulse,FVector Location,FName BoneName/*=NAME_None*/) {}
	///<summary>Add an impulse to all rigid bodies in this component, radiating out from the specified position.</summary>
	public virtual void AddRadialImpulse(FVector Origin,float Radius,float Strength,ERadialImpulseFalloff Falloff,bool bVelChange/*=false*/) {}
	///<summary>Add a force to a single rigid body.</summary>
	public virtual void AddForce(FVector Force,FName BoneName/*=NAME_None*/,bool bAccelChange/*=false*/) {}
	///<summary>Add a force to a single rigid body at a particular location in world space.</summary>
	public virtual void AddForceAtLocation(FVector Force,FVector Location,FName BoneName/*=NAME_None*/) {}
	///<summary>Add a force to a single rigid body at a particular location. Both Force and Location should be in body space.</summary>
	public virtual void AddForceAtLocationLocal(FVector Force,FVector Location,FName BoneName/*=NAME_None*/) {}
	///<summary>Add a force to all bodies in this component, originating from the supplied world-space location.</summary>
	public virtual void AddRadialForce(FVector Origin,float Radius,float Strength,ERadialImpulseFalloff Falloff,bool bAccelChange/*=false*/) {}
	///<summary>Add a torque to a single rigid body.</summary>
	public virtual void AddTorqueInRadians(FVector Torque,FName BoneName/*=NAME_None*/,bool bAccelChange/*=false*/) {}
	///<summary>Add a torque to a single rigid body.</summary>
	public void AddTorqueInDegrees(FVector Torque,FName BoneName/*=NAME_None*/,bool bAccelChange/*=false*/) {}
	///<summary>Set the linear velocity of a single body.</summary>
	public virtual void SetPhysicsLinearVelocity(FVector NewVel,bool bAddToCurrent/*=false*/,FName BoneName/*=NAME_None*/) {}
	///<summary>Get the linear velocity of a single body.</summary>
	public FVector GetPhysicsLinearVelocity(FName BoneName/*=NAME_None*/) { return default; }
	///<summary>Get the linear velocity of a point on a single body.</summary>
	public FVector GetPhysicsLinearVelocityAtPoint(FVector Point,FName BoneName/*=NAME_None*/) { return default; }
	///<summary>Set the linear velocity of all bodies in this component.</summary>
	public virtual void SetAllPhysicsLinearVelocity(FVector NewVel,bool bAddToCurrent/*=false*/) {}
	///<summary>Set the angular velocity of a single body.</summary>
	public virtual void SetPhysicsAngularVelocityInRadians(FVector NewAngVel,bool bAddToCurrent/*=false*/,FName BoneName/*=NAME_None*/) {}
	///<summary>Set the angular velocity of a single body.</summary>
	public void SetPhysicsAngularVelocityInDegrees(FVector NewAngVel,bool bAddToCurrent/*=false*/,FName BoneName/*=NAME_None*/) {}
	///<summary>Set the maximum angular velocity of a single body.</summary>
	public void SetPhysicsMaxAngularVelocityInDegrees(float NewMaxAngVel,bool bAddToCurrent/*=false*/,FName BoneName/*=NAME_None*/) {}
	///<summary>Set the maximum angular velocity of a single body.</summary>
	public void SetPhysicsMaxAngularVelocityInRadians(float NewMaxAngVel,bool bAddToCurrent/*=false*/,FName BoneName/*=NAME_None*/) {}
	///<summary>Get the angular velocity of a single body, in degrees per second.</summary>
	public FVector GetPhysicsAngularVelocityInDegrees(FName BoneName/*=NAME_None*/) { return default; }
	///<summary>Get the angular velocity of a single body, in radians per second.</summary>
	public FVector GetPhysicsAngularVelocityInRadians(FName BoneName/*=NAME_None*/) { return default; }
	///<summary>Get the center of mass of a single body. In the case of a welded body this will return the center of mass of the entire welded body (including its parent and children)</summary>
	public FVector GetCenterOfMass(FName BoneName/*=NAME_None*/) { return default; }
	///<summary>Set the center of mass of a single body. This will offset the physx-calculated center of mass.</summary>
	public void SetCenterOfMass(FVector CenterOfMassOffset,FName BoneName/*=NAME_None*/) {}
	///<summary>&#39;Wake&#39; physics simulation for a single body.</summary>
	public virtual void WakeRigidBody(FName BoneName/*=NAME_None*/) {}
	///<summary>Force a single body back to sleep.</summary>
	public void PutRigidBodyToSleep(FName BoneName/*=NAME_None*/) {}
	///<summary>Changes the value of bNotifyRigidBodyCollision</summary>
	public virtual void SetNotifyRigidBodyCollision(bool bNewNotifyRigidBodyCollision) {}
	///<summary>Changes the value of bOwnerNoSee.</summary>
	public void SetOwnerNoSee(bool bNewOwnerNoSee) {}
	///<summary>Changes the value of bOnlyOwnerSee.</summary>
	public void SetOnlyOwnerSee(bool bNewOnlyOwnerSee) {}
	///<summary>Changes the value of bIsVisibleInRayTracing.</summary>
	public void SetVisibleInRayTracing(bool bNewVisibleInRayTracing) {}
	///<summary>Changes the value of CastShadow.</summary>
	public void SetCastShadow(bool NewCastShadow) {}
	///<summary>Changes the value of EmissiveLightSource.</summary>
	public void SetEmissiveLightSource(bool NewEmissiveLightSource) {}
	///<summary>Changes the value of CastHiddenShadow.</summary>
	public void SetCastHiddenShadow(bool NewCastHiddenShadow) {}
	///<summary>Changes the value of CastInsetShadow.</summary>
	public void SetCastInsetShadow(bool bInCastInsetShadow) {}
	///<summary>Changes the value of bCastContactShadow.</summary>
	public void SetCastContactShadow(bool bInCastContactShadow) {}
	///<summary>Changes the value of LightAttachmentsAsGroup.</summary>
	public void SetLightAttachmentsAsGroup(bool bInLightAttachmentsAsGroup) {}
	///<summary>Changes the value of ExcludeFromLightAttachmentGroup.</summary>
	public void SetExcludeFromLightAttachmentGroup(bool bInExcludeFromLightAttachmentGroup) {}
	///<summary>Changes the value of bSingleSampleShadowFromStationaryLights.</summary>
	public void SetSingleSampleShadowFromStationaryLights(bool bNewSingleSampleShadowFromStationaryLights) {}
	///<summary>Changes the value of TranslucentSortPriority.</summary>
	public void SetTranslucentSortPriority(int NewTranslucentSortPriority) {}
	///<summary>Changes the value of TranslucencySortDistanceOffset.</summary>
	public void SetTranslucencySortDistanceOffset(float NewTranslucencySortDistanceOffset) {}
	///<summary>Changes the value of Affect Distance Field Lighting</summary>
	public void SetAffectDistanceFieldLighting(bool NewAffectDistanceFieldLighting) {}
	///<summary>Changes the value of bReceivesDecals.</summary>
	public void SetReceivesDecals(bool bNewReceivesDecals) {}
	///<summary>Changes the value of bHoldout (Path Tracing only feature)</summary>
	public void SetHoldout(bool bNewHoldout) {}
	///<summary>Changes the value of bAffectDynamicIndirectLighting</summary>
	public void SetAffectDynamicIndirectLighting(bool bNewAffectDynamicIndirectLighting) {}
	///<summary>Changes the value of bAffectIndirectLightingWhileHidden</summary>
	public void SetAffectIndirectLightingWhileHidden(bool bNewAffectIndirectLightingWhileHidden) {}
	///<summary>Controls what kind of collision is enabled for this body</summary>
	public virtual void SetCollisionEnabled(ECollisionEnabled NewType) {}
	///<summary>Set Collision Profile Name</summary>
	public virtual void SetCollisionProfileName(FName InCollisionProfileName,bool bUpdateOverlaps/*=true*/) {}
	///<summary>Get the collision profile name</summary>
	public FName GetCollisionProfileName() { return default; }
	///<summary>Changes the collision channel that this object uses when it moves</summary>
	public virtual void SetCollisionObjectType(ECollisionChannel Channel) {}
	///<summary>Perform a line trace against a single component</summary>
	public bool K2_LineTraceComponent(FVector TraceStart,FVector TraceEnd,bool bTraceComplex,bool bShowTrace,bool bPersistentShowTrace,FVector HitLocation,FVector HitNormal,FName BoneName,FHitResult OutHit) { return default; }
	///<summary>Perform a sphere trace against a single component</summary>
	public bool K2_SphereTraceComponent(FVector TraceStart,FVector TraceEnd,float SphereRadius,bool bTraceComplex,bool bShowTrace,bool bPersistentShowTrace,FVector HitLocation,FVector HitNormal,FName BoneName,FHitResult OutHit) { return default; }
	///<summary>Perform a box overlap against a single component as an AABB (No rotation)</summary>
	public bool K2_BoxOverlapComponent(FVector InBoxCentre,FBox InBox,bool bTraceComplex,bool bShowTrace,bool bPersistentShowTrace,FVector HitLocation,FVector HitNormal,FName BoneName,FHitResult OutHit) { return default; }
	///<summary>Perform a sphere overlap against a single component</summary>
	public bool K2_SphereOverlapComponent(FVector InSphereCentre,float InSphereRadius,bool bTraceComplex,bool bShowTrace,bool bPersistentShowTrace,FVector HitLocation,FVector HitNormal,FName BoneName,FHitResult OutHit) { return default; }
	///<summary>Sets the bRenderCustomDepth property and marks the render state dirty.</summary>
	public void SetRenderCustomDepth(bool bValue) {}
	///<summary>Sets the CustomDepth stencil value (0 - 255) and marks the render state dirty.</summary>
	public void SetCustomDepthStencilValue(int Value) {}
	///<summary>Sets the CustomDepth stencil write mask and marks the render state dirty.</summary>
	public void SetCustomDepthStencilWriteMask(ERendererStencilMask WriteMaskBit) {}
	///<summary>Sets bRenderInMainPass property and marks the render state dirty.</summary>
	public void SetRenderInMainPass(bool bValue) {}
	///<summary>Sets bRenderInDepthPass property and marks the render state dirty.</summary>
	public void SetRenderInDepthPass(bool bValue) {}
	///<summary>Sets bVisibleInSceneCaptureOnly property and marks the render state dirty.</summary>
	public void SetVisibleInSceneCaptureOnly(bool bValue) {}
	///<summary>Sets bHideInSceneCapture property and marks the render state dirty.</summary>
	public void SetHiddenInSceneCapture(bool bValue) {}
	///<summary>Which specific HLOD levels this component should be excluded from</summary>
	public byte ExcludeFromHLODLevels;
	///<summary>LOD parent primitive to draw instead of this one (multiple UPrim&#39;s will point to the same LODParent )</summary>
	public UPrimitiveComponent LODParentPrimitive;
	///<summary>Return number of material elements in this primitive</summary>
	public virtual int GetNumMaterials() { return default; }
	///<summary>Returns BodyInstanceAsyncPhysicsTickHandle of the component. For use in the Async Physics Tick event</summary>
	public FBodyInstanceAsyncPhysicsTickHandle GetBodyInstanceAsyncPhysicsTickHandle(FName BoneName/*=NAME_None*/,bool bGetWelded/*=true*/,int Index/*=-1*/) { return default; }
	///<summary>Returns the distance and closest point to the collision surface.</summary>
	public float GetClosestPointOnCollision(FVector Point,FVector OutPointOnBody,FName BoneName/*=NAME_None*/) { return default; }
	///<summary>Returns the form of collision for this component</summary>
	public virtual ECollisionEnabled GetCollisionEnabled() { return default; }
	///<summary>Utility to see if there is any form of collision (query or physics) enabled on this component.</summary>
	public bool K2_IsCollisionEnabled() { return default; }
	///<summary>Utility to see if there is any query collision enabled on this component.</summary>
	public bool K2_IsQueryCollisionEnabled() { return default; }
	///<summary>Utility to see if there is any physics collision enabled on this component.</summary>
	public bool K2_IsPhysicsCollisionEnabled() { return default; }
	///<summary>Gets the response type given a specific channel</summary>
	public virtual ECollisionResponse GetCollisionResponseToChannel(ECollisionChannel Channel) { return default; }
	///<summary>Gets the collision object type</summary>
	public virtual ECollisionChannel GetCollisionObjectType() { return default; }
	///<summary>Set the angular velocity of all bodies in this component.</summary>
	public void SetAllPhysicsAngularVelocityInDegrees(FVector NewAngVel,bool bAddToCurrent/*=false*/) {}
	///<summary>Set the angular velocity of all bodies in this component.</summary>
	public virtual void SetAllPhysicsAngularVelocityInRadians(FVector NewAngVel,bool bAddToCurrent/*=false*/) {}
	///<summary>Ensure simulation is running for all bodies in this component.</summary>
	public virtual void WakeAllRigidBodies() {}
	///<summary>Enables/disables whether this component is affected by gravity. This applies only to components with bSimulatePhysics set to true.</summary>
	public virtual void SetEnableGravity(bool bGravityEnabled) {}
	///<summary>Returns whether this component is affected by gravity. Returns always false if the component is not simulated.</summary>
	public virtual bool IsGravityEnabled() { return default; }
	///<summary>Sets the linear damping of this component.</summary>
	public virtual void SetLinearDamping(float InDamping) {}
	///<summary>Returns the linear damping of this component.</summary>
	public virtual float GetLinearDamping() { return default; }
	///<summary>Sets the angular damping of this component.</summary>
	public virtual void SetAngularDamping(float InDamping) {}
	///<summary>Returns the angular damping of this component.</summary>
	public virtual float GetAngularDamping() { return default; }
	///<summary>Change the mass scale used to calculate the mass of a single physics body</summary>
	public virtual void SetMassScale(FName BoneName/*=NAME_None*/,float InMassScale/*=1.0f*/) {}
	///<summary>Returns the mass scale used to calculate the mass of a single physics body</summary>
	public virtual float GetMassScale(FName BoneName/*=NAME_None*/) { return default; }
	///<summary>Change the mass scale used fo all bodies in this component</summary>
	public virtual void SetAllMassScale(float InMassScale/*=1.0f*/) {}
	///<summary>Override the mass (in Kg) of a single physics body.</summary>
	public virtual void SetMassOverrideInKg(FName BoneName/*=NAME_None*/,float MassInKg/*=1.0f*/,bool bOverrideMass/*=true*/) {}
	///<summary>Returns the mass of this component in kg.</summary>
	public virtual float GetMass() { return default; }
	///<summary>Returns the inertia tensor of this component in kg cm^2. The inertia tensor is in local component space.</summary>
	public virtual FVector GetInertiaTensor(FName BoneName/*=NAME_None*/) { return default; }
	///<summary>Scales the given vector by the world space moment of inertia. Useful for computing the torque needed to rotate an object.</summary>
	public virtual FVector ScaleByMomentOfInertia(FVector InputVector,FName BoneName/*=NAME_None*/) { return default; }
	///<summary>Set whether this component should use Continuous Collision Detection</summary>
	public virtual void SetUseCCD(bool InUseCCD,FName BoneName/*=NAME_None*/) {}
	///<summary>Set whether all bodies in this component should use Continuous Collision Detection</summary>
	public virtual void SetAllUseCCD(bool InUseCCD) {}
	///<summary>Returns if any body in this component is currently awake and simulating.</summary>
	public virtual bool IsAnyRigidBodyAwake() { return default; }
	///<summary>Changes a member of the ResponseToChannels container for this PrimitiveComponent.</summary>
	public virtual void SetCollisionResponseToChannel(ECollisionChannel Channel,ECollisionResponse NewResponse) {}
	///<summary>Changes all ResponseToChannels container for this PrimitiveComponent. to be NewResponse</summary>
	public virtual void SetCollisionResponseToAllChannels(ECollisionResponse NewResponse) {}
	///<summary>Changes the current PhysMaterialOverride for this component.</summary>
	public virtual void SetPhysMaterialOverride(UPhysicalMaterial NewPhysMaterial) {}
	///<summary>Changes the value of CullDistance.</summary>
	public void SetCullDistance(float NewCullDistance) {}
	///<summary>Return true if the given Pawn can step up onto this component.</summary>
	public virtual bool CanCharacterStepUp(APawn Pawn) { return default; }
}
