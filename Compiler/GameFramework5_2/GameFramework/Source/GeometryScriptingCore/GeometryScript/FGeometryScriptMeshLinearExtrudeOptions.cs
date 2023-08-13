namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshModelingFunctions.h")]
public partial struct FGeometryScriptMeshLinearExtrudeOptions {
	public float Distance;
	public EGeometryScriptLinearExtrudeDirection DirectionMode;
	public FVector Direction;
	public EGeometryScriptPolyOperationArea AreaMode;
	public FGeometryScriptMeshEditPolygroupOptions GroupOptions;
	public float UVScale;
	public bool bSolidsToShells;
}
