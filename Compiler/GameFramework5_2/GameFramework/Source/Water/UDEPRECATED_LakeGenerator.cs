#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaterBodyLakeActor.h")]
public partial class UDEPRECATED_LakeGenerator : UDEPRECATED_WaterBodyGenerator {
	public static UClass StaticClass() {return default;}
	///<summary>LakeMeshComp</summary>
	public UStaticMeshComponent LakeMeshComp;
	///<summary>LakeCollisionComp_DEPRECATED</summary>
	public UBoxComponent LakeCollisionComp_DEPRECATED;
	///<summary>LakeCollision</summary>
	public ULakeCollisionComponent LakeCollision;
}
