#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraSystemEditorData.h")]
///<summary>Editor only data for systems.</summary>
public partial class UNiagaraSystemEditorData : UNiagaraEditorDataBase {
// NiagaraSystemEditorData
	public bool bSetOrbitModeByAsset;
	public bool bSystemViewportInOrbitMode;
	public UNiagaraHierarchyRoot UserParameterHierarchy;
	public UNiagaraSystemEditorFolder RootFolder;
	public UNiagaraStackEditorData StackEditorData;
	public FTransform OwnerTransform;
	public float PlaybackRangeMin;
	public float PlaybackRangeMax;
	public UEdGraph SystemOverviewGraph;
	public FNiagaraGraphViewSettings OverviewGraphViewSettings;
	public bool bSystemIsPlaceholder;
	public TArray<UNiagaraScriptVariable> UserParameterMetaData;
}
