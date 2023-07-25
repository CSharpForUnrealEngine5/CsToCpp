#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MediaBundleActorBase.h")]
///<summary>A base actor that</summary>
public partial class AMediaBundleActorBase : AActor {
// MediaBundleActorBase
	public UObject GetMediaBundle() { return default; }
	public bool RequestOpenMediaSource() { return default; }
	public void RequestCloseMediaSource() {}
	public void SetComponent(UObject InPrimitive,UObject InMediaSound) {}
	public UTextureRenderTarget2D GarbageMatteMask;
	public UMediaBundle MediaBundle;
	public bool bAutoPlay;
	public bool bPlayWhileEditing;
	public UPrimitiveComponent PrimitiveCmp;
	public UMediaSoundComponent MediaSoundCmp;
	public UMaterialInstanceDynamic Material;
	public int PrimitiveMaterialIndex;
}
