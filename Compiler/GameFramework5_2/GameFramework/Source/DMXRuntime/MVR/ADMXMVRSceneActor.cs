#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MVR/DMXMVRSceneActor.h")]
public partial class ADMXMVRSceneActor : AActor {
// DMXMVRSceneActor
	public bool bRespawnDeletedActorsOnRefresh;
	public bool bUpdateTransformsOnRefresh;
	public UDMXLibrary DMXLibrary;
	public TArray<TSoftObjectPtr<AActor>> RelatedActors;
	public TArray<FDMXMVRSceneGDTFToActorClassPair> GDTFToDefaultActorClasses;
	public TArray<FGuid> DeletedMVRFixtureUUIDs;
	public USceneComponent MVRSceneRoot;
}
