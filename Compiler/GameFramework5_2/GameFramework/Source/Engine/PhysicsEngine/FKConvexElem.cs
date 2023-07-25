#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsEngine/ConvexElem.h")]
///<summary>One convex hull, used for simplified collision.</summary>
public partial struct FKConvexElem {
// KConvexElem
	public TArray<FVector> VertexData;
	public TArray<int> IndexData;
	public FBox ElemBox;
	public FTransform Transform;
}
