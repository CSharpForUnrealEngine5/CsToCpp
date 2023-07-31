#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Description of an attribute</summary>
[CppInclude("AnimGraphAttributes.h")]
public partial struct FAnimGraphAttributeDesc {
	public string Name;
	public FSlateBrush Icon;
	public string DisplayName;
	public string ToolTipText;
	public FSlateColor Color;
	public EAnimGraphAttributesDisplayMode DisplayMode;
	public EAnimGraphAttributeBlend Blend;
	public int SortOrder;
}
