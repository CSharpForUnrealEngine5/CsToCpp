namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Description of an attribute</summary>
[CppInclude("AnimGraphAttributes.h")]
public partial struct FAnimGraphAttributeDesc {
	public FName Name;
	public FSlateBrush Icon;
	public FText DisplayName;
	public FText ToolTipText;
	public FSlateColor Color;
	public EAnimGraphAttributesDisplayMode DisplayMode;
	public EAnimGraphAttributeBlend Blend;
	public int SortOrder;
}
