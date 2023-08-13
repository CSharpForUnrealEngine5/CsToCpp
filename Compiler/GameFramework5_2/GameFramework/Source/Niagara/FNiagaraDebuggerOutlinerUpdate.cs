namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Message containing updated outliner information sent from the client to the debugger.</summary>
[CppInclude("NiagaraDebuggerCommon.h")]
public partial struct FNiagaraDebuggerOutlinerUpdate {
	public FNiagaraOutlinerData OutlinerData;
}
