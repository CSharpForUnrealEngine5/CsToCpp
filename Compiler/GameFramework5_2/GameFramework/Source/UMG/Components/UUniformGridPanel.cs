#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/UniformGridPanel.h")]
///<summary>A panel that evenly divides up available space between all of its children.</summary>
public partial class UUniformGridPanel : UPanelWidget {
// UniformGridPanel
	public FMargin SlotPadding;
	public float MinDesiredSlotWidth;
	public float MinDesiredSlotHeight;
	public  void SetSlotPadding(FMargin InSlotPadding) {}
	public  void SetMinDesiredSlotWidth(float InMinDesiredSlotWidth) {}
	public  void SetMinDesiredSlotHeight(float InMinDesiredSlotHeight) {}
	public  UUniformGridSlot AddChildToUniformGrid(UWidget Content,int InRow/*=0*/,int InColumn/*=0*/) { return default; }
}
