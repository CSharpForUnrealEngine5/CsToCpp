#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/CreateNewAssetUtilityFunctions.h")]
public partial struct FGeometryScriptCreateNewStaticMeshAssetOptions {
// GeometryScriptCreateNewStaticMeshAssetOptions
	public bool bEnableRecomputeNormals;
	public bool bEnableRecomputeTangents;
	public bool bEnableNanite;
	public FMeshNaniteSettings NaniteSettings;
	public float NaniteProxyTrianglePercent;
	public bool bEnableCollision;
	public byte CollisionMode;
}
