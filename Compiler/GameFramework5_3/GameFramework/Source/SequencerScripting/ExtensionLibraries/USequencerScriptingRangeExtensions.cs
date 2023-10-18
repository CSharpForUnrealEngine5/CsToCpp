namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Function library containing methods that should be hoisted onto FSequencerScriptingRanges</summary>
[CppInclude("ExtensionLibraries/SequencerScriptingRangeExtensions.h")]
public partial class USequencerScriptingRangeExtensions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Check whether this range has a start</summary>
	public static bool HasStart(FSequencerScriptingRange Range) { return default; }
	///<summary>Check whether this range has an end</summary>
	public static bool HasEnd(FSequencerScriptingRange Range) { return default; }
	///<summary>Remove the start from this range, making it infinite</summary>
	public static void RemoveStart(FSequencerScriptingRange Range) {}
	///<summary>Remove the end from this range, making it infinite</summary>
	public static void RemoveEnd(FSequencerScriptingRange Range) {}
	///<summary>Get the starting time for the specified range in seconds, if it has one. Defined as the first valid time that is inside the range.</summary>
	public static float GetStartSeconds(FSequencerScriptingRange Range) { return default; }
	///<summary>Get the ending time for the specified range in seconds, if it has one. Defined as the first time that is outside of the range.</summary>
	public static float GetEndSeconds(FSequencerScriptingRange Range) { return default; }
	///<summary>Set the starting time for the specified range in seconds. Interpreted as the first valid time that is inside the range.</summary>
	public static void SetStartSeconds(FSequencerScriptingRange Range,float Start) {}
	///<summary>Set the ending time for the specified range in seconds. Interpreted as the first time that is outside of the range.</summary>
	public static void SetEndSeconds(FSequencerScriptingRange Range,float End) {}
	///<summary>Get the starting frame for the specified range, if it has one. Defined as the first valid frame that is inside the range.</summary>
	public static int GetStartFrame(FSequencerScriptingRange Range) { return default; }
	///<summary>Get the ending frame for the specified range, if it has one. Defined as the first subsequent frame that is outside of the range.</summary>
	public static int GetEndFrame(FSequencerScriptingRange Range) { return default; }
	///<summary>Set the starting frame for the specified range. Interpreted as the first valid frame that is inside the range.</summary>
	public static void SetStartFrame(FSequencerScriptingRange Range,int Start) {}
	///<summary>Set the ending frame for the specified range. Interpreted as the first subsequent frame that is outside of the range.</summary>
	public static void SetEndFrame(FSequencerScriptingRange Range,int End) {}
}
