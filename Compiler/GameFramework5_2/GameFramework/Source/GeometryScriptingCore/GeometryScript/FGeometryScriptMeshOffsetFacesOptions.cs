namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshModelingFunctions.h")]
public partial struct FGeometryScriptMeshOffsetFacesOptions {
	public float Distance;
	public EGeometryScriptOffsetFacesType OffsetType;
	public EGeometryScriptPolyOperationArea AreaMode;
	public FGeometryScriptMeshEditPolygroupOptions GroupOptions;
	public float UVScale;
	public bool bSolidsToShells;
}
