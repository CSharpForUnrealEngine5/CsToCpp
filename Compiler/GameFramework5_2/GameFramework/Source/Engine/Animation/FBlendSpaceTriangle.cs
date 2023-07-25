#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/BlendSpace.h")]
///<summary>This is the runtime representation of a triangle. Each triangle stores its vertices etc in normalized space,</summary>
public partial struct FBlendSpaceTriangle {
// BlendSpaceTriangle
	public int SampleIndices;
	public FVector2D Vertices;
	public FBlendSpaceTriangleEdgeInfo EdgeInfo;
}
