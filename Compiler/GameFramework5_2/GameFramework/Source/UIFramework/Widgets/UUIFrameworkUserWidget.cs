#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Widgets/UIFUserWidget.h")]
public partial class UUIFrameworkUserWidget : UUIFrameworkWidget {
	public static UClass StaticClass() {return default;}
	///<summary>SetWidgetClass</summary>
	public  void SetWidgetClass(TSoftObjectPtr<UClass> Value) {}
	///<summary>SetNamedSlot</summary>
	public  void SetNamedSlot(string SlotName,UUIFrameworkWidget Widget) {}
	///<summary>ReplicatedSlotList</summary>
	public FUIFrameworkUserWidgetSlotList ReplicatedSlotList;
}
