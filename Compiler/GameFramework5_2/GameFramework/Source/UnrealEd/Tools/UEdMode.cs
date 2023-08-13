namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for all editor modes.</summary>
[CppInclude("Tools/UEdMode.h")]
public partial class UEdMode : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The ToolsContext for this Mode, created as a child of the EditorToolsContext (shares InputRouter)</summary>
	public UEdModeInteractiveToolsContext ModeToolsContext;
	///<summary>SettingsClass</summary>
	public TSoftObjectPtr<UClass> SettingsClass;
	///<summary>SettingsObject</summary>
	public UObject SettingsObject;
}
