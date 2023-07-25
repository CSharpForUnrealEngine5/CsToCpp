#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/CreateWidgetToolSettings.h")]
///<summary>Info used to populate a single create widget tool</summary>
public partial struct FCreateWidgetToolInfo {
// CreateWidgetToolInfo
	public UClass WidgetClass;
	public string DisplayName;
	public FInputChord WidgetHotkey;
	public UClass CreateWidgetToolBuilder;
}
