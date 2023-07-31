#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The base class for all UMG panel widgets.  Panel widgets layout a collection of child widgets.</summary>
[CppInclude("Components/PanelWidget.h")]
public partial class UPanelWidget : UWidget {
	///<summary>The slots in the widget holding the child widgets of this panel.</summary>
	public TArray<UPanelSlot> Slots;
	///<summary>Gets number of child widgets in the container.</summary>
	public  int GetChildrenCount() { return default; }
	///<summary>Gets the widget at an index.</summary>
	public  UWidget GetChildAt(int Index) { return default; }
	///<summary>Gets all widgets in the container</summary>
	public  TArray<UWidget> GetAllChildren() { return default; }
	///<summary>Gets the index of a specific child widget</summary>
	public  int GetChildIndex(UWidget Content) { return default; }
	///<summary>Returns true if panel contains this widget</summary>
	public  bool HasChild(UWidget Content) { return default; }
	///<summary>Removes a child by it&#39;s index.</summary>
	public  bool RemoveChildAt(int Index) { return default; }
	///<summary>Adds a new child widget to the container.  Returns the base slot type,</summary>
	public  UPanelSlot AddChild(UWidget Content) { return default; }
	///<summary>Removes a specific widget from the container.</summary>
	public  bool RemoveChild(UWidget Content) { return default; }
	///<summary>Returns true if there are any child widgets in the panel</summary>
	public  bool HasAnyChildren() { return default; }
	///<summary>Remove all child widgets from the panel widget.</summary>
	public  void ClearChildren() {}
}
