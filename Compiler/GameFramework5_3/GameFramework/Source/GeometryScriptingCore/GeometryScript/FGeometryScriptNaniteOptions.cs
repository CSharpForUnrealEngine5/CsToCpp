namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Configuration settings for Nanite Rendering on StaticMesh Assets</summary>
[CppInclude("GeometryScript/MeshAssetFunctions.h")]
public partial struct FGeometryScriptNaniteOptions {
	public bool bEnabled;
	public float FallbackPercentTriangles;
	public float FallbackRelativeError;
}
