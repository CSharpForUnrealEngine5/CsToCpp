#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/StackBox.h")]
///<summary>A stack box widget is a layout panel allowing child widgets to be automatically laid out</summary>
public partial class UStackBox : UPanelWidget {
// StackBox
	public EOrientation Orientation;
	public  UStackBoxSlot AddChildToStackBox(UWidget Content) { return default; }
	public  bool ReplaceStackBoxChildAt(int Index,UWidget Content) { return default; }
}
