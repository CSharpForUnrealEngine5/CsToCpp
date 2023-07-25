#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Widgets/Views/STableViewBase.h")]
///<summary>If the list panel is arranging items as tiles, this enum dictates how the items should be aligned (basically, where any extra space is placed)</summary>
public enum EListItemAlignment {
	EvenlyDistributed=0,
	EvenlySize=1,
	EvenlyWide=2,
	LeftAligned=3,
	RightAligned=4,
	CenterAligned=5,
	Fill=6,
}
