#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemeshMeshTool.h")]
///<summary>Standard properties of the Remesh operation</summary>
public partial class URemeshMeshToolProperties : URemeshProperties {
// RemeshMeshToolProperties
	public int TargetTriangleCount;
	public ERemeshSmoothingType SmoothingType;
	public bool bDiscardAttributes;
	public bool bShowGroupColors;
	public ERemeshType RemeshType;
	public int RemeshIterations;
	public int MaxRemeshIterations;
	public int ExtraProjectionIterations;
	public bool bUseTargetEdgeLength;
	public float TargetEdgeLength;
	public bool bReproject;
	public bool bReprojectConstraints;
	public float BoundaryCornerAngleThreshold;
}
