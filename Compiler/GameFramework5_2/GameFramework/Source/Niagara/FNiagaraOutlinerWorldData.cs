namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>All information about a specific world for the Niagara Outliner.</summary>
[CppInclude("NiagaraDebuggerCommon.h")]
public partial struct FNiagaraOutlinerWorldData {
	public TMap<string,FNiagaraOutlinerSystemData> Systems;
	public bool bHasBegunPlay;
	public byte WorldType;
	public byte NetMode;
	public FNiagaraOutlinerTimingData AveragePerFrameTime;
	public FNiagaraOutlinerTimingData MaxPerFrameTime;
}
