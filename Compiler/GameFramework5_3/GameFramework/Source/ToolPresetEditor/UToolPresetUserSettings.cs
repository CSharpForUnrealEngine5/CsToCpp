namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the settings for the PresetEditor.</summary>
[CppInclude("ToolPresetSettings.h")]
public partial class UToolPresetUserSettings : UEditorConfigBase {
	public static UClass StaticClass() {return default;}
	///<summary>EnabledPresetCollections</summary>
	public TSet<FSoftObjectPath> EnabledPresetCollections;
	///<summary>bDefaultCollectionEnabled</summary>
	public bool bDefaultCollectionEnabled;
}
