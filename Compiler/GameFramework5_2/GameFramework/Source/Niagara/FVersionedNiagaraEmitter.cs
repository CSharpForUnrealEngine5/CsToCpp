#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraTypes.h")]
///<summary>Struct combining an emitter with a specific version.</summary>
public partial struct FVersionedNiagaraEmitter {
// VersionedNiagaraEmitter
	public UNiagaraEmitter Emitter;
	public FGuid Version;
}
