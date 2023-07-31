#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprint/DragDropOperation.h")]
///<summary>Controls where the drag widget visual will appear when dragged relative to the pointer performing</summary>
public enum EDragPivot {
	MouseDown=0,
	TopLeft=1,
	TopCenter=2,
	TopRight=3,
	CenterLeft=4,
	CenterCenter=5,
	CenterRight=6,
	BottomLeft=7,
	BottomCenter=8,
	BottomRight=9,
}
