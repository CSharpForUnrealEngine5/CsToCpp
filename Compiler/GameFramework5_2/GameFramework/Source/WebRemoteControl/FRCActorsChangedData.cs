#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlResponse.h")]
///<summary>Data about actors that have changed in the scene.</summary>
public partial struct FRCActorsChangedData {
// RCActorsChangedData
	public TArray<FRCActorDescription> AddedActors;
	public TArray<FRCActorDescription> RenamedActors;
	public TArray<FRCActorDescription> DeletedActors;
}
