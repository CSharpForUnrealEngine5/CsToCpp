namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A data asset for indexing a collection of animation sequences.</summary>
[CppInclude("PoseSearch/PoseSearchDatabase.h")]
public partial class UNormalizationSetAsset : UDataAsset {
	public static UClass StaticClass() {return default;}
	///<summary>Databases</summary>
	public TArray<UPoseSearchDatabase> Databases;
}
