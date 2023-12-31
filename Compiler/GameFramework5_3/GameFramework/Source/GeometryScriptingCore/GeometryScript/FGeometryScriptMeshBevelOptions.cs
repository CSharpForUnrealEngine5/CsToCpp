namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshModelingFunctions.h")]
public partial struct FGeometryScriptMeshBevelOptions {
	public float BevelDistance;
	public bool bInferMaterialID;
	public int SetMaterialID;
	public bool bApplyFilterBox;
	public FBox FilterBox;
	public FTransform FilterBoxTransform;
	public bool bFullyContained;
}
