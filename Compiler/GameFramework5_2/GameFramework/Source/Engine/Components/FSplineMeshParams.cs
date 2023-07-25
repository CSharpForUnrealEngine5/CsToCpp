#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/SplineMeshComponent.h")]
///<summary>Structure that holds info about spline, passed to renderer to deform UStaticMesh.</summary>
public partial struct FSplineMeshParams {
// SplineMeshParams
	public FVector StartPos;
	public FVector StartTangent;
	public FVector2D StartScale;
	public float StartRoll;
	public FVector2D StartOffset;
	public FVector EndPos;
	public FVector2D EndScale;
	public FVector EndTangent;
	public float EndRoll;
	public FVector2D EndOffset;
}
