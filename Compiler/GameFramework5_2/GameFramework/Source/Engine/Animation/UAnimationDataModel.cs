#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimData/IAnimationDataModel.h")]
public partial class UAnimationDataModel : UInterface {
// AnimationDataModel
	public double GetPlayLength() { return default; }
	public int GetNumberOfFrames() { return default; }
	public int GetNumberOfKeys() { return default; }
	public FFrameRate GetFrameRate() { return default; }
	public TArray<FBoneAnimationTrack> GetBoneAnimationTracks() { return default; }
	public FBoneAnimationTrack GetBoneTrackByIndex(int TrackIndex) { return default; }
	public FBoneAnimationTrack GetBoneTrackByName(string TrackName) { return default; }
	public int GetBoneTrackIndex(FBoneAnimationTrack Track) { return default; }
	public int GetBoneTrackIndexByName(string TrackName) { return default; }
	public bool IsValidBoneTrackIndex(int TrackIndex) { return default; }
	public bool IsValidBoneTrackName(string TrackName) { return default; }
	public int GetNumBoneTracks() { return default; }
	public void GetBoneTrackNames(TArray<string> OutNames) {}
	public int GetNumberOfTransformCurves() { return default; }
	public int GetNumberOfFloatCurves() { return default; }
	public UObject GetAnimationSequence() { return default; }
}
