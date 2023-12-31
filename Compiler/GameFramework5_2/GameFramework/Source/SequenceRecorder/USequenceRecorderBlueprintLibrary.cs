namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SequenceRecorderBlueprintLibrary.h")]
public partial class USequenceRecorderBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Start recording the passed-in actors to a level sequence.</summary>
	public static void StartRecordingSequence(TArray<AActor> ActorsToRecord) {}
	///<summary>Are we currently recording a sequence</summary>
	public static bool IsRecordingSequence() { return default; }
	///<summary>Stop recording the current sequence, if any</summary>
	public static void StopRecordingSequence() {}
}
