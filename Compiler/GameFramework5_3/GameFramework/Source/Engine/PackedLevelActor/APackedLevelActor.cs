namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>APackedLevelActor is the result of packing the source level (WorldAsset base class property) into a single actor. See FPackedLevelActorBuilder.</summary>
[CppInclude("PackedLevelActor/PackedLevelActor.h")]
public partial class APackedLevelActor : ALevelInstance {
	public static UClass StaticClass() {return default;}
	///<summary>PackedVersion</summary>
	public FGuid PackedVersion;
	///<summary>PackedHash</summary>
	public uint PackedHash;
}
