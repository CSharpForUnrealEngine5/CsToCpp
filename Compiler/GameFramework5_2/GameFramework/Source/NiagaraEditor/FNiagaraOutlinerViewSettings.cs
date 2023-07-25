#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraOutliner.h")]
///<summary>View settings used in the Niagara Outliner.</summary>
public partial struct FNiagaraOutlinerViewSettings {
// NiagaraOutlinerViewSettings
	public ENiagaraOutlinerViewModes ViewMode;
	public FNiagaraOutlinerFilterSettings FilterSettings;
	public bool bSortDescending;
	public ENiagaraOutlinerSortMode SortMode;
	public ENiagaraOutlinerTimeUnits TimeUnits;
}
