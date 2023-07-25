#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshBakeFunctions.h")]
public partial struct FGeometryScriptBakeTextureOptions {
// GeometryScriptBakeTextureOptions
	public EGeometryScriptBakeResolution Resolution;
	public EGeometryScriptBakeBitDepth BitDepth;
	public EGeometryScriptBakeSamplesPerPixel SamplesPerPixel;
	public UTexture2D SampleFilterMask;
	public float ProjectionDistance;
	public bool bProjectionInWorldSpace;
}
