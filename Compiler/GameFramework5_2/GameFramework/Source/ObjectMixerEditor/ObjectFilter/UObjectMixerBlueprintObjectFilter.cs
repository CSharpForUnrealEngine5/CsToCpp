#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ObjectFilter/ObjectMixerEditorObjectFilter.h")]
///<summary>Script class for filtering object types to Object Mixer.</summary>
public partial class UObjectMixerBlueprintObjectFilter : UObjectMixerObjectFilter {
// ObjectMixerBlueprintObjectFilter
	public  TSet<UClass> GetObjectClassesToFilter() { return default; }
	public  TSet<UClass> GetObjectClassesToPlace() { return default; }
	public  string GetRowDisplayName(UObject InObject,bool bIsHybridRow) { return default; }
	public  string GetRowTooltipText(UObject InObject,bool bIsHybridRow) { return default; }
	public  bool GetRowEditorVisibility(UObject InObject) { return default; }
	public  void OnSetRowEditorVisibility(UObject InObject,bool bNewIsVisible) {}
	public  TSet<string> GetColumnsToShowByDefault() { return default; }
	public  TSet<string> GetColumnsToExclude() { return default; }
	public  TSet<string> GetForceAddedColumns() { return default; }
	public  EObjectMixerInheritanceInclusionOptions GetObjectMixerPropertyInheritanceInclusionOptions() { return default; }
	public  EObjectMixerInheritanceInclusionOptions GetObjectMixerPlacementClassInclusionOptions() { return default; }
	public  bool ShouldIncludeUnsupportedProperties() { return default; }
	public  TSet<string> GetPropertiesThatRequireListRefresh() { return default; }
}
