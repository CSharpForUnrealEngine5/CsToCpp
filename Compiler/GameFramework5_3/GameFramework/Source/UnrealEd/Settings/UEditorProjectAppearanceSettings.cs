namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Editor project appearance settings. Stored in default config, per-project</summary>
[CppInclude("Settings/EditorProjectSettings.h")]
public partial class UEditorProjectAppearanceSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Whether to display units on editor properties where the property has units set.</summary>
	public bool bDisplayUnits;
	///<summary>Whether to display units on component transform properties</summary>
	public bool bDisplayUnitsOnComponentTransforms;
	///<summary>Choose a set of units in which to display distance/length values.</summary>
	public TArray<EUnit> DistanceUnits;
	///<summary>Choose a set of units in which to display masses.</summary>
	public TArray<EUnit> MassUnits;
	///<summary>Choose the units in which to display time.</summary>
	public TArray<EUnit> TimeUnits;
	///<summary>Choose the units in which to display angles.</summary>
	public EUnit AngleUnits;
	///<summary>Choose the units in which to display speeds and velocities.</summary>
	public EUnit SpeedUnits;
	///<summary>Choose the units in which to display temperatures.</summary>
	public EUnit TemperatureUnits;
	///<summary>Choose the units in which to display forces.</summary>
	public EUnit ForceUnits;
	///<summary>Choose the units in which to display torques.</summary>
	public EUnit TorqueUnits;
	///<summary>Should the Reference Viewer have &#39;Show Searchable Names&#39; checked by default when opened in this project</summary>
	public EReferenceViewerSettingMode ShowSearchableNames;
	///<summary>The default maximum search breadth for the reference viewer when opened</summary>
	public int ReferenceViewerDefaultMaxSearchBreadth;
	///<summary>Deprecated properties that didn&#39;t live very long</summary>
	public EUnitDisplay UnitDisplay_DEPRECATED;
	///<summary>DefaultInputUnits_DEPRECATED</summary>
	public EDefaultLocationUnit DefaultInputUnits_DEPRECATED;
}
