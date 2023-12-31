namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>View settings used in the Niagara Outliner.</summary>
[CppInclude("NiagaraOutliner.h")]
public partial struct FNiagaraOutlinerViewSettings {
	public ENiagaraOutlinerViewModes ViewMode;
	public FNiagaraOutlinerFilterSettings FilterSettings;
	public bool bSortDescending;
	public ENiagaraOutlinerSortMode SortMode;
	public ENiagaraOutlinerTimeUnits TimeUnits;
}
