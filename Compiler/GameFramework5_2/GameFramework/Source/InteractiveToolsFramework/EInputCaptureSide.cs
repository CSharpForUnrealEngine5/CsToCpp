#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InputBehavior.h")]
///<summary>Input can be captured separately for Left and Right sides (eg for VR controllers)</summary>
public enum EInputCaptureSide {
	None=0,
	Left=1,
	Right=2,
	Both=3,
	Any=99,
}
