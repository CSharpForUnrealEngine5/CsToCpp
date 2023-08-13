namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraComponentPool.h")]
public partial class UNiagaraComponentPool : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>WorldParticleSystemPools</summary>
	public TMap<UNiagaraSystem,FNCPool> WorldParticleSystemPools;
}
