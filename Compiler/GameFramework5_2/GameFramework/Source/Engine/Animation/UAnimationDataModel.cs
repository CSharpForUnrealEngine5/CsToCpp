namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimData/IAnimationDataModel.h")]
public partial class UAnimationDataModel : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>@return       Total length of play-able animation data</summary>
	public virtual double GetPlayLength() { return default; }
	///<summary>@return       Total number of frames of animation data stored</summary>
	public virtual int GetNumberOfFrames() { return default; }
	///<summary>@return       Total number of animation data keys stored</summary>
	public virtual int GetNumberOfKeys() { return default; }
	///<summary>@return       Frame rate at which the animation data is key-ed</summary>
	public virtual FFrameRate GetFrameRate() { return default; }
	///<summary>GetBoneAnimationTracks</summary>
	public virtual TArray<FBoneAnimationTrack> GetBoneAnimationTracks() { return default; }
	///<summary>GetBoneTrackByIndex</summary>
	public virtual FBoneAnimationTrack GetBoneTrackByIndex(int TrackIndex) { return default; }
	///<summary>GetBoneTrackByName</summary>
	public virtual FBoneAnimationTrack GetBoneTrackByName(string TrackName) { return default; }
	///<summary>GetBoneTrackIndex</summary>
	public virtual int GetBoneTrackIndex(FBoneAnimationTrack Track) { return default; }
	///<summary>GetBoneTrackIndexByName</summary>
	public virtual int GetBoneTrackIndexByName(string TrackName) { return default; }
	///<summary>IsValidBoneTrackIndex</summary>
	public virtual bool IsValidBoneTrackIndex(int TrackIndex) { return default; }
	///<summary>IsValidBoneTrackName</summary>
	public virtual bool IsValidBoneTrackName(string TrackName) { return default; }
	///<summary>@return       Total number of bone animation tracks</summary>
	public virtual int GetNumBoneTracks() { return default; }
	///<summary>Populates the provided array with all contained (bone) track names</summary>
	public virtual void GetBoneTrackNames(TArray<string> OutNames) {}
	///<summary>@return       Total number of stored FTransform curves</summary>
	public virtual int GetNumberOfTransformCurves() { return default; }
	///<summary>@return       Total number of stored float curves</summary>
	public virtual int GetNumberOfFloatCurves() { return default; }
	///<summary>@return       The outer UAnimSequence object if found, otherwise returns a nullptr</summary>
	public virtual UAnimSequence GetAnimationSequence() { return default; }
}
