#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Wrapper class for scratch pad scripts in an emitter. This is needed because each emitter version can have it&#39;s own copy of a scratch pad with the same name and they can&#39;t all be outered to the emitter that way.</summary>
[CppInclude("NiagaraScratchPadContainer.h")]
public partial class UNiagaraScratchPadContainer : UObject {
	///<summary>Scripts</summary>
	public TArray<UNiagaraScript> Scripts;
}
