namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Widgets/UIFStackBox.h")]
public partial class UUIFrameworkStackBox : UUIFrameworkWidget {
	public static UClass StaticClass() {return default;}
	///<summary>The orientation of the stack box.</summary>
	public EOrientation Orientation;
	///<summary>AddWidget</summary>
	public void AddWidget(FUIFrameworkStackBoxSlot Widget) {}
	///<summary>RemoveWidget</summary>
	public void RemoveWidget(UUIFrameworkWidget Widget) {}
	///<summary>OnRep_Orientation</summary>
	public void OnRep_Orientation() {}
	///<summary>ReplicatedSlotList</summary>
	public FUIFrameworkStackBoxSlotList ReplicatedSlotList;
}
