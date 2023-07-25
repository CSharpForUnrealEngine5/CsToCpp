#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprint/WidgetTree.h")]
///<summary>The widget tree manages the collection of widgets in a blueprint widget.</summary>
public partial class UWidgetTree : UObject {
// WidgetTree
	public UWidget RootWidget;
	public TMap<string,UWidget> NamedSlotBindings;
	public TArray<UWidget> AllWidgets;
}
