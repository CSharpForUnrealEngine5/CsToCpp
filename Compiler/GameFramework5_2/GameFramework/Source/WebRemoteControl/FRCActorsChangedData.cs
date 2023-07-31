#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data about actors that have changed in the scene.</summary>
[CppInclude("RemoteControlResponse.h")]
public partial struct FRCActorsChangedData {
	public TArray<FRCActorDescription> AddedActors;
	public TArray<FRCActorDescription> RenamedActors;
	public TArray<FRCActorDescription> DeletedActors;
}
