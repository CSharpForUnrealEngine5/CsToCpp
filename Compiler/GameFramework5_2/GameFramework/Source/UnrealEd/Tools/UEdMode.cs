#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tools/UEdMode.h")]
///<summary>Base class for all editor modes.</summary>
public partial class UEdMode : UObject {
// EdMode
	public UEdModeInteractiveToolsContext ModeToolsContext;
	public TSoftObjectPtr<UClass> SettingsClass;
	public UObject SettingsObject;
}
