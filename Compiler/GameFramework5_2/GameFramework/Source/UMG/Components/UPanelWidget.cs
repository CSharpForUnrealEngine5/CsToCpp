#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/PanelWidget.h")]
///<summary>The base class for all UMG panel widgets.  Panel widgets layout a collection of child widgets.</summary>
public partial class UPanelWidget : UWidget {
// PanelWidget
	public TArray<UPanelSlot> Slots;
	public int GetChildrenCount() { return default; }
	public UObject GetChildAt(int Index) { return default; }
	public TArray<UObject> GetAllChildren() { return default; }
	public int GetChildIndex(UObject Content) { return default; }
	public bool HasChild(UObject Content) { return default; }
	public bool RemoveChildAt(int Index) { return default; }
	public UObject AddChild(UObject Content) { return default; }
	public bool RemoveChild(UObject Content) { return default; }
	public bool HasAnyChildren() { return default; }
	public void ClearChildren() {}
}
