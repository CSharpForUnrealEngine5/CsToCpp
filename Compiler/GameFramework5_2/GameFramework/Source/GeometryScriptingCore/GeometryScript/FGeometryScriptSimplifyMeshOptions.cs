#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshSimplifyFunctions.h")]
public partial struct FGeometryScriptSimplifyMeshOptions {
	public EGeometryScriptRemoveMeshSimplificationType Method;
	public bool bAllowSeamCollapse;
	public bool bAllowSeamSmoothing;
	public bool bAllowSeamSplits;
	public bool bPreserveVertexPositions;
	public bool bRetainQuadricMemory;
	public bool bAutoCompact;
}
