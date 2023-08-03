#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A bundle of the Media Asset necessary to play a video &amp; audio</summary>
[CppInclude("MediaBundle.h")]
public partial class UMediaBundle : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Get the material interface.</summary>
	public  UMaterialInterface GetMaterial() { return default; }
	///<summary>Get the media player.</summary>
	public  UMediaPlayer GetMediaPlayer() { return default; }
	///<summary>Get the media texture.</summary>
	public  UMediaTexture GetMediaTexture() { return default; }
	///<summary>Get the lens displacement Render Target.</summary>
	public  UTextureRenderTarget2D GetLensDisplacementTexture() { return default; }
	///<summary>Get the media source.</summary>
	public  UMediaSource GetMediaSource() { return default; }
	///<summary>Get the undistorted space camera view information.</summary>
	public  FOpenCVCameraViewInfo GetUndistortedCameraViewInfo() { return default; }
	///<summary>MediaBundle internal MediaSource</summary>
	public UMediaSource MediaSource;
	///<summary>Controls MediaPlayer looping option</summary>
	public bool bLoopMediaSource;
	///<summary>Automatically try to open the MediaSource again if an error is detected</summary>
	public bool bReopenSourceOnError;
	///<summary>Class to spawn for that asset.</summary>
	public UClass MediaBundleActorClass;
	///<summary>MediaBundle default MediaPlayer</summary>
	public UMediaPlayer MediaPlayer;
	///<summary>MediaBundle default MediaTexture</summary>
	public UMediaTexture MediaTexture;
	///<summary>MediaBundle default Material</summary>
	public UMaterialInterface Material;
	///<summary>Lens parameters of the source</summary>
	public FOpenCVLensDistortionParameters LensParameters;
	///<summary>CameraView information for the undistorted space</summary>
	public FOpenCVCameraViewInfo UndistortedCameraViewInfo;
	///<summary>Current values of lens parameters to support undo/redo correctly</summary>
	public FOpenCVLensDistortionParameters CurrentLensParameters;
	///<summary>Destination of lens distortion result</summary>
	public UTextureRenderTarget2D LensDisplacementMap;
	///<summary>Internal reference counter of active media player</summary>
	public int ReferenceCount;
	///<summary>Default Material from the plugin</summary>
	public UMaterial DefaultMaterial;
	///<summary>Default Texture from the plugin</summary>
	public UTexture DefaultFailedTexture;
	///<summary>Default Actor Class from the plugin</summary>
	public UClass DefaultActorClass;
	///<summary>Callback function to show the DefaultTexture</summary>
	public  void OnMediaClosed() {}
	///<summary>OnMediaOpenOpened</summary>
	public  void OnMediaOpenOpened(string DeviceUrl) {}
	///<summary>OnMediaOpenFailed</summary>
	public  void OnMediaOpenFailed(string DeviceUrl) {}
}
