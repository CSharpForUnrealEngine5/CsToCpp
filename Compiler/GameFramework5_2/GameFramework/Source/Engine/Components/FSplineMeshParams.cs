namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure that holds info about spline, passed to renderer to deform UStaticMesh.</summary>
[CppInclude("Components/SplineMeshComponent.h")]
public partial struct FSplineMeshParams {
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
