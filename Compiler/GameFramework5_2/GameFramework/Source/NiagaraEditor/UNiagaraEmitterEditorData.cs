#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraEmitterEditorData.h")]
///<summary>Editor only UI data for emitters.</summary>
public partial class UNiagaraEmitterEditorData : UNiagaraEditorDataBase {
// NiagaraEmitterEditorData
	public UNiagaraStackEditorData StackEditorData;
	public float PlaybackRangeMin;
	public float PlaybackRangeMax;
	public bool bShowSummaryView;
	public TMap<FFunctionInputSummaryViewKey,FFunctionInputSummaryViewMetadata> SummaryViewFunctionInputMetadata;
	public TArray<FNiagaraStackSection> SummarySections;
}
