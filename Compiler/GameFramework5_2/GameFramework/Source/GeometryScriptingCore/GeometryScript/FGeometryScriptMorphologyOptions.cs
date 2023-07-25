#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshVoxelFunctions.h")]
public partial struct FGeometryScriptMorphologyOptions {
// GeometryScriptMorphologyOptions
	public FGeometryScript3DGridParameters SDFGridParameters;
	public bool bUseSeparateMeshGrid;
	public FGeometryScript3DGridParameters MeshGridParameters;
	public EGeometryScriptMorphologicalOpType Operation;
	public float Distance;
}
