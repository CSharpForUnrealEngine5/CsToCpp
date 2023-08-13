namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Procedurally determines where to spawn foliage meshes within a discrete area.</summary>
[CppInclude("ProceduralFoliageTile.h")]
public partial class UProceduralFoliageTile : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>FoliageSpawner</summary>
	public UProceduralFoliageSpawner FoliageSpawner;
	///<summary>InstancesArray</summary>
	public TArray<FProceduralFoliageInstance> InstancesArray;
}
