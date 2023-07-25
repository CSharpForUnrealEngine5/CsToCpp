#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/EditorProjectSettings.h")]
///<summary>Editor project appearance settings. Stored in default config, per-project</summary>
public partial class UEditorProjectAppearanceSettings : UDeveloperSettings {
// EditorProjectAppearanceSettings
	public bool bDisplayUnits;
	public bool bDisplayUnitsOnComponentTransforms;
	public TArray<EUnit> DistanceUnits;
	public TArray<EUnit> MassUnits;
	public TArray<EUnit> TimeUnits;
	public EUnit AngleUnits;
	public EUnit SpeedUnits;
	public EUnit TemperatureUnits;
	public EUnit ForceUnits;
	public EReferenceViewerSettingMode ShowSearchableNames;
	public int ReferenceViewerDefaultMaxSearchBreadth;
	public EUnitDisplay UnitDisplay_DEPRECATED;
	public EDefaultLocationUnit DefaultInputUnits_DEPRECATED;
}
