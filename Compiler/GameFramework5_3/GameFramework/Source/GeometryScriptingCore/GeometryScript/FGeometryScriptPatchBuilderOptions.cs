namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshUVFunctions.h")]
public partial struct FGeometryScriptPatchBuilderOptions {
	public int InitialPatchCount;
	public int MinPatchSize;
	public float PatchCurvatureAlignmentWeight;
	public float PatchMergingMetricThresh;
	public float PatchMergingAngleThresh;
	public FGeometryScriptExpMapUVOptions ExpMapOptions;
	public bool bRespectInputGroups;
	public FGeometryScriptGroupLayer GroupLayer;
	public bool bAutoPack;
	public FGeometryScriptRepackUVsOptions PackingOptions;
}
