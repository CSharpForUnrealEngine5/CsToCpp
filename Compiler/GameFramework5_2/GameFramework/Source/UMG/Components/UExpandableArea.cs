namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/ExpandableArea.h")]
public partial class UExpandableArea : UWidget {
	public static UClass StaticClass() {return default;}
	///<summary>Style</summary>
	public FExpandableAreaStyle Style;
	///<summary>BorderBrush</summary>
	public FSlateBrush BorderBrush;
	///<summary>BorderColor</summary>
	public FSlateColor BorderColor;
	///<summary>bIsExpanded</summary>
	public bool bIsExpanded;
	///<summary>The maximum height of the area</summary>
	public float MaxHeight;
	///<summary>HeaderPadding</summary>
	public FMargin HeaderPadding;
	///<summary>AreaPadding</summary>
	public FMargin AreaPadding;
	///<summary>A bindable delegate for the IsChecked.</summary>
	public FOnExpandableAreaExpansionChanged OnExpansionChanged;
	///<summary>GetIsExpanded</summary>
	public bool GetIsExpanded() { return default; }
	///<summary>SetIsExpanded</summary>
	public void SetIsExpanded(bool IsExpanded) {}
	///<summary>SetIsExpanded_Animated</summary>
	public void SetIsExpanded_Animated(bool IsExpanded) {}
	///<summary>HeaderContent</summary>
	public UWidget HeaderContent;
	///<summary>BodyContent</summary>
	public UWidget BodyContent;
}
