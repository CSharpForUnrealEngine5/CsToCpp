namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/ParticleSystemComponent.h")]
public partial class UFXSystemComponent : UPrimitiveComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Change a named boolean parameter, ParticleSystemComponent converts to float.</summary>
	public virtual void SetBoolParameter(string ParameterName,bool Param) {}
	///<summary>Change a named int parameter</summary>
	public virtual void SetIntParameter(string ParameterName,int Param) {}
	///<summary>Change a named float parameter</summary>
	public virtual void SetFloatParameter(string ParameterName,float Param) {}
	///<summary>Set a named vector instance parameter on this ParticleSystemComponent.</summary>
	public virtual void SetVectorParameter(string ParameterName,FVector Param) {}
	///<summary>Set a named color instance parameter on this ParticleSystemComponent.</summary>
	public virtual void SetColorParameter(string ParameterName,FLinearColor Param) {}
	///<summary>Set a named actor instance parameter on this ParticleSystemComponent.</summary>
	public virtual void SetActorParameter(string ParameterName,AActor Param) {}
	///<summary>Get the referenced FXSystem asset.</summary>
	public virtual UFXSystemAsset GetFXSystemAsset() { return default; }
	///<summary>Enables/Disables a sub-emitter</summary>
	public virtual void SetEmitterEnable(string EmitterName,bool bNewEnableState) {}
	///<summary>Set AutoAttachParent, AutoAttachSocketName, AutoAttachLocationRule, AutoAttachRotationRule, AutoAttachScaleRule to the specified parameters. Does not change bAutoManageAttachment; that must be set separately.</summary>
	public virtual void SetAutoAttachmentParameters(USceneComponent Parent,string SocketName,EAttachmentRule LocationRule,EAttachmentRule RotationRule,EAttachmentRule ScaleRule) {}
	///<summary>Sets whether we should automatically attach to AutoAttachParent when activated, and detach from our parent when completed.</summary>
	public virtual void SetUseAutoManageAttachment(bool bAutoManage) {}
	///<summary>Deactivates this system and releases it to the pool on completion.</summary>
	public virtual void ReleaseToPool() {}
}
