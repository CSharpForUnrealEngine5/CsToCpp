#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/CreateNewAssetUtilityFunctions.h")]
public partial struct FGeometryScriptCreateNewStaticMeshAssetOptions {
	public bool bEnableRecomputeNormals;
	public bool bEnableRecomputeTangents;
	public bool bEnableNanite;
	public FMeshNaniteSettings NaniteSettings;
	public float NaniteProxyTrianglePercent;
	public bool bEnableCollision;
	public ECollisionTraceFlag CollisionMode;
}
