#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Widgets/UIFStackBox.h")]
public partial class UUIFrameworkStackBox : UUIFrameworkWidget {
// UIFrameworkStackBox
	public EOrientation Orientation;
	public  void AddWidget(FUIFrameworkStackBoxSlot Widget) {}
	public  void RemoveWidget(UUIFrameworkWidget Widget) {}
	public  void OnRep_Orientation() {}
	public FUIFrameworkStackBoxSlotList ReplicatedSlotList;
}
