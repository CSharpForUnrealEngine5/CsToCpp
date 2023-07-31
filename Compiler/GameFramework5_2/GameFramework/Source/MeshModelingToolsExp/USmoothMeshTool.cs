#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Mesh Smoothing Tool</summary>
[CppInclude("SmoothMeshTool.h")]
public partial class USmoothMeshTool : UBaseMeshProcessingTool {
	///<summary>SmoothProperties</summary>
	public USmoothMeshToolProperties SmoothProperties;
	///<summary>IterativeProperties</summary>
	public UIterativeSmoothProperties IterativeProperties;
	///<summary>DiffusionProperties</summary>
	public UDiffusionSmoothProperties DiffusionProperties;
	///<summary>ImplicitProperties</summary>
	public UImplicitSmoothProperties ImplicitProperties;
	///<summary>WeightMapProperties</summary>
	public USmoothWeightMapSetProperties WeightMapProperties;
}
