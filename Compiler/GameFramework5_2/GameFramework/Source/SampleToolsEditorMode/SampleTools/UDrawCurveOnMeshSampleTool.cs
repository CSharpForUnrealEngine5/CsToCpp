#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UDrawCurveOnMeshSampleTool is a sample Tool that allows the user to draw curves on the surface of</summary>
[CppInclude("SampleTools/DrawCurveOnMeshSampleTool.h")]
public partial class UDrawCurveOnMeshSampleTool : UMeshSurfacePointTool {
	public static UClass StaticClass() {return default;}
	///<summary>Settings</summary>
	public UDrawCurveOnMeshSampleToolProperties Settings;
	///<summary>Positions</summary>
	public TArray<FVector> Positions;
	///<summary>Normals</summary>
	public TArray<FVector> Normals;
}
