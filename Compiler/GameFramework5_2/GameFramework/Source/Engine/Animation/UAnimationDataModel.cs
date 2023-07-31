#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimData/IAnimationDataModel.h")]
public partial class UAnimationDataModel : UInterface {
	///<summary>@return       Total length of play-able animation data</summary>
	public  double GetPlayLength() { return default; }
	///<summary>@return       Total number of frames of animation data stored</summary>
	public  int GetNumberOfFrames() { return default; }
	///<summary>@return       Total number of animation data keys stored</summary>
	public  int GetNumberOfKeys() { return default; }
	///<summary>@return       Frame rate at which the animation data is key-ed</summary>
	public  FFrameRate GetFrameRate() { return default; }
	///<summary>GetBoneAnimationTracks</summary>
	public  TArray<FBoneAnimationTrack> GetBoneAnimationTracks() { return default; }
	///<summary>GetBoneTrackByIndex</summary>
	public  FBoneAnimationTrack GetBoneTrackByIndex(int TrackIndex) { return default; }
	///<summary>GetBoneTrackByName</summary>
	public  FBoneAnimationTrack GetBoneTrackByName(string TrackName) { return default; }
	///<summary>GetBoneTrackIndex</summary>
	public  int GetBoneTrackIndex(FBoneAnimationTrack Track) { return default; }
	///<summary>GetBoneTrackIndexByName</summary>
	public  int GetBoneTrackIndexByName(string TrackName) { return default; }
	///<summary>IsValidBoneTrackIndex</summary>
	public  bool IsValidBoneTrackIndex(int TrackIndex) { return default; }
	///<summary>IsValidBoneTrackName</summary>
	public  bool IsValidBoneTrackName(string TrackName) { return default; }
	///<summary>@return       Total number of bone animation tracks</summary>
	public  int GetNumBoneTracks() { return default; }
	///<summary>Populates the provided array with all contained (bone) track names</summary>
	public  void GetBoneTrackNames(TArray<string> OutNames) {}
	///<summary>@return       Total number of stored FTransform curves</summary>
	public  int GetNumberOfTransformCurves() { return default; }
	///<summary>@return       Total number of stored float curves</summary>
	public  int GetNumberOfFloatCurves() { return default; }
	///<summary>@return       The outer UAnimSequence object if found, otherwise returns a nullptr</summary>
	public  UAnimSequence GetAnimationSequence() { return default; }
}
