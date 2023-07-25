#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OffsetMeshTool.h")]
///<summary>Properties for Iterative Offsetting</summary>
public partial class UIterativeOffsetProperties : UInteractiveToolPropertySet {
// IterativeOffsetProperties
	public int Steps;
	public bool bOffsetBoundaries;
	public float SmoothingPerStep;
	public bool bReprojectSmooth;
}
