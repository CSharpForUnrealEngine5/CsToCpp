#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/BlendSpace.h")]
///<summary>The runtime data used for interpolating. Note that only one of Segments/Triangles will be in use,</summary>
public partial struct FBlendSpaceData {
// BlendSpaceData
	public TArray<FBlendSpaceSegment> Segments;
	public TArray<FBlendSpaceTriangle> Triangles;
}
