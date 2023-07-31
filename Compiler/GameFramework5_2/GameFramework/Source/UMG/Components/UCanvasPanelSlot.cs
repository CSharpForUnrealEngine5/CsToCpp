#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/CanvasPanelSlot.h")]
public partial class UCanvasPanelSlot : UPanelSlot {
	///<summary>The anchoring information for the slot</summary>
	public FAnchorData LayoutData;
	///<summary>When AutoSize is true we use the widget&#39;s desired size</summary>
	public bool bAutoSize;
	///<summary>The order priority this widget is rendered in.  Higher values are rendered last (and so they will appear to be on top).</summary>
	public int ZOrder;
	///<summary>Sets the layout data of the slot</summary>
	public  void SetLayout(FAnchorData InLayoutData) {}
	///<summary>Gets the layout data of the slot</summary>
	public  FAnchorData GetLayout() { return default; }
	///<summary>Sets the position of the slot</summary>
	public  void SetPosition(FVector2D InPosition) {}
	///<summary>Gets the position of the slot</summary>
	public  FVector2D GetPosition() { return default; }
	///<summary>Sets the size of the slot</summary>
	public  void SetSize(FVector2D InSize) {}
	///<summary>Gets the size of the slot</summary>
	public  FVector2D GetSize() { return default; }
	///<summary>Sets the offset data of the slot, which could be position and size, or margins depending on the anchor points</summary>
	public  void SetOffsets(FMargin InOffset) {}
	///<summary>Gets the offset data of the slot, which could be position and size, or margins depending on the anchor points</summary>
	public  FMargin GetOffsets() { return default; }
	///<summary>Sets the anchors on the slot</summary>
	public  void SetAnchors(FAnchors InAnchors) {}
	///<summary>Gets the anchors on the slot</summary>
	public  FAnchors GetAnchors() { return default; }
	///<summary>Sets the alignment on the slot</summary>
	public  void SetAlignment(FVector2D InAlignment) {}
	///<summary>Gets the alignment on the slot</summary>
	public  FVector2D GetAlignment() { return default; }
	///<summary>Sets if the slot to be auto-sized</summary>
	public  void SetAutoSize(bool InbAutoSize) {}
	///<summary>Gets if the slot to be auto-sized</summary>
	public  bool GetAutoSize() { return default; }
	///<summary>Sets the z-order on the slot</summary>
	public  void SetZOrder(int InZOrder) {}
	///<summary>Gets the z-order on the slot</summary>
	public  int GetZOrder() { return default; }
	///<summary>Sets the anchors on the slot</summary>
	public  void SetMinimum(FVector2D InMinimumAnchors) {}
	///<summary>Sets the anchors on the slot</summary>
	public  void SetMaximum(FVector2D InMaximumAnchors) {}
}
