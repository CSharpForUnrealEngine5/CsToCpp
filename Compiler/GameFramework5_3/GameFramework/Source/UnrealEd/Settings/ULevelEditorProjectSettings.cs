namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Configure per-project settings for the Level Editor</summary>
[CppInclude("Settings/EditorProjectSettings.h")]
public partial class ULevelEditorProjectSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>bEnableViewportSMInstanceSelection</summary>
	public bool bEnableViewportSMInstanceSelection;
}
