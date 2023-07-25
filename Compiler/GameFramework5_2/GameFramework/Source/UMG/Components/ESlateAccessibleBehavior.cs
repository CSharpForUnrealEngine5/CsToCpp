#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/SlateWrapperTypes.h")]
///<summary>Whether a widget should be included in accessibility, and if so, how its text should be retrieved.</summary>
public enum ESlateAccessibleBehavior {
	NotAccessible=0,
	Auto=1,
	Summary=2,
	Custom=3,
	ToolTip=4,
}
