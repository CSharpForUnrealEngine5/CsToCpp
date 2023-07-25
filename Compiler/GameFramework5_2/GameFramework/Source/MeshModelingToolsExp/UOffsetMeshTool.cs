#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OffsetMeshTool.h")]
///<summary>Mesh Offsetting Tool</summary>
public partial class UOffsetMeshTool : UBaseMeshProcessingTool {
// OffsetMeshTool
	public UOffsetMeshToolProperties OffsetProperties;
	public UIterativeOffsetProperties IterativeProperties;
	public UImplicitOffsetProperties ImplicitProperties;
	public UOffsetWeightMapSetProperties WeightMapProperties;
}
