#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Builds a collection of PCG-compatible data from the selected actors.</summary>
[CppInclude("Elements/PCGDataFromActor.h")]
public partial class UPCGDataFromActorSettings : UPCGSettings {
	///<summary>ActorSelector</summary>
	public FPCGActorSelectorSettings ActorSelector;
	///<summary>Mode</summary>
	public EPCGGetDataFromActorMode Mode;
	///<summary>This can be set false by inheriting nodes to hide the &#39;Mode&#39; property.</summary>
	public bool bDisplayModeSettings;
	///<summary>ExpectedPins</summary>
	public TArray<string> ExpectedPins;
	///<summary>PropertyName</summary>
	public string PropertyName;
	///<summary>If this is checked, found actors that are outside component bounds will not trigger a refresh. Only works for tags for now in editor.</summary>
	public bool bTrackActorsOnlyWithinBounds;
}
