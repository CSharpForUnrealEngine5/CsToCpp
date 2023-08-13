namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Used to store spline mesh data during RerunConstructionScripts</summary>
[CppInclude("Components/SplineMeshComponent.h")]
public partial struct FSplineMeshInstanceData {
	public FVector StartPos;
	public FVector EndPos;
	public FVector StartTangent;
	public FVector EndTangent;
}
