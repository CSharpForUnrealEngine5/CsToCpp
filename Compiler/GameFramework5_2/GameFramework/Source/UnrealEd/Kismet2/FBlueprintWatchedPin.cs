#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet2/WatchedPin.h")]
///<summary>Contains information about a watched pin in a Blueprint graph for local settings data.</summary>
public partial struct FBlueprintWatchedPin {
// BlueprintWatchedPin
	public TSoftObjectPtr<UEdGraphNode> OwningNode;
	public FGuid PinId;
	public TArray<string> PathToProperty;
}
