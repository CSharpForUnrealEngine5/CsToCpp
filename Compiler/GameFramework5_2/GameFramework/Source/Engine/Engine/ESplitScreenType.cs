#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/ViewportSplitScreen.h")]
///<summary>Enum of the different splitscreen types</summary>
[CppEnumInNamespace]
public enum ESplitScreenType {
	None=0,
	TwoPlayer_Horizontal=1,
	TwoPlayer_Vertical=2,
	ThreePlayer_FavorTop=3,
	ThreePlayer_FavorBottom=4,
	ThreePlayer_Vertical=5,
	ThreePlayer_Horizontal=6,
	FourPlayer_Grid=7,
	FourPlayer_Vertical=8,
	FourPlayer_Horizontal=9,
	SplitTypeCount=10,
}
