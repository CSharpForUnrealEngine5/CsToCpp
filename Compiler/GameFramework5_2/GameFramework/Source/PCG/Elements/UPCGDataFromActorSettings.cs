namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Builds a collection of PCG-compatible data from the selected actors.</summary>
[CppInclude("Elements/PCGDataFromActor.h")]
public partial class UPCGDataFromActorSettings : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>ActorSelector</summary>
	public FPCGActorSelectorSettings ActorSelector;
	///<summary>Mode</summary>
	public EPCGGetDataFromActorMode Mode;
	///<summary>This can be set false by inheriting nodes to hide the &#39;Mode&#39; property.</summary>
	public bool bDisplayModeSettings;
	///<summary>ExpectedPins</summary>
	public TArray<FName> ExpectedPins;
	///<summary>PropertyName</summary>
	public FName PropertyName;
	///<summary>If this is checked, found actors that are outside component bounds will not trigger a refresh. Only works for tags for now in editor.</summary>
	public bool bTrackActorsOnlyWithinBounds;
}
