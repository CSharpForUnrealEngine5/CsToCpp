namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>APackedLevelActor is the result of packing the source level (WorldAsset base class property) into a single actor. See FPackedLevelActorBuilder.</summary>
[CppInclude("PackedLevelActor/PackedLevelActor.h")]
public partial class APackedLevelActor : ALevelInstance {
	public static UClass StaticClass() {return default;}
	///<summary>PackedBPDependencies</summary>
	public TArray<TSoftObjectPtr<UBlueprint>> PackedBPDependencies;
	///<summary>PackedVersion</summary>
	public FGuid PackedVersion;
}
