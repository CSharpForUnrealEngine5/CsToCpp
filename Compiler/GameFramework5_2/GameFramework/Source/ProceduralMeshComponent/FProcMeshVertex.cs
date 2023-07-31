#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>One vertex for the procedural mesh, used for storing data internally</summary>
[CppInclude("ProceduralMeshComponent.h")]
public partial struct FProcMeshVertex {
	public FVector Position;
	public FVector Normal;
	public FProcMeshTangent Tangent;
	public FColor Color;
	public FVector2D UV0;
	public FVector2D UV1;
	public FVector2D UV2;
	public FVector2D UV3;
}
