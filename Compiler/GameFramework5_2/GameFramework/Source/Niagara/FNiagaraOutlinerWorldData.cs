#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDebuggerCommon.h")]
///<summary>All information about a specific world for the Niagara Outliner.</summary>
public partial struct FNiagaraOutlinerWorldData {
// NiagaraOutlinerWorldData
	public TMap<string,FNiagaraOutlinerSystemData> Systems;
	public bool bHasBegunPlay;
	public byte WorldType;
	public byte NetMode;
	public FNiagaraOutlinerTimingData AveragePerFrameTime;
	public FNiagaraOutlinerTimingData MaxPerFrameTime;
}
