namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data interface that gives you access to actor &amp; component information.</summary>
[CppInclude("DataInterface/NiagaraDataInterfaceActorComponent.h")]
public partial class UNiagaraDataInterfaceActorComponent : UNiagaraDataInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Controls how we find the actor / component we want to bind to.</summary>
	public ENDIActorComponentSourceMode SourceMode;
	///<summary>, EditConditionHides))</summary>
	public int LocalPlayerIndex;
	///<summary>Optional source actor to use, if the user parameter binding is valid this will be ignored.</summary>
	public TLazyObjectPtr<AActor> SourceActor;
	///<summary>User parameter binding to use, overrides SourceActor.  Can be set by Blueprint, etc.</summary>
	public FNiagaraUserParameterBinding ActorOrComponentParameter;
	///<summary>When this option is disabled, we use the previous frame&#39;s data for the skeletal mesh and can often issue the simulation early. This greatly</summary>
	public bool bRequireCurrentFrameData;
}
