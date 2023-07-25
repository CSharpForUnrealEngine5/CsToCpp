#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ProceduralMeshComponent.h")]
///<summary>One vertex for the procedural mesh, used for storing data internally</summary>
public partial struct FProcMeshVertex {
// ProcMeshVertex
	public FVector Position;
	public FVector Normal;
	public FProcMeshTangent Tangent;
	public FColor Color;
	public FVector2D UV0;
	public FVector2D UV1;
	public FVector2D UV2;
	public FVector2D UV3;
}
