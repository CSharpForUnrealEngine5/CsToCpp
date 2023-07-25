#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshModelingFunctions.h")]
public partial struct FGeometryScriptMeshBevelOptions {
// GeometryScriptMeshBevelOptions
	public float BevelDistance;
	public bool bInferMaterialID;
	public int SetMaterialID;
	public bool bApplyFilterBox;
	public FBox FilterBox;
	public FTransform FilterBoxTransform;
	public bool bFullyContained;
}
