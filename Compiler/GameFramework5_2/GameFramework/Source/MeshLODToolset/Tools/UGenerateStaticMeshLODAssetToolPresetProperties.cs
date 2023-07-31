#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tools/GenerateStaticMeshLODAssetTool.h")]
public partial class UGenerateStaticMeshLODAssetToolPresetProperties : UInteractiveToolPropertySet {
	///<summary>Preset Asset represents a set of Saved Settings for this Tool</summary>
	public TWeakObjectPtr<UStaticMeshLODGenerationSettings> Preset;
	///<summary>Save the current Tool settings to the Preset Asset</summary>
	public  void ReadFromPreset() {}
	///<summary>Read the current Tool settings from the Preset Asset</summary>
	public  void WriteToPreset() {}
}
