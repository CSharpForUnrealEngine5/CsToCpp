namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FoliageStatistics.h")]
public partial class UFoliageStatistics : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Counts how many foliage instances overlap a given sphere</summary>
	public static int FoliageOverlappingSphereCount(UObject WorldContextObject,UStaticMesh StaticMesh,FVector CenterPosition,float Radius) { return default; }
	///<summary>Gets the number of instances overlapping a provided box</summary>
	public static int FoliageOverlappingBoxCount(UObject WorldContextObject,UStaticMesh StaticMesh,FBox Box) { return default; }
	///<summary>Get the transform of every instance overlapping the provided FBox</summary>
	public static void FoliageOverlappingBoxTransforms(UObject WorldContextObject,UStaticMesh StaticMesh,FBox Box,TArray<FTransform> OutTransforms) {}
}
