#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/ParticleSystemComponent.h")]
public partial class UFXSystemComponent : UPrimitiveComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Change a named boolean parameter, ParticleSystemComponent converts to float.</summary>
	public  void SetBoolParameter(string ParameterName,bool Param) {}
	///<summary>Change a named int parameter</summary>
	public  void SetIntParameter(string ParameterName,int Param) {}
	///<summary>Change a named float parameter</summary>
	public  void SetFloatParameter(string ParameterName,float Param) {}
	///<summary>Set a named vector instance parameter on this ParticleSystemComponent.</summary>
	public  void SetVectorParameter(string ParameterName,FVector Param) {}
	///<summary>Set a named color instance parameter on this ParticleSystemComponent.</summary>
	public  void SetColorParameter(string ParameterName,FLinearColor Param) {}
	///<summary>Set a named actor instance parameter on this ParticleSystemComponent.</summary>
	public  void SetActorParameter(string ParameterName,AActor Param) {}
	///<summary>Get the referenced FXSystem asset.</summary>
	public  UFXSystemAsset GetFXSystemAsset() { return default; }
	///<summary>Enables/Disables a sub-emitter</summary>
	public  void SetEmitterEnable(string EmitterName,bool bNewEnableState) {}
	///<summary>Set AutoAttachParent, AutoAttachSocketName, AutoAttachLocationRule, AutoAttachRotationRule, AutoAttachScaleRule to the specified parameters. Does not change bAutoManageAttachment; that must be set separately.</summary>
	public  void SetAutoAttachmentParameters(USceneComponent Parent,string SocketName,EAttachmentRule LocationRule,EAttachmentRule RotationRule,EAttachmentRule ScaleRule) {}
	///<summary>Sets whether we should automatically attach to AutoAttachParent when activated, and detach from our parent when completed.</summary>
	public  void SetUseAutoManageAttachment(bool bAutoManage) {}
	///<summary>Deactivates this system and releases it to the pool on completion.</summary>
	public  void ReleaseToPool() {}
}
