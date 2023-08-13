namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Editor only data for systems.</summary>
[CppInclude("NiagaraSystemEditorData.h")]
public partial class UNiagaraSystemEditorData : UNiagaraEditorDataBase {
	public static UClass StaticClass() {return default;}
	///<summary>If true then the preview viewport&#39;s orbit setting is saved in the asset data</summary>
	public bool bSetOrbitModeByAsset;
	///<summary>bSystemViewportInOrbitMode</summary>
	public bool bSystemViewportInOrbitMode;
	///<summary>Contains the root ids for organizing user parameters.</summary>
	public UNiagaraHierarchyRoot UserParameterHierarchy;
	///<summary>RootFolder</summary>
	public UNiagaraSystemEditorFolder RootFolder;
	///<summary>StackEditorData</summary>
	public UNiagaraStackEditorData StackEditorData;
	///<summary>OwnerTransform</summary>
	public FTransform OwnerTransform;
	///<summary>PlaybackRangeMin</summary>
	public float PlaybackRangeMin;
	///<summary>PlaybackRangeMax</summary>
	public float PlaybackRangeMax;
	///<summary>Graph presenting overview of the current system and its emitters.</summary>
	public UEdGraph SystemOverviewGraph;
	///<summary>OverviewGraphViewSettings</summary>
	public FNiagaraGraphViewSettings OverviewGraphViewSettings;
	///<summary>bSystemIsPlaceholder</summary>
	public bool bSystemIsPlaceholder;
	///<summary>UserParameterMetaData</summary>
	public TArray<UNiagaraScriptVariable> UserParameterMetaData;
}
