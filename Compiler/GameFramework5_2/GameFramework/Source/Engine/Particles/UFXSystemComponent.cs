#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/ParticleSystemComponent.h")]
public partial class UFXSystemComponent : UPrimitiveComponent {
// FXSystemComponent
	public  void SetBoolParameter(string ParameterName,bool Param) {}
	public  void SetIntParameter(string ParameterName,int Param) {}
	public  void SetFloatParameter(string ParameterName,float Param) {}
	public  void SetVectorParameter(string ParameterName,FVector Param) {}
	public  void SetColorParameter(string ParameterName,FLinearColor Param) {}
	public  void SetActorParameter(string ParameterName,AActor Param) {}
	public  UFXSystemAsset GetFXSystemAsset() { return default; }
	public  void SetEmitterEnable(string EmitterName,bool bNewEnableState) {}
	public  void SetAutoAttachmentParameters(USceneComponent Parent,string SocketName,EAttachmentRule LocationRule,EAttachmentRule RotationRule,EAttachmentRule ScaleRule) {}
	public  void SetUseAutoManageAttachment(bool bAutoManage) {}
	public  void ReleaseToPool() {}
}
