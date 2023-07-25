#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SmoothMeshTool.h")]
///<summary>Properties for Diffusion Smoothing</summary>
public partial class UDiffusionSmoothProperties : UInteractiveToolPropertySet {
// DiffusionSmoothProperties
	public float SmoothingPerStep;
	public int Steps;
	public bool bPreserveUVs;
}
