#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Clips meta-data that is stored on ULevelSequence assets that are recorded through the virtual camera.</summary>
[CppInclude("LevelSequence/VirtualCameraClipsMetaData.h")]
public partial class UVirtualCameraClipsMetaData : UObject {
	///<summary>@return The focal length for this clip</summary>
	public  float GetFocalLength() { return default; }
	///<summary>@return Whether or not the clip is selected.</summary>
	public  bool GetSelected() { return default; }
	///<summary>@return The name of the clip&#39;s recorded level.</summary>
	public  string GetRecordedLevelName() { return default; }
	///<summary>@return The initial frame of the clip</summary>
	public  int GetFrameCountStart() { return default; }
	///<summary>@return The final frame of the clip</summary>
	public  int GetFrameCountEnd() { return default; }
	///<summary>@return The length in frames of the clip.</summary>
	public  int GetLengthInFrames() { return default; }
	///<summary>@return The display rate of the clip.</summary>
	public  FFrameRate GetDisplayRate() { return default; }
	///<summary>@return Whether the clip was recorded by a CineCameraActor</summary>
	public  bool GetIsACineCameraRecording() { return default; }
	///<summary>Set the focal length associated with this clip.</summary>
	public  void SetFocalLength(float InFocalLength) {}
	///<summary>Set if this clip is &#39;selected&#39;</summary>
	public  void SetSelected(bool bInSelected) {}
	///<summary>Set the name of the level that the clip was recorded in.</summary>
	public  void SetRecordedLevelName(string InLevelName) {}
	///<summary>Set the initial frame of the clip used for calculating duration.</summary>
	public  void SetFrameCountStart(int InFrame) {}
	///<summary>Set the final frame of the clip used for calculating duration.</summary>
	public  void SetFrameCountEnd(int InFrame) {}
	///<summary>Set the length in frames of the clip used for AssetData calculations.</summary>
	public  void SetLengthInFrames(int InLength) {}
	///<summary>Set the DisplayRate of the clip used for AssetData calculations.</summary>
	public  void SetDisplayRate(FFrameRate InDisplayRate) {}
	///<summary>Set if the clip was recorded by a CineCameraActor</summary>
	public  void SetIsACineCameraRecording(bool bInIsACineCameraRecording) {}
	///<summary>The focal length of the streamed camera used to record the take</summary>
	public float FocalLength;
	///<summary>Whether or not the take was marked as &#39;selected&#39;</summary>
	public bool bIsSelected;
	///<summary>The name of the level that the clip was recorded in</summary>
	public string RecordedLevelName;
	///<summary>The initial frame of the clip used for calculating duration.</summary>
	public int FrameCountStart;
	///<summary>The last frame of the clip used for calculating duration.</summary>
	public int FrameCountEnd;
	///<summary>The level sequence length in frames calculated from VirtualCameraSubsystem used for AssetData calculations</summary>
	public int LengthInFrames;
	///<summary>The display rate of the level sequence used for AssetData calculations.</summary>
	public FFrameRate DisplayRate;
	///<summary>If the LevelSequence was recorded with a CineCameraActor, rather than a VirtualCameraActor</summary>
	public bool bIsACineCameraRecording;
}
