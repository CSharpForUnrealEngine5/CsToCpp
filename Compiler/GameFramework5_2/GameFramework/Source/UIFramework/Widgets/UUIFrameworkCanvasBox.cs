namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Widgets/UIFCanvasBox.h")]
public partial class UUIFrameworkCanvasBox : UUIFrameworkWidget {
	public static UClass StaticClass() {return default;}
	///<summary>AddWidget</summary>
	public void AddWidget(FUIFrameworkCanvasBoxSlot Widget) {}
	///<summary>RemoveWidget</summary>
	public void RemoveWidget(UUIFrameworkWidget Widget) {}
	///<summary>ReplicatedSlotList</summary>
	public FUIFrameworkCanvasBoxSlotList ReplicatedSlotList;
}
