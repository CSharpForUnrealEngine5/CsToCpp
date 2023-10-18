namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>SkeletalMeshComponent is used to create an instance of an animated SkeletalMesh asset.</summary>
[CppInclude("Components/SkeletalMeshComponent.h")]
public partial class USkeletalMeshComponent : USkinnedMeshComponent {
	public static UClass StaticClass() {return default;}
	///<summary>SkeletalMeshAsset</summary>
	public USkeletalMesh SkeletalMeshAsset;
	///<summary>Set the SkeletalMesh rendered for this mesh.</summary>
	public void SetSkeletalMeshAsset(USkeletalMesh NewMesh) {}
	///<summary>Get the SkeletalMesh rendered for this mesh.</summary>
	public USkeletalMesh GetSkeletalMeshAsset() { return default; }
	///<summary>The blueprint for creating an AnimationScript.</summary>
	public UAnimBlueprint AnimationBlueprint_DEPRECATED;
	///<summary>AnimBlueprintGeneratedClass</summary>
	public UAnimBlueprintGeneratedClass AnimBlueprintGeneratedClass;
	///<summary>The AnimBlueprint class to use. Use &#39;SetAnimInstanceClass&#39; to change at runtime.</summary>
	public UClass AnimClass;
	///<summary>The active animation graph program instance.</summary>
	public UAnimInstance AnimScriptInstance;
	///<summary>SubInstances</summary>
	public TArray<UAnimInstance> SubInstances;
	///<summary>An instance created from the PostPhysicsBlueprint property of the skeletal mesh we&#39;re using,</summary>
	public UAnimInstance PostProcessAnimInstance;
	///<summary>Toggles whether the post process blueprint will run for this component</summary>
	public void ToggleDisablePostProcessBlueprint() {}
	///<summary>Gets whether the post process blueprint is currently disabled for this component</summary>
	public bool GetDisablePostProcessBlueprint() { return default; }
	///<summary>Sets whether the post process blueprint is currently running for this component.</summary>
	public void SetDisablePostProcessBlueprint(bool bInDisablePostProcess) {}
	///<summary>AnimationData</summary>
	public FSingleAnimationPlayData AnimationData;
	///<summary>Offset of the root bone from the reference pose. Used to offset bounding box.</summary>
	public FVector RootBoneTranslation;
	///<summary>If bEnableLineCheckWithBounds is true, scale the bounds by this value before doing line check.</summary>
	public FVector LineCheckBoundsScale;
	///<summary>Any running linked anim instances</summary>
	public TArray<UAnimInstance> LinkedInstances;
	///<summary>Cached BoneSpaceTransforms for Update Rate optimization.</summary>
	public TArray<FTransform> CachedBoneSpaceTransforms;
	///<summary>Cached SpaceBases for Update Rate optimization.</summary>
	public TArray<FTransform> CachedComponentSpaceTransforms;
	///<summary>Get float type attribute value.</summary>
	public bool GetFloatAttribute_Ref(FName BoneName,FName AttributeName,float OutValue,ECustomBoneAttributeLookup LookupType/*=ECustomBoneAttributeLookup.BoneOnly*/) { return default; }
	///<summary>Get FTransform type attribute value.</summary>
	public bool GetTransformAttribute_Ref(FName BoneName,FName AttributeName,FTransform OutValue,ECustomBoneAttributeLookup LookupType/*=ECustomBoneAttributeLookup.BoneOnly*/) { return default; }
	///<summary>Get integer type attribute value.</summary>
	public bool GetIntegerAttribute_Ref(FName BoneName,FName AttributeName,int OutValue,ECustomBoneAttributeLookup LookupType/*=ECustomBoneAttributeLookup.BoneOnly*/) { return default; }
	///<summary>Get string type attribute value.</summary>
	public bool GetStringAttribute_Ref(FName BoneName,FName AttributeName,string OutValue,ECustomBoneAttributeLookup LookupType/*=ECustomBoneAttributeLookup.BoneOnly*/) { return default; }
	///<summary>Get float type attribute value.</summary>
	public bool GetFloatAttribute(FName BoneName,FName AttributeName,float DefaultValue,float OutValue,ECustomBoneAttributeLookup LookupType/*=ECustomBoneAttributeLookup.BoneOnly*/) { return default; }
	///<summary>Get FTransform type attribute value.</summary>
	public bool GetTransformAttribute(FName BoneName,FName AttributeName,FTransform DefaultValue,FTransform OutValue,ECustomBoneAttributeLookup LookupType/*=ECustomBoneAttributeLookup.BoneOnly*/) { return default; }
	///<summary>Get integer type attribute value.</summary>
	public bool GetIntegerAttribute(FName BoneName,FName AttributeName,int DefaultValue,int OutValue,ECustomBoneAttributeLookup LookupType/*=ECustomBoneAttributeLookup.BoneOnly*/) { return default; }
	///<summary>Get string type attribute value.</summary>
	public bool GetStringAttribute(FName BoneName,FName AttributeName,string DefaultValue,string OutValue,ECustomBoneAttributeLookup LookupType/*=ECustomBoneAttributeLookup.BoneOnly*/) { return default; }
	///<summary>Used to scale speed of all animations on this skeletal mesh.</summary>
	public float GlobalAnimRateScale;
	///<summary>If we are running physics, should we update non-simulated bones based on the animation bone positions.</summary>
	public EKinematicBonesUpdateToPhysics KinematicBonesUpdateType;
	///<summary>Whether physics simulation updates component transform.</summary>
	public EPhysicsTransformUpdateMode PhysicsTransformUpdateMode;
	///<summary>Whether to use Animation Blueprint or play Single Animation Asset.</summary>
	public EAnimationMode AnimationMode;
	///<summary>Controls whether or not this component will evaluate its post process instance. The post-process</summary>
	public bool bDisablePostProcessBlueprint;
	///<summary>Controls whether blending in physics bones will refresh overlaps on this component, defaults to true but can be disabled in cases where we know anim-&gt;physics blending doesn&#39;t meaningfully change overlaps</summary>
	public bool bUpdateOverlapsOnAnimationFinalize;
	///<summary>If true, there is at least one body in the current PhysicsAsset with a valid bone in the current SkeletalMesh</summary>
	public bool bHasValidBodies;
	///<summary>Forces use of the physics bodies irrespective of whether they are simulated or using the physics blend weight</summary>
	public bool bBlendPhysics;
	///<summary>If true, simulate physics for this component on a dedicated server.</summary>
	public bool bEnablePhysicsOnDedicatedServer;
	///<summary>If true, then the physics bodies will be used to drive the skeletal mesh even when they are</summary>
	public bool bUpdateMeshWhenKinematic;
	///<summary>If we should pass joint position to joints each frame, so that they can be used by motorized joints to drive the</summary>
	public bool bUpdateJointsFromAnimation;
	///<summary>Toggles creation of cloth simulation. Distinct from the simulation toggle below in that, if off, avoids allocating</summary>
	public bool bAllowClothActors;
	///<summary>Disable cloth simulation and play original animation without simulation</summary>
	public bool bDisableClothSimulation;
	///<summary>Disable rigid body animation nodes and play original animation without simulation</summary>
	public bool bDisableRigidBodyAnimNode;
	///<summary>Disable animation curves for this component. If this is set true, no curves will be processed</summary>
	public bool bAllowAnimCurveEvaluation;
	///<summary>bDisableAnimCurves_DEPRECATED</summary>
	public bool bDisableAnimCurves_DEPRECATED;
	///<summary>can&#39;t collide with part of environment if total collision volumes exceed 16 capsules or 32 planes per convex</summary>
	public bool bCollideWithEnvironment;
	///<summary>can&#39;t collide with part of attached children if total collision volumes exceed 16 capsules or 32 planes per convex</summary>
	public bool bCollideWithAttachedChildren;
	///<summary>Forces the cloth simulation to constantly update its external collisions, at the expense of performance.</summary>
	public bool bForceCollisionUpdate;
	///<summary>bLocalSpaceSimulation</summary>
	public bool bLocalSpaceSimulation;
	///<summary>reset the clothing after moving the clothing position (called teleport)</summary>
	public bool bResetAfterTeleport;
	///<summary>Whether animation and world transform updates are deferred. If this is on, the kinematic bodies (scene query data) will not update until the next time the physics simulation is run</summary>
	public bool bDeferKinematicBoneUpdate;
	///<summary>Skips Ticking and Bone Refresh.</summary>
	public bool bNoSkeletonUpdate;
	///<summary>pauses this component&#39;s animations (doesn&#39;t tick them, but still refreshes bones)</summary>
	public bool bPauseAnims;
	///<summary>On InitAnim should we set to ref pose (if false use first tick of animation data). If enabled, takes precedence over UAnimationSettings::bTickAnimationOnSkeletalMeshInit</summary>
	public bool bUseRefPoseOnInitAnim;
	///<summary>Uses skinned data for collision data.</summary>
	public bool bEnablePerPolyCollision;
	///<summary>If true, force the mesh into the reference pose - is an optimization.</summary>
	public bool bForceRefpose;
	///<summary>If true TickPose() will not be called from the Component&#39;s TickComponent function.</summary>
	public bool bOnlyAllowAutonomousTickPose;
	///<summary>True if calling TickPose() from Autonomous networking updates. See ACharacter.</summary>
	public bool bIsAutonomousTickPose;
	///<summary>If bForceRefPose was set last tick.</summary>
	public bool bOldForceRefPose;
	///<summary>Bool that enables debug drawing of the skeleton before it is passed to the physics. Useful for debugging animation-driven physics.</summary>
	public bool bShowPrePhysBones;
	///<summary>If false, indicates that on the next call to UpdateSkelPose the RequiredBones array should be recalculated.</summary>
	public bool bRequiredBonesUpToDate;
	///<summary>If true, AnimTree has been initialised.</summary>
	public bool bAnimTreeInitialised;
	///<summary>If true, the Location of this Component will be included into its bounds calculation</summary>
	public bool bIncludeComponentLocationIntoBounds;
	///<summary>If true, line checks will test against the bounding box of this skeletal mesh component and return a hit if there is a collision.</summary>
	public bool bEnableLineCheckWithBounds;
	///<summary>If true, propagates calls to ApplyAnimationCurvesToComponent for follower components, only needed if follower components do not tick themselves</summary>
	public bool bPropagateCurvesToFollowers;
	///<summary>Whether to skip UpdateKinematicBonesToAnim() when interpolating. Kinematic bones are updated to the target interpolation pose only on ticks when they are evaluated.</summary>
	public bool bSkipKinematicUpdateWhenInterpolating;
	///<summary>Whether to skip bounds update when interpolating. Bounds are updated to the target interpolation pose only on ticks when they are evaluated.</summary>
	public bool bSkipBoundsUpdateWhenInterpolating;
	///<summary>If true, this will Tick until disabled</summary>
	public bool bUpdateAnimationInEditor;
	///<summary>If true, will play cloth in editor</summary>
	public bool bUpdateClothInEditor;
	///<summary>If true, DefaultAnimatingRigOverride will be used. If false, use the DefaultAnimatingRig in the SkeletalMesh</summary>
	public bool bOverrideDefaultAnimatingRig;
	///<summary>bNeedsQueuedAnimEventsDispatched</summary>
	public bool bNeedsQueuedAnimEventsDispatched;
	///<summary>Cache AnimCurveUidVersion from Skeleton and this will be used to identify if it needs to be updated</summary>
	public ushort CachedAnimCurveUidVersion;
	///<summary>weight to blend between simulated results and key-framed positions</summary>
	public float ClothBlendWeight;
	///<summary>Whether we should stall the Cloth tick task until the cloth simulation is complete. This is required if we want up-to-date</summary>
	public bool bWaitForParallelClothTask;
	///<summary>Whether the FilteredAnimCurves list is an allow or deny list</summary>
	public bool bFilteredAnimCurvesIsAllowList;
	///<summary>Cache curve metadata from mesh and this will be used to identify if it needs to be updated</summary>
	public ushort CachedMeshCurveMetaDataVersion;
	///<summary>You can choose to disable certain curves if you prefer.</summary>
	public TArray<FName> FilteredAnimCurves;
	///<summary>Used for per poly collision. In 99% of cases you will be better off using a Physics Asset.</summary>
	public UBodySetup BodySetup;
	///<summary>ClothMaxDistanceScale</summary>
	public float ClothMaxDistanceScale;
	///<summary>Notification when constraint is broken.</summary>
	public FConstraintBrokenSignature OnConstraintBroken;
	///<summary>Notification when constraint plasticity drive target changes.</summary>
	public FPlasticDeformationEventSignature OnPlasticDeformation;
	///<summary>Class of the object responsible for</summary>
	public UClass ClothingSimulationFactory;
	///<summary>Set the anim instance class. Clears and re-initializes the anim instance with the new class and sets animation mode to &#39;AnimationBlueprint&#39;</summary>
	public virtual void SetAnimClass(UClass NewClass) {}
	///<summary>Get the anim instance class via getter callable by sequencer.</summary>
	public UClass GetAnimClass() { return default; }
	///<summary>Returns the animation instance that is driving the class (if available). This is typically an instance of</summary>
	public UAnimInstance GetAnimInstance() { return default; }
	///<summary>Returns the active post process instance is one is available. This is set on the mesh that this</summary>
	public UAnimInstance GetPostProcessInstance() { return default; }
	///<summary>Returns the a tagged linked instance node. If no linked instances are found or none are tagged with the</summary>
	public UAnimInstance GetLinkedAnimGraphInstanceByTag(FName InTag) { return default; }
	///<summary>GetLinkedAnimGraphInstancesByTag</summary>
	public void GetLinkedAnimGraphInstancesByTag(FName InTag,TArray<UAnimInstance> OutLinkedInstances) {}
	///<summary>Runs through all nodes, attempting to find linked instance by name/tag, then sets the class of each node if the tag matches</summary>
	public void LinkAnimGraphByTag(FName InTag,UClass InClass) {}
	///<summary>Runs through all layer nodes, attempting to find layer nodes that are implemented by the specified class, then sets up a linked instance of the class for each.</summary>
	public void LinkAnimClassLayers(UClass InClass) {}
	///<summary>Runs through all layer nodes, attempting to find layer nodes that are currently running the specified class, then resets each to its default value.</summary>
	public void UnlinkAnimClassLayers(UClass InClass) {}
	///<summary>Gets the layer linked instance corresponding to the specified group</summary>
	public UAnimInstance GetLinkedAnimLayerInstanceByGroup(FName InGroup) { return default; }
	///<summary>Gets the first layer linked instance corresponding to the specified class</summary>
	public UAnimInstance GetLinkedAnimLayerInstanceByClass(UClass InClass) { return default; }
	///<summary>Returns whether there are any valid instances to run, currently this means whether we have</summary>
	public bool HasValidAnimationInstance() { return default; }
	///<summary>Informs any active anim instances (main instance, linked instances, post instance) that a dynamics reset is required</summary>
	public void ResetAnimInstanceDynamics(ETeleportType InTeleportType/*=ETeleportType.ResetPhysics*/) {}
	///<summary>Set the Animation Mode</summary>
	public void SetAnimationMode(EAnimationMode InAnimationMode,bool bForceInitAnimScriptInstance/*=true*/) {}
	///<summary>GetAnimationMode</summary>
	public EAnimationMode GetAnimationMode() { return default; }
	///<summary>Animation play functions</summary>
	public void PlayAnimation(UAnimationAsset NewAnimToPlay,bool bLooping) {}
	///<summary>Animation play functions</summary>
	public void SetAnimation(UAnimationAsset NewAnimToPlay) {}
	///<summary>Animation play functions</summary>
	public void Play(bool bLooping) {}
	///<summary>Animation play functions</summary>
	public void Stop() {}
	///<summary>Animation play functions</summary>
	public bool IsPlaying() { return default; }
	///<summary>Animation play functions</summary>
	public void SetPosition(float InPos,bool bFireNotifies/*=true*/) {}
	///<summary>Animation play functions</summary>
	public float GetPosition() { return default; }
	///<summary>Animation play functions</summary>
	public void SetPlayRate(float Rate) {}
	///<summary>Animation play functions</summary>
	public float GetPlayRate() { return default; }
	///<summary>This overrides current AnimationData parameter in the SkeletalMeshComponent. This will serialize when the component serialize</summary>
	public void OverrideAnimationData(UAnimationAsset InAnimToPlay,bool bIsLooping/*=true*/,bool bIsPlaying/*=true*/,float Position/*=0.0f*/,float PlayRate/*=1.0f*/) {}
	///<summary>Set Morph Target with Name and Value(0-1)</summary>
	public void SetMorphTarget(FName MorphTargetName,float Value,bool bRemoveZeroWeight/*=true*/) {}
	///<summary>Clear all Morph Target that are set to this mesh</summary>
	public void ClearMorphTargets() {}
	///<summary>Get Morph target with given name</summary>
	public float GetMorphTarget(FName MorphTargetName) { return default; }
	///<summary>Takes a snapshot of this skeletal mesh component&#39;s pose and saves it to the specified snapshot.</summary>
	public void SnapshotPose(FPoseSnapshot Snapshot) {}
	///<summary>Sets whether cloth assets should be created/simulated in this component.</summary>
	public void SetAllowClothActors(bool bInAllow) {}
	///<summary>GetAllowClothActors</summary>
	public bool GetAllowClothActors() { return default; }
	///<summary>Get/Set the max distance scale of clothing mesh vertices</summary>
	public float GetClothMaxDistanceScale() { return default; }
	///<summary>SetClothMaxDistanceScale</summary>
	public void SetClothMaxDistanceScale(float Scale) {}
	///<summary>Used to indicate we should force &#39;teleport&#39; during the next call to UpdateClothState,</summary>
	public void ForceClothNextUpdateTeleport() {}
	///<summary>Used to indicate we should force &#39;teleport and reset&#39; during the next call to UpdateClothState.</summary>
	public void ForceClothNextUpdateTeleportAndReset() {}
	///<summary>Stops simulating clothing, but does not show clothing ref pose. Keeps the last known simulation state</summary>
	public void SuspendClothingSimulation() {}
	///<summary>Resumes a previously suspended clothing simulation, teleporting the clothing on the next tick</summary>
	public void ResumeClothingSimulation() {}
	///<summary>Gets whether or not the clothing simulation is currently suspended</summary>
	public bool IsClothingSimulationSuspended() { return default; }
	///<summary>Reset the teleport mode of a next update to &#39;Continuous&#39;</summary>
	public void ResetClothTeleportMode() {}
	///<summary>If this component has a valid LeaderPoseComponent then this function makes cloth items on the follower component</summary>
	public void BindClothToLeaderPoseComponent() {}
	///<summary>If this component has a valid LeaderPoseComponent and has previously had its cloth bound to the</summary>
	public void UnbindClothFromLeaderPoseComponent(bool bRestoreSimulationSpace/*=true*/) {}
	///<summary>Sets whether or not to allow rigid body animation nodes for this component</summary>
	public void SetAllowRigidBodyAnimNode(bool bInAllow,bool bReinitAnim/*=true*/) {}
	///<summary>GetAllowRigidBodyAnimNode</summary>
	public bool GetAllowRigidBodyAnimNode() { return default; }
	///<summary>Sets whether or not to force tick component in order to update animation and refresh transform for this component</summary>
	public void SetUpdateAnimationInEditor(bool NewUpdateState) {}
	///<summary>Sets whether or not to animate cloth in the editor. Requires Update Animation In Editor to also be true.</summary>
	public void SetUpdateClothInEditor(bool NewUpdateState) {}
	///<summary>SetDisableAnimCurves</summary>
	public void SetDisableAnimCurves(bool bInDisableAnimCurves) {}
	///<summary>GetDisableAnimCurves</summary>
	public bool GetDisableAnimCurves() { return default; }
	///<summary>SetAllowAnimCurveEvaluation</summary>
	public void SetAllowAnimCurveEvaluation(bool bInAllow) {}
	///<summary>GetAllowedAnimCurveEvaluate</summary>
	public bool GetAllowedAnimCurveEvaluate() { return default; }
	///<summary>AllowAnimCurveEvaluation</summary>
	public void AllowAnimCurveEvaluation(FName NameOfCurve,bool bAllow) {}
	///<summary>By reset, it will allow all the curves to be evaluated</summary>
	public void ResetAllowedAnimCurveEvaluation() {}
	///<summary>resets, and then only allow the following list to be allowed/disallowed</summary>
	public void SetAllowedAnimCurvesEvaluation(TArray<FName> List,bool bAllow) {}
	///<summary>Gets the teleportation rotation threshold.</summary>
	public float GetTeleportRotationThreshold() { return default; }
	///<summary>Sets the teleportation rotation threshold.</summary>
	public void SetTeleportRotationThreshold(float Threshold) {}
	///<summary>Gets the teleportation distance threshold.</summary>
	public float GetTeleportDistanceThreshold() { return default; }
	///<summary>Sets the teleportation distance threshold.</summary>
	public void SetTeleportDistanceThreshold(float Threshold) {}
	///<summary>Conduct teleportation if the character&#39;s movement is greater than this threshold in 1 frame.</summary>
	public float TeleportDistanceThreshold;
	///<summary>Rotation threshold in degrees, ranging from 0 to 180.</summary>
	public float TeleportRotationThreshold;
	///<summary>Can&#39;t rely on time value, because those may be affected by dilation and whether or not</summary>
	public uint LastPoseTickFrame;
	///<summary>Get the current interactor for a clothing simulation, if the current simulation supports runtime interaction.</summary>
	public UClothingSimulationInteractor GetClothingSimulationInteractor() { return default; }
	///<summary>Object responsible for interacting with the clothing simulation.</summary>
	public UClothingSimulationInteractor ClothingInteractor;
	///<summary>Broadcast when the components anim instance is initialized</summary>
	public FOnAnimInitialized OnAnimInitialized;
	///<summary>Changes the value of bNotifyRigidBodyCollision for a given body</summary>
	public virtual void SetBodyNotifyRigidBodyCollision(bool bNewNotifyRigidBodyCollision,FName BoneName/*=NAME_None*/) {}
	///<summary>Changes the value of bNotifyRigidBodyCollision on all bodies below a given bone</summary>
	public virtual void SetNotifyRigidBodyCollisionBelow(bool bNewNotifyRigidBodyCollision,FName BoneName/*=NAME_None*/,bool bIncludeSelf/*=true*/) {}
	///<summary>Enables or disables gravity for the given bone.</summary>
	public void SetEnableBodyGravity(bool bEnableGravity,FName BoneName) {}
	///<summary>Checks whether or not gravity is enabled on the given bone.</summary>
	public bool IsBodyGravityEnabled(FName BoneName) { return default; }
	///<summary>Enables or disables gravity to all bodies below the given bone.</summary>
	public void SetEnableGravityOnAllBodiesBelow(bool bEnableGravity,FName BoneName,bool bIncludeSelf/*=true*/) {}
	///<summary>Given a world position, find the closest point on the physics asset. Note that this is independent of collision and welding. This is based purely on animation position</summary>
	public bool K2_GetClosestPointOnPhysicsAsset(FVector WorldPosition,FVector ClosestWorldPosition,FVector Normal,FName BoneName,float Distance) { return default; }
	///<summary>Returns the mass (in kg) of the given bone</summary>
	public float GetBoneMass(FName BoneName/*=NAME_None*/,bool bScaleMass/*=true*/) { return default; }
	///<summary>Returns the center of mass of the skeletal mesh, instead of the root body&#39;s location</summary>
	public FVector GetSkeletalCenterOfMass() { return default; }
	///<summary>Add a force to all rigid bodies below.</summary>
	public virtual void AddForceToAllBodiesBelow(FVector Force,FName BoneName/*=NAME_None*/,bool bAccelChange/*=false*/,bool bIncludeSelf/*=true*/) {}
	///<summary>Add impulse to all single rigid bodies below. Good for one time instant burst.</summary>
	public virtual void AddImpulseToAllBodiesBelow(FVector Impulse,FName BoneName/*=NAME_None*/,bool bVelChange/*=false*/,bool bIncludeSelf/*=true*/) {}
	///<summary>Terminate physics on all bodies below the named bone, effectively disabling collision forever. If you terminate, you won&#39;t be able to re-init later.</summary>
	public void TermBodiesBelow(FName ParentBoneName) {}
	///<summary>Set bSimulatePhysics to true for all bone bodies. Does not change the component bSimulatePhysics flag.</summary>
	public void SetAllBodiesSimulatePhysics(bool bNewSimulate) {}
	///<summary>This is global set up for setting physics blend weight</summary>
	public void SetPhysicsBlendWeight(float PhysicsBlendWeight) {}
	///<summary>Disable physics blending of bones *</summary>
	public void SetEnablePhysicsBlending(bool bNewBlendPhysics) {}
	///<summary>[WARNING: Chaos Only]</summary>
	public void SetAllBodiesBelowPhysicsDisabled(FName InBoneName,bool bDisabled,bool bIncludeSelf/*=true*/) {}
	///<summary>set the linear velocity of the child bodies to match that of the given parent bone</summary>
	public void SetAllBodiesBelowLinearVelocity(FName InBoneName,FVector LinearVelocity,bool bIncludeSelf/*=true*/) {}
	///<summary>GetBoneLinearVelocity</summary>
	public FVector GetBoneLinearVelocity(FName InBoneName) { return default; }
	///<summary>Set all of the bones below passed in bone to be simulated</summary>
	public void SetAllBodiesBelowSimulatePhysics(FName InBoneName,bool bNewSimulate,bool bIncludeSelf/*=true*/) {}
	///<summary>Allows you to reset bodies Simulate state based on where bUsePhysics is set to true in the BodySetup.</summary>
	public void ResetAllBodiesSimulatePhysics() {}
	///<summary>SetAllBodiesPhysicsBlendWeight</summary>
	public void SetAllBodiesPhysicsBlendWeight(float PhysicsBlendWeight,bool bSkipCustomPhysicsType/*=false*/) {}
	///<summary>Set all of the bones below passed in bone to be simulated</summary>
	public void SetAllBodiesBelowPhysicsBlendWeight(FName InBoneName,float PhysicsBlendWeight,bool bSkipCustomPhysicsType/*=false*/,bool bIncludeSelf/*=true*/) {}
	///<summary>Accumulate AddPhysicsBlendWeight to physics blendweight for all of the bones below passed in bone to be simulated</summary>
	public void AccumulateAllBodiesBelowPhysicsBlendWeight(FName InBoneName,float AddPhysicsBlendWeight,bool bSkipCustomPhysicsType/*=false*/) {}
	///<summary>Enable or Disable AngularPositionDrive. If motor is in SLERP mode it will be turned on if either EnableSwingDrive OR EnableTwistDrive are enabled. In Twist and Swing mode the twist and the swing can be controlled individually.</summary>
	public void SetAllMotorsAngularPositionDrive(bool bEnableSwingDrive,bool bEnableTwistDrive,bool bSkipCustomPhysicsType/*=false*/) {}
	///<summary>Enable or Disable AngularVelocityDrive. If motor is in SLERP mode it will be turned on if either EnableSwingDrive OR EnableTwistDrive are enabled. In Twist and Swing mode the twist and the swing can be controlled individually.</summary>
	public void SetAllMotorsAngularVelocityDrive(bool bEnableSwingDrive,bool bEnableTwistDrive,bool bSkipCustomPhysicsType/*=false*/) {}
	///<summary>Set Angular Drive motors params for all constraint instances</summary>
	public void SetAllMotorsAngularDriveParams(float InSpring,float InDamping,float InForceLimit,bool bSkipCustomPhysicsType/*=false*/) {}
	///<summary>Sets the constraint profile properties (limits, motors, etc...) to match the constraint profile as defined in the physics asset. If profile name is not found the joint is set to use the default constraint profile.</summary>
	public void SetConstraintProfile(FName JointName,FName ProfileName,bool bDefaultIfNotFound/*=false*/) {}
	///<summary>Sets the constraint profile properties (limits, motors, etc...) to match the constraint profile as defined in the physics asset for all constraints. If profile name is not found the joint is set to use the default constraint profile.</summary>
	public void SetConstraintProfileForAll(FName ProfileName,bool bDefaultIfNotFound/*=false*/) {}
	///<summary>Find Constraint Name from index</summary>
	public FName FindConstraintBoneName(int ConstraintIndex) { return default; }
	///<summary>Break a constraint off a Gore mesh.</summary>
	public void BreakConstraint(FVector Impulse,FVector HitLocation,FName InBoneName) {}
	///<summary>Gets a constraint by its name</summary>
	public FConstraintInstanceAccessor GetConstraintByName(FName ConstraintName,bool bIncludesTerminated) { return default; }
	///<summary>Gets all the constraints</summary>
	public void GetConstraints(bool bIncludesTerminated,TArray<FConstraintInstanceAccessor> OutConstraints) {}
	///<summary>Gets all the constraints attached to a body</summary>
	public void GetConstraintsFromBody(FName BodyName,bool bParentConstraints,bool bChildConstraints,bool bIncludesTerminated,TArray<FConstraintInstanceAccessor> OutConstraints) {}
	///<summary>Sets the Angular Motion Ranges for a named constraint</summary>
	public void SetAngularLimits(FName InBoneName,float Swing1LimitAngle,float TwistLimitAngle,float Swing2LimitAngle) {}
	///<summary>Gets the current Angular state for a named bone constraint</summary>
	public void GetCurrentJointAngles(FName InBoneName,float Swing1Angle,float TwistAngle,float Swing2Angle) {}
	///<summary>these are deprecated variables from removing SingleAnimSkeletalComponent</summary>
	public UAnimSequence SequenceToPlay_DEPRECATED;
	///<summary>The default sequence to play on this skeletal mesh</summary>
	public UAnimationAsset AnimToPlay_DEPRECATED;
	///<summary>Default setting for looping for SequenceToPlay. This is not current state of looping.</summary>
	public bool bDefaultLooping_DEPRECATED;
	///<summary>Default setting for playing for SequenceToPlay. This is not current state of playing.</summary>
	public bool bDefaultPlaying_DEPRECATED;
	///<summary>Default setting for position of SequenceToPlay to play.</summary>
	public float DefaultPosition_DEPRECATED;
	///<summary>Default setting for playrate of SequenceToPlay to play.</summary>
	public float DefaultPlayRate_DEPRECATED;
	///<summary>Default Animating Rig to Use if bOverrideDefaultAnimatingRig is true</summary>
	public TSoftObjectPtr<UObject> DefaultAnimatingRigOverride;
	///<summary>SetDefaultAnimatingRigOverride</summary>
	public void SetDefaultAnimatingRigOverride(TSoftObjectPtr<UObject> InAnimatingRig) {}
	///<summary>GetDefaultAnimatingRigOverride</summary>
	public TSoftObjectPtr<UObject> GetDefaultAnimatingRigOverride() { return default; }
	///<summary>GetDefaultAnimatingRig</summary>
	public TSoftObjectPtr<UObject> GetDefaultAnimatingRig() { return default; }
}
