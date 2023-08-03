#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Widgets/UIFOverlay.h")]
public partial class UUIFrameworkOverlay : UUIFrameworkWidget {
	public static UClass StaticClass() {return default;}
	///<summary>AddWidget</summary>
	public  void AddWidget(FUIFrameworkOverlaySlot Widget) {}
	///<summary>RemoveWidget</summary>
	public  void RemoveWidget(UUIFrameworkWidget Widget) {}
	///<summary>ReplicatedSlotList</summary>
	public FUIFrameworkOverlaySlotList ReplicatedSlotList;
}
