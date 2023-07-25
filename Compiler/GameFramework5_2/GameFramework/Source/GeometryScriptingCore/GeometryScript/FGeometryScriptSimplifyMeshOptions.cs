#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshSimplifyFunctions.h")]
public partial struct FGeometryScriptSimplifyMeshOptions {
// GeometryScriptSimplifyMeshOptions
	public EGeometryScriptRemoveMeshSimplificationType Method;
	public bool bAllowSeamCollapse;
	public bool bAllowSeamSmoothing;
	public bool bAllowSeamSplits;
	public bool bPreserveVertexPositions;
	public bool bRetainQuadricMemory;
	public bool bAutoCompact;
}
