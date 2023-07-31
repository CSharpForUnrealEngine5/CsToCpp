#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshBakeFunctions.h")]
public partial struct FGeometryScriptBakeTextureOptions {
	public EGeometryScriptBakeResolution Resolution;
	public EGeometryScriptBakeBitDepth BitDepth;
	public EGeometryScriptBakeSamplesPerPixel SamplesPerPixel;
	public UTexture2D SampleFilterMask;
	public float ProjectionDistance;
	public bool bProjectionInWorldSpace;
}
