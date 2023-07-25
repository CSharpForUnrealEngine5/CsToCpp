#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonWidgetCarouselNavBar.h")]
///<summary>A Navigation control for a Carousel</summary>
public partial class UCommonWidgetCarouselNavBar : UWidget {
// CommonWidgetCarouselNavBar
	public UClass ButtonWidgetType;
	public FMargin ButtonPadding;
	public void SetLinkedCarousel(UObject CommonCarousel) {}
	public void HandlePageChanged(UObject CommonCarousel,int PageIndex) {}
	public void HandleButtonClicked(UObject AssociatedButton,int ButtonIndex) {}
	public UCommonWidgetCarousel LinkedCarousel;
	public UCommonButtonGroupBase ButtonGroup;
	public TArray<UCommonButtonBase> Buttons;
}
