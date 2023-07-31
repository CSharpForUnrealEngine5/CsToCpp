#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A stack box widget is a layout panel allowing child widgets to be automatically laid out</summary>
[CppInclude("Components/StackBox.h")]
public partial class UStackBox : UPanelWidget {
	///<summary>The orientation of the stack box.</summary>
	public EOrientation Orientation;
	///<summary>Adds a new child widget to the container.</summary>
	public  UStackBoxSlot AddChildToStackBox(UWidget Content) { return default; }
	///<summary>Replace the widget at the given index it with a different widget.</summary>
	public  bool ReplaceStackBoxChildAt(int Index,UWidget Content) { return default; }
}
