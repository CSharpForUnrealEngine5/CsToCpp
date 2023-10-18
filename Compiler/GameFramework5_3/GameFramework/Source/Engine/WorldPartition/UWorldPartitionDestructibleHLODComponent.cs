namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/HLOD/DestructibleHLODComponent.h")]
public partial class UWorldPartitionDestructibleHLODComponent : USceneComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Name of the destructible actors from the source cell.</summary>
	public TArray<FName> DestructibleActors;
}
