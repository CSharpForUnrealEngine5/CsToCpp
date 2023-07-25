#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryCacheComponent.h")]
///<summary>GeometryCacheComponent, encapsulates a GeometryCache asset instance and implements functionality for rendering/and playback of GeometryCaches</summary>
public partial class UGeometryCacheComponent : UMeshComponent {
// GeometryCacheComponent
	public void Play() {}
	public void PlayFromStart() {}
	public void PlayReversed() {}
	public void PlayReversedFromEnd() {}
	public void Pause() {}
	public void Stop() {}
	public bool IsPlaying() { return default; }
	public bool IsPlayingReversed() { return default; }
	public bool IsLooping() { return default; }
	public void SetLooping(bool bNewLooping) {}
	public bool IsExtrapolatingFrames() { return default; }
	public void SetExtrapolateFrames(bool bNewExtrapolating) {}
	public float GetPlaybackSpeed() { return default; }
	public void SetPlaybackSpeed(float NewPlaybackSpeed) {}
	public float GetMotionVectorScale() { return default; }
	public void SetMotionVectorScale(float NewMotionVectorScale) {}
	public bool SetGeometryCache(UObject NewGeomCache) { return default; }
	public float GetStartTimeOffset() { return default; }
	public void SetStartTimeOffset(float NewStartTimeOffset) {}
	public float GetAnimationTime() { return default; }
	public float GetPlaybackDirection() { return default; }
	public UGeometryCache GeometryCache;
	public float GetDuration() { return default; }
	public int GetNumberOfFrames() { return default; }
	public void SetOverrideWireframeColor(bool bOverride) {}
	public bool GetOverrideWireframeColor() { return default; }
	public void SetWireframeOverrideColor(FLinearColor Color) {}
	public FLinearColor GetWireframeOverrideColor() { return default; }
	public void TickAtThisTime(float Time,bool bInIsRunning,bool bInBackwards,bool bInIsLooping) {}
	public bool bRunning;
	public bool bLooping;
	public bool bExtrapolateFrames;
	public float StartTimeOffset;
	public float PlaybackSpeed;
	public float MotionVectorScale;
	public int NumTracks;
	public float ElapsedTime;
	public float Duration;
	public bool bManualTick;
	public bool bOverrideWireframeColor;
	public FLinearColor WireframeOverrideColor;
}
