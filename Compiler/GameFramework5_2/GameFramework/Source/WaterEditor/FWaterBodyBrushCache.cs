#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaterBrushCacheContainer.h")]
///<summary>TODO [jonathan.bard] : rename : this is not a WaterBodyBrushCache, this a simple RenderTarget with a boolean to force an update on it</summary>
public partial struct FWaterBodyBrushCache {
// WaterBodyBrushCache
	public UTextureRenderTarget2D CacheRenderTarget;
	public bool CacheIsValid;
}
