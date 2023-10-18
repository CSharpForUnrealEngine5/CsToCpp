namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshBakeFunctions.h")]
public partial struct FGeometryScriptBakeTextureOptions {
	public EGeometryScriptBakeResolution Resolution;
	public EGeometryScriptBakeBitDepth BitDepth;
	public EGeometryScriptBakeSamplesPerPixel SamplesPerPixel;
	public UTexture2D SampleFilterMask;
	public EGeometryScriptBakeFilteringType FilteringType;
	public float ProjectionDistance;
	public bool bProjectionInWorldSpace;
}
