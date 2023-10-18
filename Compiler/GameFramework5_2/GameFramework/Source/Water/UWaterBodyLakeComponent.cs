namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaterBodyLakeComponent.h")]
public partial class UWaterBodyLakeComponent : UWaterBodyComponent {
	public static UClass StaticClass() {return default;}
	///<summary>LakeMeshComp</summary>
	public UStaticMeshComponent LakeMeshComp;
	///<summary>LakeCollision</summary>
	public ULakeCollisionComponent LakeCollision;
}
