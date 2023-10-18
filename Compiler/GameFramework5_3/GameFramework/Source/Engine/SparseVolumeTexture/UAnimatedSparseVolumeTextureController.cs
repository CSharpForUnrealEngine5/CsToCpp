namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Utility (blueprint) class for controlling SparseVolumeTexture playback.</summary>
[CppInclude("SparseVolumeTexture/SparseVolumeTexture.h")]
public partial class UAnimatedSparseVolumeTextureController : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>SparseVolumeTexture</summary>
	public USparseVolumeTexture SparseVolumeTexture;
	///<summary>Time</summary>
	public float Time;
	///<summary>bIsPlaying</summary>
	public bool bIsPlaying;
	///<summary>FrameRate</summary>
	public float FrameRate;
	///<summary>MipLevel</summary>
	public int MipLevel;
	///<summary>bBlockingStreamingRequests</summary>
	public bool bBlockingStreamingRequests;
	///<summary>Play</summary>
	public void Play() {}
	///<summary>Pause</summary>
	public void Pause() {}
	///<summary>Stop</summary>
	public void Stop() {}
	///<summary>Update</summary>
	public void Update(float DeltaTime) {}
	///<summary>GetFractionalFrameIndex</summary>
	public float GetFractionalFrameIndex() { return default; }
	///<summary>GetFrameByIndex</summary>
	public USparseVolumeTextureFrame GetFrameByIndex(int FrameIndex) { return default; }
	///<summary>GetCurrentFrame</summary>
	public USparseVolumeTextureFrame GetCurrentFrame() { return default; }
	///<summary>GetCurrentFramesForInterpolation</summary>
	public void GetCurrentFramesForInterpolation(USparseVolumeTextureFrame Frame0,USparseVolumeTextureFrame Frame1,float LerpAlpha) {}
	///<summary>GetDuration</summary>
	public float GetDuration() { return default; }
}
