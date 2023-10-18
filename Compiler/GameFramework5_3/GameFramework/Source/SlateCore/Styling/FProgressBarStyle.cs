namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents the appearance of an SProgressBar</summary>
[CppInclude("Styling/SlateTypes.h")]
public partial struct FProgressBarStyle {
	public FSlateBrush BackgroundImage;
	public FSlateBrush FillImage;
	public FSlateBrush MarqueeImage;
	public bool EnableFillAnimation;
}
