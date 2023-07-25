#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PackedLevelActor/PackedLevelActor.h")]
///<summary>APackedLevelActor is the result of packing the source level (WorldAsset base class property) into a single actor. See FPackedLevelActorBuilder.</summary>
public partial class APackedLevelActor : ALevelInstance {
// PackedLevelActor
	public TArray<TSoftObjectPtr<UBlueprint>> PackedBPDependencies;
	public FGuid PackedVersion;
}
