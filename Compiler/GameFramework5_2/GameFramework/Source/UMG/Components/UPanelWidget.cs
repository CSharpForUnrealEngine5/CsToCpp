#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/PanelWidget.h")]
///<summary>The base class for all UMG panel widgets.  Panel widgets layout a collection of child widgets.</summary>
public partial class UPanelWidget : UWidget {
// PanelWidget
	public TArray<UPanelSlot> Slots;
	public  int GetChildrenCount() { return default; }
	public  UWidget GetChildAt(int Index) { return default; }
	public  TArray<UWidget> GetAllChildren() { return default; }
	public  int GetChildIndex(UWidget Content) { return default; }
	public  bool HasChild(UWidget Content) { return default; }
	public  bool RemoveChildAt(int Index) { return default; }
	public  UPanelSlot AddChild(UWidget Content) { return default; }
	public  bool RemoveChild(UWidget Content) { return default; }
	public  bool HasAnyChildren() { return default; }
	public  void ClearChildren() {}
}
