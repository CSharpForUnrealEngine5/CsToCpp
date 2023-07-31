#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The widget tree manages the collection of widgets in a blueprint widget.</summary>
[CppInclude("Blueprint/WidgetTree.h")]
public partial class UWidgetTree : UObject {
	///<summary>The root widget of the tree</summary>
	public UWidget RootWidget;
	///<summary>Stores the widgets being assigned to named slots, these widgets will be slotted into the named slots of the</summary>
	public TMap<string,UWidget> NamedSlotBindings;
	///<summary>AllWidgets</summary>
	public TArray<UWidget> AllWidgets;
}
