#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Editor only UI data for emitters.</summary>
[CppInclude("NiagaraEmitterEditorData.h")]
public partial class UNiagaraEmitterEditorData : UNiagaraEditorDataBase {
	///<summary>StackEditorData</summary>
	public UNiagaraStackEditorData StackEditorData;
	///<summary>PlaybackRangeMin</summary>
	public float PlaybackRangeMin;
	///<summary>PlaybackRangeMax</summary>
	public float PlaybackRangeMax;
	///<summary>bShowSummaryView</summary>
	public bool bShowSummaryView;
	///<summary>Stores metadata for filtering function inputs when in Filtered/Simple view.</summary>
	public TMap<FFunctionInputSummaryViewKey,FFunctionInputSummaryViewMetadata> SummaryViewFunctionInputMetadata;
	///<summary>SummarySections</summary>
	public TArray<FNiagaraStackSection> SummarySections;
}
