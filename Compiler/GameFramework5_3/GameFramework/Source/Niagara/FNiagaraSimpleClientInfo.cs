namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple information on the connected client for use in continuous or immediate response UI elements.</summary>
[CppInclude("NiagaraDebuggerCommon.h")]
public partial struct FNiagaraSimpleClientInfo {
	public TArray<string> Systems;
	public TArray<string> Actors;
	public TArray<string> Components;
	public TArray<string> Emitters;
}
