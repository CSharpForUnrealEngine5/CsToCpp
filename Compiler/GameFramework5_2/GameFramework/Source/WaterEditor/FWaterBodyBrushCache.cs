#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>TODO [jonathan.bard] : rename : this is not a WaterBodyBrushCache, this a simple RenderTarget with a boolean to force an update on it</summary>
[CppInclude("WaterBrushCacheContainer.h")]
public partial struct FWaterBodyBrushCache {
	public UTextureRenderTarget2D CacheRenderTarget;
	public bool CacheIsValid;
}
