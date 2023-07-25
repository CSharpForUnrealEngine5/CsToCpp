#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ExtensionLibraries/MovieSceneSectionExtensions.h")]
///<summary>Function library containing methods that should be hoisted onto UMovieSceneSections for scripting</summary>
public partial class UMovieSceneSectionExtensions : UBlueprintFunctionLibrary {
// MovieSceneSectionExtensions
	public bool HasStartFrame(UObject Section) { return default; }
	public int GetStartFrame(UObject Section) { return default; }
	public float GetStartFrameSeconds(UObject Section) { return default; }
	public bool HasEndFrame(UObject Section) { return default; }
	public int GetEndFrame(UObject Section) { return default; }
	public float GetEndFrameSeconds(UObject Section) { return default; }
	public bool GetAutoSizeHasStartFrame(UObject Section) { return default; }
	public int GetAutoSizeStartFrame(UObject Section) { return default; }
	public float GetAutoSizeStartFrameSeconds(UObject Section) { return default; }
	public bool GetAutoSizeHasEndFrame(UObject Section) { return default; }
	public int GetAutoSizeEndFrame(UObject Section) { return default; }
	public float GetAutoSizeEndFrameSeconds(UObject Section) { return default; }
	public void SetRange(UObject Section,int StartFrame,int EndFrame) {}
	public void SetRangeSeconds(UObject Section,float StartTime,float EndTime) {}
	public void SetStartFrame(UObject Section,int StartFrame) {}
	public void SetStartFrameSeconds(UObject Section,float StartTime) {}
	public void SetStartFrameBounded(UObject Section,bool bIsBounded) {}
	public void SetEndFrame(UObject Section,int EndFrame) {}
	public void SetEndFrameSeconds(UObject Section,float EndTime) {}
	public void SetEndFrameBounded(UObject Section,bool bIsBounded) {}
	public TArray<UObject> GetChannels(UObject Section) { return default; }
	public TArray<UObject> GetAllChannels(UObject Section) { return default; }
	public TArray<UObject> FindChannelsByType(UObject Section,UClass ChannelType) { return default; }
	public TArray<UObject> GetChannelsByType(UObject Section,UClass ChannelType) { return default; }
	public int GetParentSequenceFrame(UObject Section,int InFrame,UObject ParentSequence) { return default; }
}
