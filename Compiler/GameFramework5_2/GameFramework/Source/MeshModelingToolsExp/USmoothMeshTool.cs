#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SmoothMeshTool.h")]
///<summary>Mesh Smoothing Tool</summary>
public partial class USmoothMeshTool : UBaseMeshProcessingTool {
// SmoothMeshTool
	public USmoothMeshToolProperties SmoothProperties;
	public UIterativeSmoothProperties IterativeProperties;
	public UDiffusionSmoothProperties DiffusionProperties;
	public UImplicitSmoothProperties ImplicitProperties;
	public USmoothWeightMapSetProperties WeightMapProperties;
}
