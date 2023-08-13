namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A Navigation control for a Carousel</summary>
[CppInclude("CommonWidgetCarouselNavBar.h")]
public partial class UCommonWidgetCarouselNavBar : UWidget {
	public static UClass StaticClass() {return default;}
	///<summary>ButtonWidgetType</summary>
	public UClass ButtonWidgetType;
	///<summary>ButtonPadding</summary>
	public FMargin ButtonPadding;
	///<summary>Establishes the Widget Carousel instance that this Nav Bar should interact with</summary>
	public void SetLinkedCarousel(UCommonWidgetCarousel CommonCarousel) {}
	///<summary>HandlePageChanged</summary>
	public void HandlePageChanged(UCommonWidgetCarousel CommonCarousel,int PageIndex) {}
	///<summary>HandleButtonClicked</summary>
	public void HandleButtonClicked(UCommonButtonBase AssociatedButton,int ButtonIndex) {}
	///<summary>LinkedCarousel</summary>
	public UCommonWidgetCarousel LinkedCarousel;
	///<summary>ButtonGroup</summary>
	public UCommonButtonGroupBase ButtonGroup;
	///<summary>Buttons</summary>
	public TArray<UCommonButtonBase> Buttons;
}
