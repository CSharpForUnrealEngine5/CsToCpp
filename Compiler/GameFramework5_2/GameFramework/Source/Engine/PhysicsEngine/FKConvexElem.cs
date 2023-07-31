#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>One convex hull, used for simplified collision.</summary>
[CppInclude("PhysicsEngine/ConvexElem.h")]
public partial struct FKConvexElem {
	public TArray<FVector> VertexData;
	public TArray<int> IndexData;
	public FBox ElemBox;
	public FTransform Transform;
}
