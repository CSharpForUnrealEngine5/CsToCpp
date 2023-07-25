#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlResponse.h")]
///<summary>Event triggered when the list of actors in the current scene (or their names) changes.</summary>
public partial struct FRCActorsChangedEvent {
// RCActorsChangedEvent
	public string Type;
	public TMap<string,FRCActorsChangedData> Changes;
}
