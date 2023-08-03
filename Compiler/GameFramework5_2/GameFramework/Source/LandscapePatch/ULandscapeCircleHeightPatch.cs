#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The simplest height patch: a circle of flat ground with a falloff past the initial radius across which the</summary>
[CppInclude("LandscapeCircleHeightPatch.h")]
public partial class ULandscapeCircleHeightPatch : ULandscapePatchComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Radius</summary>
	public float Radius;
	///<summary>Distance across which the alpha will go from 1 down to 0 outside of circle.</summary>
	public float Falloff;
	///<summary>When true, only the vertices in the circle have alpha 1. If false, the radius is expanded slightly so that neighboring</summary>
	public bool bExclusiveRadius;
}
