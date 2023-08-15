namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A particle emitter.</summary>
[CppInclude("Particles/ParticleSystemComponent.h")]
public partial class UParticleSystemComponent : UFXSystemComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Template</summary>
	public UParticleSystem Template;
	///<summary>EmitterMaterials</summary>
	public TArray<UMaterialInterface> EmitterMaterials;
	///<summary>The skeletal mesh components used with the socket location module.</summary>
	public TArray<USkeletalMeshComponent> SkelMeshComponents;
	///<summary>bResetOnDetach</summary>
	public bool bResetOnDetach;
	///<summary>whether to update the particle system on dedicated servers</summary>
	public bool bUpdateOnDedicatedServer;
	///<summary>If true, this Particle System will be available for recycling after it has completed. Auto-destroyed systems cannot be recycled.</summary>
	public bool bAllowRecycling;
	///<summary>True if we should automatically attach to AutoAttachParent when activated, and detach from our parent when completed.</summary>
	public bool bAutoManageAttachment;
	///<summary>Option for how we handle bWeldSimulatedBodies when we attach to the AutoAttachParent, if bAutoManageAttachment is true.</summary>
	public bool bAutoAttachWeldSimulatedBodies;
	///<summary>bWarmingUp</summary>
	public bool bWarmingUp;
	///<summary>indicates that the component&#39;s LODMethod overrides the Template&#39;s</summary>
	public bool bOverrideLODMethod;
	///<summary>Flag indicating that dynamic updating of render data should NOT occur during Tick.</summary>
	public bool bSkipUpdateDynamicDataDuringTick;
	///<summary>The method of LOD level determination to utilize for this particle system</summary>
	public ParticleSystemLODMethod LODMethod;
	///<summary>The significance this component requires of it&#39;s emitters for them to be enabled.</summary>
	public EParticleSignificanceLevel RequiredSignificance;
	///<summary>Array holding name instance parameters for this ParticleSystemComponent.</summary>
	public TArray<FParticleSysParam> InstanceParameters;
	///<summary>OnParticleSpawn</summary>
	public FParticleSpawnSignature OnParticleSpawn;
	///<summary>OnParticleBurst</summary>
	public FParticleBurstSignature OnParticleBurst;
	///<summary>OnParticleDeath</summary>
	public FParticleDeathSignature OnParticleDeath;
	///<summary>OnParticleCollide</summary>
	public FParticleCollisionSignature OnParticleCollide;
	///<summary>bOldPositionValid</summary>
	public bool bOldPositionValid;
	///<summary>OldPosition</summary>
	public FVector OldPosition;
	///<summary>PartSysVelocity</summary>
	public FVector PartSysVelocity;
	///<summary>WarmupTime</summary>
	public float WarmupTime;
	///<summary>WarmupTickRate</summary>
	public float WarmupTickRate;
	///<summary>Number of seconds of emitter not being rendered that need to pass before it</summary>
	public float SecondsBeforeInactive;
	///<summary>Time between forced UpdateTransforms for systems that use dynamically calculated bounds,</summary>
	public float MaxTimeBeforeForceUpdateTransform;
	///<summary>INTERNAL. Used by the editor to set the LODLevel</summary>
	public int EditorLODLevel;
	///<summary>Used for applying Cascade&#39;s detail mode setting to in-level particle systems</summary>
	public int EditorDetailMode;
	///<summary>Array of replay clips for this particle system component.  These are serialized to disk.  You really should never add anything to this in the editor.  It&#39;s exposed so that you can delete clips if you need to, but be careful when doing so!</summary>
	public TArray<UParticleSystemReplay> ReplayClips;
	///<summary>Scales DeltaTime in UParticleSystemComponent::Tick(...)</summary>
	public float CustomTimeDilation;
	///<summary>Component we automatically attach to when activated, if bAutoManageAttachment is true.</summary>
	public TWeakObjectPtr<USceneComponent> AutoAttachParent;
	///<summary>Socket we automatically attach to on the AutoAttachParent, if bAutoManageAttachment is true.</summary>
	public FName AutoAttachSocketName;
	///<summary>DEPRECATED: Options for how we handle our location when we attach to the AutoAttachParent, if bAutoManageAttachment is true.</summary>
	public EAttachLocation AutoAttachLocationType_DEPRECATED;
	///<summary>Options for how we handle our location when we attach to the AutoAttachParent, if bAutoManageAttachment is true.</summary>
	public EAttachmentRule AutoAttachLocationRule;
	///<summary>Options for how we handle our rotation when we attach to the AutoAttachParent, if bAutoManageAttachment is true.</summary>
	public EAttachmentRule AutoAttachRotationRule;
	///<summary>Options for how we handle our scale when we attach to the AutoAttachParent, if bAutoManageAttachment is true.</summary>
	public EAttachmentRule AutoAttachScaleRule;
	///<summary>DEPRECATED: Set AutoAttachParent, AutoAttachSocketName, AutoAttachLocationType to the specified parameters. Does not change bAutoManageAttachment; that must be set separately.</summary>
	public void SetAutoAttachParams(USceneComponent Parent,FName SocketName/*=NAME_None*/,EAttachLocation LocationType/*=EAttachLocation.KeepRelativeOffset*/) {}
	///<summary>Called when the particle system is done</summary>
	public FOnSystemFinished OnSystemFinished;
	///<summary>Set the beam end point</summary>
	public virtual void SetBeamEndPoint(int EmitterIndex,FVector NewEndPoint) {}
	///<summary>Set the beam source point</summary>
	public virtual void SetBeamSourcePoint(int EmitterIndex,FVector NewSourcePoint,int SourceIndex) {}
	///<summary>Set the beam source tangent</summary>
	public virtual void SetBeamSourceTangent(int EmitterIndex,FVector NewTangentPoint,int SourceIndex) {}
	///<summary>Set the beam source strength</summary>
	public virtual void SetBeamSourceStrength(int EmitterIndex,float NewSourceStrength,int SourceIndex) {}
	///<summary>Set the beam target point</summary>
	public virtual void SetBeamTargetPoint(int EmitterIndex,FVector NewTargetPoint,int TargetIndex) {}
	///<summary>Set the beam target tangent</summary>
	public virtual void SetBeamTargetTangent(int EmitterIndex,FVector NewTangentPoint,int TargetIndex) {}
	///<summary>Set the beam target strength</summary>
	public virtual void SetBeamTargetStrength(int EmitterIndex,float NewTargetStrength,int TargetIndex) {}
	///<summary>Get the beam end point</summary>
	public virtual bool GetBeamEndPoint(int EmitterIndex,FVector OutEndPoint) { return default; }
	///<summary>Get the beam source point</summary>
	public virtual bool GetBeamSourcePoint(int EmitterIndex,int SourceIndex,FVector OutSourcePoint) { return default; }
	///<summary>Get the beam source tangent</summary>
	public virtual bool GetBeamSourceTangent(int EmitterIndex,int SourceIndex,FVector OutTangentPoint) { return default; }
	///<summary>Get the beam source strength</summary>
	public virtual bool GetBeamSourceStrength(int EmitterIndex,int SourceIndex,float OutSourceStrength) { return default; }
	///<summary>Get the beam target point</summary>
	public virtual bool GetBeamTargetPoint(int EmitterIndex,int TargetIndex,FVector OutTargetPoint) { return default; }
	///<summary>Get the beam target tangent</summary>
	public virtual bool GetBeamTargetTangent(int EmitterIndex,int TargetIndex,FVector OutTangentPoint) { return default; }
	///<summary>Get the beam target strength</summary>
	public virtual bool GetBeamTargetStrength(int EmitterIndex,int TargetIndex,float OutTargetStrength) { return default; }
	///<summary>Set a named material instance parameter on this ParticleSystemComponent.</summary>
	public void SetMaterialParameter(FName ParameterName,UMaterialInterface Param) {}
	///<summary>Change the ParticleSystem used by this ParticleSystemComponent</summary>
	public void SetTemplate(UParticleSystem NewTemplate) {}
	///<summary>Get the current number of active particles in this system</summary>
	public int GetNumActiveParticles() { return default; }
	///<summary>Begins all trail emitters in this component.</summary>
	public void BeginTrails(FName InFirstSocketName,FName InSecondSocketName,ETrailWidthMode InWidthMode,float InWidth) {}
	///<summary>Ends all trail emitters in this component.</summary>
	public void EndTrails() {}
	///<summary>Sets the defining data for all trails in this component.</summary>
	public void SetTrailSourceData(FName InFirstSocketName,FName InSecondSocketName,ETrailWidthMode InWidthMode,float InWidth) {}
	///<summary>Creates a Dynamic Material Instance for the specified named material override, optionally from the supplied material.</summary>
	public virtual UMaterialInstanceDynamic CreateNamedDynamicMaterialInstance(FName InName,UMaterialInterface SourceMaterial/*=NULL*/) { return default; }
	///<summary>Returns a named material. If this named material is not found, returns NULL.</summary>
	public virtual UMaterialInterface GetNamedMaterial(FName InName) { return default; }
	///<summary>Record a kismet event.</summary>
	public void GenerateParticleEvent(FName InEventName,float InEmitterTime,FVector InLocation,FVector InDirection,FVector InVelocity) {}
}
