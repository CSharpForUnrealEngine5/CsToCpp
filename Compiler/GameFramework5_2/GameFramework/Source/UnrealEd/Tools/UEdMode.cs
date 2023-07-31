#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for all editor modes.</summary>
[CppInclude("Tools/UEdMode.h")]
public partial class UEdMode : UObject {
	///<summary>The ToolsContext for this Mode, created as a child of the EditorToolsContext (shares InputRouter)</summary>
	public UEdModeInteractiveToolsContext ModeToolsContext;
	///<summary>SettingsClass</summary>
	public TSoftObjectPtr<UClass> SettingsClass;
	///<summary>SettingsObject</summary>
	public UObject SettingsObject;
}
