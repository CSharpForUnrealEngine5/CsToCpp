#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDebuggerCommon.h")]
///<summary>Simple information on the connected client for use in continuous or immediate response UI elements.</summary>
public partial struct FNiagaraSimpleClientInfo {
// NiagaraSimpleClientInfo
	public TArray<string> Systems;
	public TArray<string> Actors;
	public TArray<string> Components;
	public TArray<string> Emitters;
}
