namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Mesh Offsetting Tool</summary>
[CppInclude("OffsetMeshTool.h")]
public partial class UOffsetMeshTool : UBaseMeshProcessingTool {
	public static UClass StaticClass() {return default;}
	///<summary>OffsetProperties</summary>
	public UOffsetMeshToolProperties OffsetProperties;
	///<summary>IterativeProperties</summary>
	public UIterativeOffsetProperties IterativeProperties;
	///<summary>ImplicitProperties</summary>
	public UImplicitOffsetProperties ImplicitProperties;
	///<summary>WeightMapProperties</summary>
	public UOffsetWeightMapSetProperties WeightMapProperties;
}
