#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraCullProxyComponent.h")]
///<summary>A specialization of UNiagaraComponent that can act as a proxy for many other NiagaraComponents that have been culled by scalability.</summary>
public partial class UNiagaraCullProxyComponent : UNiagaraComponent {
// NiagaraCullProxyComponent
	public TArray<FNiagaraCulledComponentInfo> Instances;
}
