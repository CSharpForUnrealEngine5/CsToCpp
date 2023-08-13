namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Saves properties from widgets within a widget tree.</summary>
[CppInclude("UI/WidgetSnapshots.h")]
public partial struct FWidgetTreeSnapshot {
	public string RootWidget;
	public TMap<string,FWidgetSnapshot> WidgetSnapshots;
}
