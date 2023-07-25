#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorTutorial.h")]
///<summary>Content that is displayed relative to a widget</summary>
public partial struct FTutorialWidgetContent {
// TutorialWidgetContent
	public FTutorialContent Content;
	public FTutorialContentAnchor WidgetAnchor;
	public byte HorizontalAlignment;
	public byte VerticalAlignment;
	public FVector2D Offset;
	public float ContentWidth;
	public bool bAutoFocus;
}
