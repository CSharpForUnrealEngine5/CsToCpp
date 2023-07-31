#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Event triggered when the list of actors in the current scene (or their names) changes.</summary>
[CppInclude("RemoteControlResponse.h")]
public partial struct FRCActorsChangedEvent {
	public string Type;
	public TMap<string,FRCActorsChangedData> Changes;
}
