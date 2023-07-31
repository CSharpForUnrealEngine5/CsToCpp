#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshBakeFunctions.h")]
public partial struct FGeometryScriptBakeRenderCaptureOptions {
	public EGeometryScriptBakeResolution Resolution;
	public EGeometryScriptBakeResolution RenderCaptureResolution;
	public EGeometryScriptBakeSamplesPerPixel SamplesPerPixel;
	public bool bRenderCaptureAntiAliasing;
	public float CleanupTolerance;
	public bool bBaseColorMap;
	public bool bNormalMap;
	public bool bPackedMRSMap;
	public bool bMetallicMap;
	public bool bRoughnessMap;
	public bool bSpecularMap;
	public bool bEmissiveMap;
	public bool bOpacityMap;
	public bool bSubsurfaceColorMap;
	public double FieldOfViewDegrees;
	public double NearPlaneDist;
}
