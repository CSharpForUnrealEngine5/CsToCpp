namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Script class for filtering object types to Object Mixer.</summary>
[CppInclude("ObjectFilter/ObjectMixerEditorObjectFilter.h")]
public partial class UObjectMixerBlueprintObjectFilter : UObjectMixerObjectFilter {
	public static UClass StaticClass() {return default;}
	///<summary>Return the basic object types you want to filter for in your level.</summary>
	public TSet<UClass> GetObjectClassesToFilter() { return default; }
	///<summary>Return the basic actor types you want to be able to place using the Add button.</summary>
	public TSet<UClass> GetObjectClassesToPlace() { return default; }
	///<summary>Determines if transient objects (such as Sequencer Spawnables) should be shown in the list. False by default.</summary>
	public bool GetShowTransientObjects() { return default; }
	///<summary>Specify a list of property names corresponding to columns you want to show by default.</summary>
	public TSet<FName> GetColumnsToShowByDefault() { return default; }
	///<summary>Specify a list of property names corresponding to columns you don&#39;t want to ever show.</summary>
	public TSet<FName> GetColumnsToExclude() { return default; }
	///<summary>Specify a list of property names found in parent classes you want to show that aren&#39;t in the specified classes.</summary>
	public TSet<FName> GetForceAddedColumns() { return default; }
	///<summary>Specify whether we should return only the properties of the specified classes or the properties of parent and child classes.</summary>
	public EObjectMixerInheritanceInclusionOptions GetObjectMixerPropertyInheritanceInclusionOptions() { return default; }
	///<summary>Specify whether we should return only the specified classes or the parent and child classes in placement mode.</summary>
	public EObjectMixerInheritanceInclusionOptions GetObjectMixerPlacementClassInclusionOptions() { return default; }
	///<summary>If true, properties that are not visible in the details panel and properties not supported by SSingleProperty will be selectable.</summary>
	public bool ShouldIncludeUnsupportedProperties() { return default; }
	///<summary>If a property is changed that has a name found in this set, the panel will be refreshed.</summary>
	public TSet<FName> GetPropertiesThatRequireListRefresh() { return default; }
}
