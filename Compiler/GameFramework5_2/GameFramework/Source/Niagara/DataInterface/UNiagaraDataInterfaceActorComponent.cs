#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataInterface/NiagaraDataInterfaceActorComponent.h")]
///<summary>Data interface that gives you access to actor & component information.</summary>
public partial class UNiagaraDataInterfaceActorComponent : UNiagaraDataInterface {
// NiagaraDataInterfaceActorComponent
	public bool bRequireCurrentFrameData;
	public ENDIActorComponentSourceMode SourceMode;
	public int LocalPlayerIndex;
	public TLazyObjectPtr<AActor> SourceActor;
	public FNiagaraUserParameterBinding ActorOrComponentParameter;
}
