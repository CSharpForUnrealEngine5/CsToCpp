#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Helpers/PCGBlueprintHelpers.h")]
public partial class UPCGBlueprintHelpers : UBlueprintFunctionLibrary {
// PCGBlueprintHelpers
	public static int ComputeSeedFromPosition(FVector InPosition) { return default; }
	public static void SetSeedFromPosition(FPCGPoint InPoint) {}
	public static FRandomStream GetRandomStream(FPCGPoint InPoint,UPCGSettings OptionalSettings/*=nullptr*/,UPCGComponent OptionalComponent/*=nullptr*/) { return default; }
	public static UPCGSettings GetSettings(FPCGContext Context) { return default; }
	public static UPCGData GetActorData(FPCGContext Context) { return default; }
	public static UPCGData GetInputData(FPCGContext Context) { return default; }
	public static UPCGComponent GetComponent(FPCGContext Context) { return default; }
	public static UPCGComponent GetOriginalComponent(FPCGContext Context) { return default; }
	public static void SetExtents(FPCGPoint InPoint,FVector InExtents) {}
	public static FVector GetExtents(FPCGPoint InPoint) { return default; }
	public static void SetLocalCenter(FPCGPoint InPoint,FVector InLocalCenter) {}
	public static FVector GetLocalCenter(FPCGPoint InPoint) { return default; }
	public static FBox GetTransformedBounds(FPCGPoint InPoint) { return default; }
	public static FBox GetActorBoundsPCG(AActor InActor,bool bIgnorePCGCreatedComponents/*=true*/) { return default; }
	public static FBox GetActorLocalBoundsPCG(AActor InActor,bool bIgnorePCGCreatedComponents/*=true*/) { return default; }
	public static UPCGData CreatePCGDataFromActor(AActor InActor,bool bParseActor/*=true*/) { return default; }
	public static TArray<FPCGLandscapeLayerWeight> GetInterpolatedPCGLandscapeLayerWeights(UObject WorldContextObject,FVector Location) { return default; }
	public static long GetTaskId(FPCGContext Context) { return default; }
}
