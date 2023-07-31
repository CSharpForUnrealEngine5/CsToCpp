#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Wrapper around result of quick binding for event track in sequencer.</summary>
[CppInclude("SequencerTools.h")]
public partial struct FSequencerQuickBindingResult {
	public UK2Node_CustomEvent EventEndpoint;
	public TArray<string> PayloadNames;
}
