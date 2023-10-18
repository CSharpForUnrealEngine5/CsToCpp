namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the settings for the Tool Project Preset Collections.</summary>
[CppInclude("ToolPresetSettings.h")]
public partial class UToolPresetProjectSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Controls which preset collection assets are to be loaded for this project.</summary>
	public TSet<FSoftObjectPath> LoadedPresetCollections;
}
