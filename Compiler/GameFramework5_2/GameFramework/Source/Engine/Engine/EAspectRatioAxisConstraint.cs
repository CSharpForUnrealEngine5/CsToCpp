#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Enum describing how to constrain perspective view port FOV</summary>
public enum EAspectRatioAxisConstraint {
	AspectRatio_MaintainYFOV=0,
	AspectRatio_MaintainXFOV=1,
	AspectRatio_MajorAxisFOV=2,
	AspectRatio_MAX=3,
}
