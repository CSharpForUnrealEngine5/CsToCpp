#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraScratchPadContainer.h")]
///<summary>Wrapper class for scratch pad scripts in an emitter. This is needed because each emitter version can have it's own copy of a scratch pad with the same name and they can't all be outered to the emitter that way.</summary>
public partial class UNiagaraScratchPadContainer : UObject {
// NiagaraScratchPadContainer
	public TArray<UNiagaraScript> Scripts;
}
