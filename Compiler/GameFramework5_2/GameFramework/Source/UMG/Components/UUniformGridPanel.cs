namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A panel that evenly divides up available space between all of its children.</summary>
[CppInclude("Components/UniformGridPanel.h")]
public partial class UUniformGridPanel : UPanelWidget {
	public static UClass StaticClass() {return default;}
	///<summary>Padding given to each slot</summary>
	public FMargin SlotPadding;
	///<summary>The minimum desired width of the slots</summary>
	public float MinDesiredSlotWidth;
	///<summary>The minimum desired height of the slots</summary>
	public float MinDesiredSlotHeight;
	///<summary>SetSlotPadding</summary>
	public void SetSlotPadding(FMargin InSlotPadding) {}
	///<summary>SetMinDesiredSlotWidth</summary>
	public void SetMinDesiredSlotWidth(float InMinDesiredSlotWidth) {}
	///<summary>SetMinDesiredSlotHeight</summary>
	public void SetMinDesiredSlotHeight(float InMinDesiredSlotHeight) {}
	///<summary>AddChildToUniformGrid</summary>
	public UUniformGridSlot AddChildToUniformGrid(UWidget Content,int InRow/*=0*/,int InColumn/*=0*/) { return default; }
}
