#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Content that is displayed relative to a widget</summary>
[CppInclude("EditorTutorial.h")]
public partial struct FTutorialWidgetContent {
	public FTutorialContent Content;
	public FTutorialContentAnchor WidgetAnchor;
	public EHorizontalAlignment HorizontalAlignment;
	public EVerticalAlignment VerticalAlignment;
	public FVector2D Offset;
	public float ContentWidth;
	public bool bAutoFocus;
}
