#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UI/WidgetSnapshots.h")]
///<summary>Saves properties from widgets within a widget tree.</summary>
public partial struct FWidgetTreeSnapshot {
// WidgetTreeSnapshot
	public string RootWidget;
	public TMap<string,FWidgetSnapshot> WidgetSnapshots;
}
