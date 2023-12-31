namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct combining an emitter with a specific version.</summary>
[CppInclude("NiagaraTypes.h")]
public partial struct FVersionedNiagaraEmitter {
	public UNiagaraEmitter Emitter;
	public FGuid Version;
}
