namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/HLOD/DestructibleHLODComponent.h")]
public partial class UWorldPartitionDestructibleHLODMeshComponent : UWorldPartitionDestructibleHLODComponent {
	public static UClass StaticClass() {return default;}
	///<summary>DestructibleHLODMaterial</summary>
	public UMaterialInterface DestructibleHLODMaterial;
	///<summary>DestructibleHLODState</summary>
	public FWorldPartitionDestructibleHLODState DestructibleHLODState;
	///<summary>VisibilityMaterial</summary>
	public UMaterialInstanceDynamic VisibilityMaterial;
	///<summary>VisibilityTexture</summary>
	public UTexture2DDynamic VisibilityTexture;
}
