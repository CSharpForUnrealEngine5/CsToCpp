#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ExtensionLibraries/MovieSceneSectionExtensions.h")]
///<summary>Function library containing methods that should be hoisted onto UMovieSceneSections for scripting</summary>
public partial class UMovieSceneSectionExtensions : UBlueprintFunctionLibrary {
// MovieSceneSectionExtensions
	public static bool HasStartFrame(UMovieSceneSection Section) { return default; }
	public static int GetStartFrame(UMovieSceneSection Section) { return default; }
	public static float GetStartFrameSeconds(UMovieSceneSection Section) { return default; }
	public static bool HasEndFrame(UMovieSceneSection Section) { return default; }
	public static int GetEndFrame(UMovieSceneSection Section) { return default; }
	public static float GetEndFrameSeconds(UMovieSceneSection Section) { return default; }
	public static bool GetAutoSizeHasStartFrame(UMovieSceneSection Section) { return default; }
	public static int GetAutoSizeStartFrame(UMovieSceneSection Section) { return default; }
	public static float GetAutoSizeStartFrameSeconds(UMovieSceneSection Section) { return default; }
	public static bool GetAutoSizeHasEndFrame(UMovieSceneSection Section) { return default; }
	public static int GetAutoSizeEndFrame(UMovieSceneSection Section) { return default; }
	public static float GetAutoSizeEndFrameSeconds(UMovieSceneSection Section) { return default; }
	public static void SetRange(UMovieSceneSection Section,int StartFrame,int EndFrame) {}
	public static void SetRangeSeconds(UMovieSceneSection Section,float StartTime,float EndTime) {}
	public static void SetStartFrame(UMovieSceneSection Section,int StartFrame) {}
	public static void SetStartFrameSeconds(UMovieSceneSection Section,float StartTime) {}
	public static void SetStartFrameBounded(UMovieSceneSection Section,bool bIsBounded) {}
	public static void SetEndFrame(UMovieSceneSection Section,int EndFrame) {}
	public static void SetEndFrameSeconds(UMovieSceneSection Section,float EndTime) {}
	public static void SetEndFrameBounded(UMovieSceneSection Section,bool bIsBounded) {}
	public static TArray<UMovieSceneScriptingChannel> GetChannels(UMovieSceneSection Section) { return default; }
	public static TArray<UMovieSceneScriptingChannel> GetAllChannels(UMovieSceneSection Section) { return default; }
	public static TArray<UMovieSceneScriptingChannel> FindChannelsByType(UMovieSceneSection Section,UClass ChannelType) { return default; }
	public static TArray<UMovieSceneScriptingChannel> GetChannelsByType(UMovieSceneSection Section,UClass ChannelType) { return default; }
	public static int GetParentSequenceFrame(UMovieSceneSubSection Section,int InFrame,UMovieSceneSequence ParentSequence) { return default; }
}
