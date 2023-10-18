namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/MeshMerging.h")]
public enum EMeshApproximationGroundPlaneClippingPolicy {
	NoGroundClipping=0,
	DiscardWithZPlane=1,
	CutWithZPlane=2,
	CutAndFillWithZPlane=3,
}
