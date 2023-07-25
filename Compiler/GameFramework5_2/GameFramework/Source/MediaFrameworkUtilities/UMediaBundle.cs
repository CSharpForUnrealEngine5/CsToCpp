#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MediaBundle.h")]
///<summary>A bundle of the Media Asset necessary to play a video & audio</summary>
public partial class UMediaBundle : UObject {
// MediaBundle
	public UObject GetMaterial() { return default; }
	public UObject GetMediaPlayer() { return default; }
	public UObject GetMediaTexture() { return default; }
	public UObject GetLensDisplacementTexture() { return default; }
	public UObject GetMediaSource() { return default; }
	public FOpenCVCameraViewInfo GetUndistortedCameraViewInfo() { return default; }
	public UMediaSource MediaSource;
	public bool bLoopMediaSource;
	public bool bReopenSourceOnError;
	public UClass MediaBundleActorClass;
	public UMediaPlayer MediaPlayer;
	public UMediaTexture MediaTexture;
	public UMaterialInterface Material;
	public FOpenCVLensDistortionParameters LensParameters;
	public FOpenCVCameraViewInfo UndistortedCameraViewInfo;
	public FOpenCVLensDistortionParameters CurrentLensParameters;
	public UTextureRenderTarget2D LensDisplacementMap;
	public int ReferenceCount;
	public UMaterial DefaultMaterial;
	public UTexture DefaultFailedTexture;
	public UClass DefaultActorClass;
	public void OnMediaClosed() {}
	public void OnMediaOpenOpened(string DeviceUrl) {}
	public void OnMediaOpenFailed(string DeviceUrl) {}
}
