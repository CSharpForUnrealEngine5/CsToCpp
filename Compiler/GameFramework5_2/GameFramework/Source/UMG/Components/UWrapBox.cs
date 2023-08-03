#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Arranges widgets left-to-right or top-to-bottom dependently of the orientation.  When the widgets exceed the wrapSize it will place widgets on the next line.</summary>
[CppInclude("Components/WrapBox.h")]
public partial class UWrapBox : UPanelWidget {
	public static UClass StaticClass() {return default;}
	///<summary>The inner slot padding goes between slots sharing borders</summary>
	public FVector2D InnerSlotPadding;
	///<summary>When this size is exceeded, elements will start appearing on the next line.</summary>
	public float WrapSize;
	///<summary>Use explicit wrap size whenever possible. It greatly simplifies layout calculations and reduces likelihood of &quot;wiggling UI&quot;</summary>
	public bool bExplicitWrapSize;
	///<summary>The alignment of each line of wrapped content.</summary>
	public EHorizontalAlignment HorizontalAlignment;
	///<summary>Determines if the Wrap Box should arranges the widgets left-to-right or top-to-bottom</summary>
	public EOrientation Orientation;
	///<summary>Sets the inner slot padding goes between slots sharing borders</summary>
	public  void SetInnerSlotPadding(FVector2D InPadding) {}
	///<summary>SetHorizontalAlignment</summary>
	public  void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment) {}
	///<summary>AddChildToWrapBox</summary>
	public  UWrapBoxSlot AddChildToWrapBox(UWidget Content) { return default; }
}
