#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Helpers/PCGBlueprintHelpers.h")]
public partial class UPCGBlueprintHelpers : UBlueprintFunctionLibrary {
// PCGBlueprintHelpers
	public int ComputeSeedFromPosition(FVector InPosition) { return default; }
	public void SetSeedFromPosition(FPCGPoint InPoint) {}
	public FRandomStream GetRandomStream(FPCGPoint InPoint,UObject OptionalSettings/*=nullptr*/,UObject OptionalComponent/*=nullptr*/) { return default; }
	public UObject GetSettings(FPCGContext Context) { return default; }
	public UObject GetActorData(FPCGContext Context) { return default; }
	public UObject GetInputData(FPCGContext Context) { return default; }
	public UObject GetComponent(FPCGContext Context) { return default; }
	public UObject GetOriginalComponent(FPCGContext Context) { return default; }
	public void SetExtents(FPCGPoint InPoint,FVector InExtents) {}
	public FVector GetExtents(FPCGPoint InPoint) { return default; }
	public void SetLocalCenter(FPCGPoint InPoint,FVector InLocalCenter) {}
	public FVector GetLocalCenter(FPCGPoint InPoint) { return default; }
	public FBox GetTransformedBounds(FPCGPoint InPoint) { return default; }
	public FBox GetActorBoundsPCG(UObject InActor,bool bIgnorePCGCreatedComponents/*=true*/) { return default; }
	public FBox GetActorLocalBoundsPCG(UObject InActor,bool bIgnorePCGCreatedComponents/*=true*/) { return default; }
	public UObject CreatePCGDataFromActor(UObject InActor,bool bParseActor/*=true*/) { return default; }
	public TArray<FPCGLandscapeLayerWeight> GetInterpolatedPCGLandscapeLayerWeights(UObject WorldContextObject,FVector Location) { return default; }
	public long GetTaskId(FPCGContext Context) { return default; }
}
