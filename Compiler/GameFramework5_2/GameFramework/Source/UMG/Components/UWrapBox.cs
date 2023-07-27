#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/WrapBox.h")]
///<summary>Arranges widgets left-to-right or top-to-bottom dependently of the orientation.  When the widgets exceed the wrapSize it will place widgets on the next line.</summary>
public partial class UWrapBox : UPanelWidget {
// WrapBox
	public FVector2D InnerSlotPadding;
	public float WrapSize;
	public bool bExplicitWrapSize;
	public EHorizontalAlignment HorizontalAlignment;
	public EOrientation Orientation;
	public  void SetInnerSlotPadding(FVector2D InPadding) {}
	public  void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment) {}
	public  UWrapBoxSlot AddChildToWrapBox(UWidget Content) { return default; }
}
