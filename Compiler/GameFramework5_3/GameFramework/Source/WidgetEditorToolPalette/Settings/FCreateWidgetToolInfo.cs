namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Info used to populate a single create widget tool</summary>
[CppInclude("Settings/CreateWidgetToolSettings.h")]
public partial struct FCreateWidgetToolInfo {
	public UClass WidgetClass;
	public string DisplayName;
	public FInputChord WidgetHotkey;
	public UClass CreateWidgetToolBuilder;
}
