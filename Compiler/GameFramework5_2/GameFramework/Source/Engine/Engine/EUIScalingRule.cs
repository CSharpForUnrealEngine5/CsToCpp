#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/UserInterfaceSettings.h")]
///<summary>The Side to use when scaling the UI.</summary>
public enum EUIScalingRule {
	ShortestSide=0,
	LongestSide=1,
	Horizontal=2,
	Vertical=3,
	ScaleToFit=4,
	Custom=5,
}
