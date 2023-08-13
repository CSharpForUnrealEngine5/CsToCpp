namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameMenuWidgetStyle.h")]
public partial struct FGameMenuStyle {
	public FSlateBrush MenuTopBrush;
	public FSlateBrush MenuFrameBrush;
	public FSlateBrush MenuBackgroundBrush;
	public FSlateBrush MenuSelectBrush;
	public FSlateSound MenuEnterSound;
	public FSlateSound MenuBackSound;
	public FSlateSound OptionChangeSound;
	public FSlateSound MenuItemChangeSound;
	public FSlateSound MenuItemInactiveSound;
	public FSlateSound MenuItemChosenSound;
	public float LeftMarginPercent;
	public float SubMenuMarginPercent;
	public GameMenuLayoutType LayoutType;
	public FMargin TitleBorderMargin;
	public FMargin ItemBorderMargin;
	public EHorizontalAlignment TitleHorizontalAlignment;
	public EVerticalAlignment TitleVerticalAlignment;
	public EVerticalAlignment PanelsVerticalAlignment;
	public float AnimationSpeed;
	public FSlateColor TextColor;
}
