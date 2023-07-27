#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ExtensionLibraries/SequencerScriptingRangeExtensions.h")]
///<summary>Function library containing methods that should be hoisted onto FSequencerScriptingRanges</summary>
public partial class USequencerScriptingRangeExtensions : UBlueprintFunctionLibrary {
// SequencerScriptingRangeExtensions
	public static bool HasStart(FSequencerScriptingRange Range) { return default; }
	public static bool HasEnd(FSequencerScriptingRange Range) { return default; }
	public static void RemoveStart(FSequencerScriptingRange Range) {}
	public static void RemoveEnd(FSequencerScriptingRange Range) {}
	public static float GetStartSeconds(FSequencerScriptingRange Range) { return default; }
	public static float GetEndSeconds(FSequencerScriptingRange Range) { return default; }
	public static void SetStartSeconds(FSequencerScriptingRange Range,float Start) {}
	public static void SetEndSeconds(FSequencerScriptingRange Range,float End) {}
	public static int GetStartFrame(FSequencerScriptingRange Range) { return default; }
	public static int GetEndFrame(FSequencerScriptingRange Range) { return default; }
	public static void SetStartFrame(FSequencerScriptingRange Range,int Start) {}
	public static void SetEndFrame(FSequencerScriptingRange Range,int End) {}
}
