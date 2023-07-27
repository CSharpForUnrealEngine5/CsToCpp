#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FoliageStatistics.h")]
public partial class UFoliageStatistics : UBlueprintFunctionLibrary {
// FoliageStatistics
	public static int FoliageOverlappingSphereCount(UObject WorldContextObject,UStaticMesh StaticMesh,FVector CenterPosition,float Radius) { return default; }
	public static int FoliageOverlappingBoxCount(UObject WorldContextObject,UStaticMesh StaticMesh,FBox Box) { return default; }
	public static void FoliageOverlappingBoxTransforms(UObject WorldContextObject,UStaticMesh StaticMesh,FBox Box,TArray<FTransform> OutTransforms) {}
}
