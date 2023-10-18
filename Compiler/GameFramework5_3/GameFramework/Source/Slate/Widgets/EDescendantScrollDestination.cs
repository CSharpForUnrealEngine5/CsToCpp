namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Widgets/Layout/SScrollBox.h")]
///<summary>Where to scroll the descendant to</summary>
public enum EDescendantScrollDestination {
	IntoView=0,
	TopOrLeft=1,
	Center=2,
	BottomOrRight=3,
}
