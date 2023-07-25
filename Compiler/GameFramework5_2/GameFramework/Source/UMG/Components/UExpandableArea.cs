#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/ExpandableArea.h")]
public partial class UExpandableArea : UWidget {
// ExpandableArea
	public FExpandableAreaStyle Style;
	public FSlateBrush BorderBrush;
	public FSlateColor BorderColor;
	public bool bIsExpanded;
	public float MaxHeight;
	public FMargin HeaderPadding;
	public FMargin AreaPadding;
	public FOnExpandableAreaExpansionChanged OnExpansionChanged;
	public bool GetIsExpanded() { return default; }
	public void SetIsExpanded(bool IsExpanded) {}
	public void SetIsExpanded_Animated(bool IsExpanded) {}
	public UWidget HeaderContent;
	public UWidget BodyContent;
}
