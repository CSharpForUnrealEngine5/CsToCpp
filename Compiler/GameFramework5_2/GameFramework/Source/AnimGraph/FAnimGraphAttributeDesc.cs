#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimGraphAttributes.h")]
///<summary>Description of an attribute</summary>
public partial struct FAnimGraphAttributeDesc {
// AnimGraphAttributeDesc
	public string Name;
	public FSlateBrush Icon;
	public string DisplayName;
	public string ToolTipText;
	public FSlateColor Color;
	public EAnimGraphAttributesDisplayMode DisplayMode;
	public EAnimGraphAttributeBlend Blend;
	public int SortOrder;
}
