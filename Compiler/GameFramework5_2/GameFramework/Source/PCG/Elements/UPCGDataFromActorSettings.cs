#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGDataFromActor.h")]
///<summary>Builds a collection of PCG-compatible data from the selected actors.</summary>
public partial class UPCGDataFromActorSettings : UPCGSettings {
// PCGDataFromActorSettings
	public FPCGActorSelectorSettings ActorSelector;
	public EPCGGetDataFromActorMode Mode;
	public bool bDisplayModeSettings;
	public TArray<string> ExpectedPins;
	public string PropertyName;
	public bool bTrackActorsOnlyWithinBounds;
}
