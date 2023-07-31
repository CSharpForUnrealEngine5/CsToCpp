#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Media source for EXR image sequences.</summary>
[CppInclude("ImgMediaSource.h")]
public partial class UImgMediaSource : UBaseMediaSource {
	///<summary>If true, then relative Sequence Paths are relative to the project root directory. If false, then relative to the Content directory.</summary>
	public bool IsPathRelativeToProjectRoot_DEPRECATED;
	///<summary>Overrides the default frame rate stored in the image files (0/0 = do not override).</summary>
	public FFrameRate FrameRateOverride;
	///<summary>Name of the proxy directory to use.</summary>
	public string ProxyOverride;
	///<summary>If true, then any gaps in the sequence will be filled with blank frames.</summary>
	public bool bFillGapsInSequence;
	///<summary>This is only used so we can customize editing of SequencePath.</summary>
	public FImgMediaSourceCustomizationSequenceProxy SequenceProxy;
	///<summary>Get the names of available proxy directories.</summary>
	public  void GetProxies(TArray<string> OutProxies) {}
	///<summary>Get the path to the image sequence directory to be played. Supported tokens will be expanded.</summary>
	public  string GetSequencePath() { return default; }
	///<summary>Set the path to the image sequence directory this source represents.</summary>
	public  void SetSequencePath(string Path) {}
	///<summary>AddGlobalCamera</summary>
	public  void AddGlobalCamera(AActor InActor) {}
	///<summary>RemoveGlobalCamera</summary>
	public  void RemoveGlobalCamera(AActor InActor) {}
	///<summary>Set the path to the image sequence directory this source represents.</summary>
	public  void SetTokenizedSequencePath(string Path) {}
	///<summary>This object is using our img sequence.</summary>
	public  void AddTargetObject(AActor InActor) {}
	///<summary>This object is no longer using our img sequence.</summary>
	public  void RemoveTargetObject(AActor InActor) {}
	///<summary>SetMipLevelDistance</summary>
	public  void SetMipLevelDistance(float Distance) {}
	///<summary>The directory that contains the image sequence files.</summary>
	public FDirectoryPath SequencePath;
}
