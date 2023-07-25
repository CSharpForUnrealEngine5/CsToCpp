#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraOutliner.h")]
public partial class UNiagaraOutliner : UObject {
// NiagaraOutliner
	public FNiagaraOutlinerCaptureSettings CaptureSettings;
	public FNiagaraOutlinerViewSettings ViewSettings;
	public FNiagaraOutlinerData Data;
	public TMap<string,UNiagaraSimCache> SystemSimCaches;
}
