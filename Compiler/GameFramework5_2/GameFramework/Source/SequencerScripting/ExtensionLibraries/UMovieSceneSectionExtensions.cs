namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Function library containing methods that should be hoisted onto UMovieSceneSections for scripting</summary>
[CppInclude("ExtensionLibraries/MovieSceneSectionExtensions.h")]
public partial class UMovieSceneSectionExtensions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Has start frame</summary>
	public static bool HasStartFrame(UMovieSceneSection Section) { return default; }
	///<summary>Get start frame. Will throw an exception if section has no start frame, use HasStartFrame to check first.</summary>
	public static int GetStartFrame(UMovieSceneSection Section) { return default; }
	///<summary>Get start time in seconds. Will throw an exception if section has no start frame, use HasStartFrame to check first.</summary>
	public static float GetStartFrameSeconds(UMovieSceneSection Section) { return default; }
	///<summary>Has end frame</summary>
	public static bool HasEndFrame(UMovieSceneSection Section) { return default; }
	///<summary>Get end frame. Will throw an exception if section has no end frame, use HasEndFrame to check first.</summary>
	public static int GetEndFrame(UMovieSceneSection Section) { return default; }
	///<summary>Get end time in seconds. Will throw an exception if section has no end frame, use HasEndFrame to check first.</summary>
	public static float GetEndFrameSeconds(UMovieSceneSection Section) { return default; }
	///<summary>Checks to see if this section has an AutoSize implementation, and if so, if that implementation has a start frame.</summary>
	public static bool GetAutoSizeHasStartFrame(UMovieSceneSection Section) { return default; }
	///<summary>Get start frame of the AutoSize. Will throw an exception if section has no start frame, use GetAutoSizeHasStartFrame to check first.</summary>
	public static int GetAutoSizeStartFrame(UMovieSceneSection Section) { return default; }
	///<summary>Get start time of the AutoSize in seconds. Will throw an exception if section has no start frame, use GetAutoSizeHasStartFrame to check first.</summary>
	public static float GetAutoSizeStartFrameSeconds(UMovieSceneSection Section) { return default; }
	///<summary>Checks to see if this section has an AutoSize implementation, and if so, if that implementation has a end frame.</summary>
	public static bool GetAutoSizeHasEndFrame(UMovieSceneSection Section) { return default; }
	///<summary>Get end frame of the AutoSize. Will throw an exception if section has no end frame, use GetAutoSizeHasEndFrame to check first.</summary>
	public static int GetAutoSizeEndFrame(UMovieSceneSection Section) { return default; }
	///<summary>Get end time of the AutoSize seconds. Will throw an exception if section has no end frame, use GetAutoSizeHasEndFrame to check first.</summary>
	public static float GetAutoSizeEndFrameSeconds(UMovieSceneSection Section) { return default; }
	///<summary>Set range</summary>
	public static void SetRange(UMovieSceneSection Section,int StartFrame,int EndFrame) {}
	///<summary>Set range in seconds</summary>
	public static void SetRangeSeconds(UMovieSceneSection Section,float StartTime,float EndTime) {}
	///<summary>Set start frame</summary>
	public static void SetStartFrame(UMovieSceneSection Section,int StartFrame) {}
	///<summary>Set start time in seconds</summary>
	public static void SetStartFrameSeconds(UMovieSceneSection Section,float StartTime) {}
	///<summary>Set start frame bounded</summary>
	public static void SetStartFrameBounded(UMovieSceneSection Section,bool bIsBounded) {}
	///<summary>Set end frame</summary>
	public static void SetEndFrame(UMovieSceneSection Section,int EndFrame) {}
	///<summary>Set end time in seconds</summary>
	public static void SetEndFrameSeconds(UMovieSceneSection Section,float EndTime) {}
	///<summary>Set end frame bounded</summary>
	public static void SetEndFrameBounded(UMovieSceneSection Section,bool bIsBounded) {}
	///<summary>GetChannels</summary>
	public static TArray<UMovieSceneScriptingChannel> GetChannels(UMovieSceneSection Section) { return default; }
	///<summary>Find all channels that belong to the specified UMovieSceneSection. Some sections have many channels (such as</summary>
	public static TArray<UMovieSceneScriptingChannel> GetAllChannels(UMovieSceneSection Section) { return default; }
	///<summary>FindChannelsByType</summary>
	public static TArray<UMovieSceneScriptingChannel> FindChannelsByType(UMovieSceneSection Section,UClass ChannelType) { return default; }
	///<summary>Find all channels that belong to the specified UMovieSceneSection that match the specific type. This will filter out any children who do not inherit</summary>
	public static TArray<UMovieSceneScriptingChannel> GetChannelsByType(UMovieSceneSection Section,UClass ChannelType) { return default; }
	///<summary>Get the frame in the space of its parent sequence</summary>
	public static int GetParentSequenceFrame(UMovieSceneSubSection Section,int InFrame,UMovieSceneSequence ParentSequence) { return default; }
}
