#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SampleTools/DrawCurveOnMeshSampleTool.h")]
///<summary>UDrawCurveOnMeshSampleTool is a sample Tool that allows the user to draw curves on the surface of</summary>
public partial class UDrawCurveOnMeshSampleTool : UMeshSurfacePointTool {
// DrawCurveOnMeshSampleTool
	public UDrawCurveOnMeshSampleToolProperties Settings;
	public TArray<FVector> Positions;
	public TArray<FVector> Normals;
}
