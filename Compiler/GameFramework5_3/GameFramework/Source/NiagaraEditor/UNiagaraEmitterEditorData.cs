namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Editor only UI data for emitters.</summary>
[CppInclude("NiagaraEmitterEditorData.h")]
public partial class UNiagaraEmitterEditorData : UNiagaraEditorDataBase {
	public static UClass StaticClass() {return default;}
	///<summary>StackEditorData</summary>
	public UNiagaraStackEditorData StackEditorData;
	///<summary>PlaybackRangeMin</summary>
	public float PlaybackRangeMin;
	///<summary>PlaybackRangeMax</summary>
	public float PlaybackRangeMax;
	///<summary>bShowSummaryView</summary>
	public bool bShowSummaryView;
	///<summary>Stores metadata for filtering function inputs when in Filtered/Simple view.</summary>
	public TMap<FFunctionInputSummaryViewKey,FFunctionInputSummaryViewMetadata> SummaryViewFunctionInputMetadata_DEPRECATED;
	///<summary>SummarySections_DEPRECATED</summary>
	public TArray<FNiagaraStackSection> SummarySections_DEPRECATED;
	///<summary>SummaryViewRoot</summary>
	public UNiagaraHierarchyRoot SummaryViewRoot;
}
