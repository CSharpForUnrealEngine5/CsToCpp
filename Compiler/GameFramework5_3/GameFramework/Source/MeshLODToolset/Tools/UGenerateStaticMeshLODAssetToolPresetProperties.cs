namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tools/GenerateStaticMeshLODAssetTool.h")]
public partial class UGenerateStaticMeshLODAssetToolPresetProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Preset Asset represents a set of Saved Settings for this Tool</summary>
	public TWeakObjectPtr<UStaticMeshLODGenerationSettings> Preset;
	///<summary>Read the current Tool settings from the Preset Asset</summary>
	public void ReadFromPreset() {}
	///<summary>Save the current Tool settings to the Preset Asset</summary>
	public void WriteToPreset() {}
}
