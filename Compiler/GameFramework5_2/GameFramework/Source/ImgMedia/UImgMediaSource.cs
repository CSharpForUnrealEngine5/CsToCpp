#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ImgMediaSource.h")]
///<summary>Media source for EXR image sequences.</summary>
public partial class UImgMediaSource : UBaseMediaSource {
// ImgMediaSource
	public bool IsPathRelativeToProjectRoot_DEPRECATED;
	public FFrameRate FrameRateOverride;
	public string ProxyOverride;
	public bool bFillGapsInSequence;
	public FImgMediaSourceCustomizationSequenceProxy SequenceProxy;
	public  void GetProxies(TArray<string> OutProxies) {}
	public  string GetSequencePath() { return default; }
	public  void SetSequencePath(string Path) {}
	public  void AddGlobalCamera(AActor InActor) {}
	public  void RemoveGlobalCamera(AActor InActor) {}
	public  void SetTokenizedSequencePath(string Path) {}
	public  void AddTargetObject(AActor InActor) {}
	public  void RemoveTargetObject(AActor InActor) {}
	public  void SetMipLevelDistance(float Distance) {}
	public FDirectoryPath SequencePath;
}
