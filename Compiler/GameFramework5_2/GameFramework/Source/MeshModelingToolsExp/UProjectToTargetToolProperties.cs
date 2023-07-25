#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ProjectToTargetTool.h")]
///<summary>Subclass URemeshMeshToolProperties just so we can set default values for some properties. Setting these values in the</summary>
public partial class UProjectToTargetToolProperties : URemeshMeshToolProperties {
// ProjectToTargetToolProperties
	public bool bWorldSpace;
	public bool bParallel;
	public int FaceProjectionPassesPerRemeshIteration;
	public float SurfaceProjectionSpeed;
	public float NormalAlignmentSpeed;
	public bool bSmoothInFillAreas;
	public float FillAreaDistanceMultiplier;
	public float FillAreaSmoothMultiplier;
}
