#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ExtensionLibraries/SequencerScriptingRangeExtensions.h")]
///<summary>Function library containing methods that should be hoisted onto FSequencerScriptingRanges</summary>
public partial class USequencerScriptingRangeExtensions : UBlueprintFunctionLibrary {
// SequencerScriptingRangeExtensions
	public bool HasStart(FSequencerScriptingRange Range) { return default; }
	public bool HasEnd(FSequencerScriptingRange Range) { return default; }
	public void RemoveStart(FSequencerScriptingRange Range) {}
	public void RemoveEnd(FSequencerScriptingRange Range) {}
	public float GetStartSeconds(FSequencerScriptingRange Range) { return default; }
	public float GetEndSeconds(FSequencerScriptingRange Range) { return default; }
	public void SetStartSeconds(FSequencerScriptingRange Range,float Start) {}
	public void SetEndSeconds(FSequencerScriptingRange Range,float End) {}
	public int GetStartFrame(FSequencerScriptingRange Range) { return default; }
	public int GetEndFrame(FSequencerScriptingRange Range) { return default; }
	public void SetStartFrame(FSequencerScriptingRange Range,int Start) {}
	public void SetEndFrame(FSequencerScriptingRange Range,int End) {}
}
