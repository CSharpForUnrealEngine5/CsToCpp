namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The runtime data used for interpolating. Note that only one of Segments/Triangles will be in use,</summary>
[CppInclude("Animation/BlendSpace.h")]
public partial struct FBlendSpaceData {
	public TArray<FBlendSpaceSegment> Segments;
	public TArray<FBlendSpaceTriangle> Triangles;
}
