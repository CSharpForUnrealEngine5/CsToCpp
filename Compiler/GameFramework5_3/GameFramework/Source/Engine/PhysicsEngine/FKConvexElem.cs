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
