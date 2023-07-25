#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeCircleHeightPatch.h")]
///<summary>The simplest height patch: a circle of flat ground with a falloff past the initial radius across which the</summary>
public partial class ULandscapeCircleHeightPatch : ULandscapePatchComponent {
// LandscapeCircleHeightPatch
	public float Radius;
	public float Falloff;
	public bool bExclusiveRadius;
}
