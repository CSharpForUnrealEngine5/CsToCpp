namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A specialization of UNiagaraComponent that can act as a proxy for many other NiagaraComponents that have been culled by scalability.</summary>
[CppInclude("NiagaraCullProxyComponent.h")]
public partial class UNiagaraCullProxyComponent : UNiagaraComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Array of additional instance transforms. This component will be rendered at it&#39;s own transform and additionally at each of these transforms.</summary>
	public TArray<FNiagaraCulledComponentInfo> Instances;
}
