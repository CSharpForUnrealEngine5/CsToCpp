namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InstancedFoliageActor.h")]
public partial class AInstancedFoliageActor : AISMPartitionActor {
	public static UClass StaticClass() {return default;}
	///<summary>AddInstances</summary>
	public static void AddInstances(UObject WorldContextObject,UFoliageType InFoliageType,TArray<FTransform> InTransforms) {}
	///<summary>RemoveAllInstances</summary>
	public static void RemoveAllInstances(UObject WorldContextObject,UFoliageType InFoliageType) {}
}
