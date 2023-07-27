#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonWidgetCarouselNavBar.h")]
///<summary>A Navigation control for a Carousel</summary>
public partial class UCommonWidgetCarouselNavBar : UWidget {
// CommonWidgetCarouselNavBar
	public UClass ButtonWidgetType;
	public FMargin ButtonPadding;
	public  void SetLinkedCarousel(UCommonWidgetCarousel CommonCarousel) {}
	public  void HandlePageChanged(UCommonWidgetCarousel CommonCarousel,int PageIndex) {}
	public  void HandleButtonClicked(UCommonButtonBase AssociatedButton,int ButtonIndex) {}
	public UCommonWidgetCarousel LinkedCarousel;
	public UCommonButtonGroupBase ButtonGroup;
	public TArray<UCommonButtonBase> Buttons;
}
