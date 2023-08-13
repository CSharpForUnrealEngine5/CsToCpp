namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshModelingFunctions.h")]
public partial struct FGeometryScriptMeshInsetOutsetFacesOptions {
	public float Distance;
	public bool bReproject;
	public bool bBoundaryOnly;
	public float Softness;
	public float AreaScale;
	public EGeometryScriptPolyOperationArea AreaMode;
	public FGeometryScriptMeshEditPolygroupOptions GroupOptions;
	public float UVScale;
}
