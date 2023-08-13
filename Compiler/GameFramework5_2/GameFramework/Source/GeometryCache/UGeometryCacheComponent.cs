namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>GeometryCacheComponent, encapsulates a GeometryCache asset instance and implements functionality for rendering/and playback of GeometryCaches</summary>
[CppInclude("GeometryCacheComponent.h")]
public partial class UGeometryCacheComponent : UMeshComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Start playback of GeometryCache</summary>
	public void Play() {}
	///<summary>Start playback of GeometryCache from the start</summary>
	public void PlayFromStart() {}
	///<summary>Start playback of GeometryCache in reverse</summary>
	public void PlayReversed() {}
	///<summary>Start playback of GeometryCache from the end and play in reverse</summary>
	public void PlayReversedFromEnd() {}
	///<summary>Pause playback of GeometryCache</summary>
	public void Pause() {}
	///<summary>Stop playback of GeometryCache</summary>
	public void Stop() {}
	///<summary>Get whether this GeometryCache is playing or not.</summary>
	public bool IsPlaying() { return default; }
	///<summary>Get whether this GeometryCache is playing in reverse or not.</summary>
	public bool IsPlayingReversed() { return default; }
	///<summary>Get whether this GeometryCache is looping or not.</summary>
	public bool IsLooping() { return default; }
	///<summary>Set whether this GeometryCache is looping or not.</summary>
	public void SetLooping(bool bNewLooping) {}
	///<summary>Get whether this GeometryCache is extrapolating frames.</summary>
	public bool IsExtrapolatingFrames() { return default; }
	///<summary>Set whether this GeometryCache is extrapolating frames.</summary>
	public void SetExtrapolateFrames(bool bNewExtrapolating) {}
	///<summary>Get current playback speed for GeometryCache.</summary>
	public float GetPlaybackSpeed() { return default; }
	///<summary>Set new playback speed for GeometryCache.</summary>
	public void SetPlaybackSpeed(float NewPlaybackSpeed) {}
	///<summary>Get the motion vector scale.</summary>
	public float GetMotionVectorScale() { return default; }
	///<summary>Set new motion vector scale.</summary>
	public void SetMotionVectorScale(float NewMotionVectorScale) {}
	///<summary>Change the Geometry Cache used by this instance.</summary>
	public bool SetGeometryCache(UGeometryCache NewGeomCache) { return default; }
	///<summary>Get current start time offset for GeometryCache.</summary>
	public float GetStartTimeOffset() { return default; }
	///<summary>Set current start time offset for GeometryCache.</summary>
	public void SetStartTimeOffset(float NewStartTimeOffset) {}
	///<summary>Set the current animation time for GeometryCache. Includes the influence of elapsed time and SetStartTimeOffset</summary>
	public float GetAnimationTime() { return default; }
	///<summary>Set the current animation time for GeometryCache. Includes the influence of elapsed time and SetStartTimeOffset</summary>
	public float GetPlaybackDirection() { return default; }
	///<summary>Geometry Cache instance referenced by the component</summary>
	public UGeometryCache GeometryCache;
	///<summary>Get the duration of the playback</summary>
	public float GetDuration() { return default; }
	///<summary>Get the number of frames</summary>
	public int GetNumberOfFrames() { return default; }
	///<summary>Override wireframe color?</summary>
	public void SetOverrideWireframeColor(bool bOverride) {}
	///<summary>Check whether we are overriding the wireframe color or not.</summary>
	public bool GetOverrideWireframeColor() { return default; }
	///<summary>Set the color, used when overriding the wireframe color is enabled.</summary>
	public void SetWireframeOverrideColor(FLinearColor Color) {}
	///<summary>Get the wireframe override color, used when overriding the wireframe color is enabled.</summary>
	public FLinearColor GetWireframeOverrideColor() { return default; }
	///<summary>TickAtThisTime</summary>
	public void TickAtThisTime(float Time,bool bInIsRunning,bool bInBackwards,bool bInIsLooping) {}
	///<summary>bRunning</summary>
	public bool bRunning;
	///<summary>bLooping</summary>
	public bool bLooping;
	///<summary>Enable frame extrapolation for sub-frame sampling of non-constant topologies with imported motion vectors</summary>
	public bool bExtrapolateFrames;
	///<summary>StartTimeOffset</summary>
	public float StartTimeOffset;
	///<summary>PlaybackSpeed</summary>
	public float PlaybackSpeed;
	///<summary>Scale factor to apply to the imported motion vectors</summary>
	public float MotionVectorScale;
	///<summary>NumTracks</summary>
	public int NumTracks;
	///<summary>ElapsedTime</summary>
	public float ElapsedTime;
	///<summary>Duration of the animation (maximum time)</summary>
	public float Duration;
	///<summary>bManualTick</summary>
	public bool bManualTick;
	///<summary>Do we override the wireframe rendering color?</summary>
	public bool bOverrideWireframeColor;
	///<summary>The wireframe override color.</summary>
	public FLinearColor WireframeOverrideColor;
}
