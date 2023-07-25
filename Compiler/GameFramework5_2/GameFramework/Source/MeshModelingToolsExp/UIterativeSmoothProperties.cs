#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SmoothMeshTool.h")]
///<summary>Properties for Iterative Smoothing</summary>
public partial class UIterativeSmoothProperties : UInteractiveToolPropertySet {
// IterativeSmoothProperties
	public float SmoothingPerStep;
	public int Steps;
	public bool bSmoothBoundary;
}
