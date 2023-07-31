#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This is the runtime representation of a triangle. Each triangle stores its vertices etc in normalized space,</summary>
[CppInclude("Animation/BlendSpace.h")]
public partial struct FBlendSpaceTriangle {
	public int SampleIndices;
	public FVector2D Vertices;
	public FBlendSpaceTriangleEdgeInfo EdgeInfo;
}
