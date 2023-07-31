#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/MeshMerging.h")]
public enum EMeshApproximationGroundPlaneClippingPolicy {
	NoGroundClipping=0,
	DiscardWithZPlane=1,
	CutWithZPlane=2,
	CutAndFillWithZPlane=3,
}
