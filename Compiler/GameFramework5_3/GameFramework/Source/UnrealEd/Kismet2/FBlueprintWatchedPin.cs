namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Contains information about a watched pin in a Blueprint graph for local settings data.</summary>
[CppInclude("Kismet2/WatchedPin.h")]
public partial struct FBlueprintWatchedPin {
	public TSoftObjectPtr<UEdGraphNode> OwningNode;
	public FGuid PinId;
	public TArray<FName> PathToProperty;
}
