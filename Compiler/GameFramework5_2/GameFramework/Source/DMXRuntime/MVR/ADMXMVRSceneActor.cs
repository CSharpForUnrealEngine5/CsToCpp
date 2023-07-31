#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MVR/DMXMVRSceneActor.h")]
public partial class ADMXMVRSceneActor : AActor {
	///<summary>If checked, respawns Fixture Actors deleted from the MVR Scene</summary>
	public bool bRespawnDeletedActorsOnRefresh;
	///<summary>If checked, updates transforms from the DMX Library</summary>
	public bool bUpdateTransformsOnRefresh;
	///<summary>The DMX Library this Scene Actor uses</summary>
	public UDMXLibrary DMXLibrary;
	///<summary>The actors that created along with this scene</summary>
	public TArray<TSoftObjectPtr<AActor>> RelatedActors;
	///<summary>The actor class that is spawned for a specific GDTF by default (can be overriden per MVR UUID, see below)</summary>
	public TArray<FDMXMVRSceneGDTFToActorClassPair> GDTFToDefaultActorClasses;
	///<summary>Array holding MVR Fixture UUIDs that were explicitly removed from the scene</summary>
	public TArray<FGuid> DeletedMVRFixtureUUIDs;
	///<summary>The root component to which all actors are attached initially</summary>
	public USceneComponent MVRSceneRoot;
}
