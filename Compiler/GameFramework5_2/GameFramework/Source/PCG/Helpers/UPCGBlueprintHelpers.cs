namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Helpers/PCGBlueprintHelpers.h")]
public partial class UPCGBlueprintHelpers : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>ComputeSeedFromPosition</summary>
	public static int ComputeSeedFromPosition(FVector InPosition) { return default; }
	///<summary>SetSeedFromPosition</summary>
	public static void SetSeedFromPosition(FPCGPoint InPoint) {}
	///<summary>Creates a random stream from a point&#39;s seed and settings/component&#39;s seed (optional)</summary>
	public static FRandomStream GetRandomStream(FPCGPoint InPoint,UPCGSettings OptionalSettings/*=nullptr*/,UPCGComponent OptionalComponent/*=nullptr*/) { return default; }
	///<summary>GetSettings</summary>
	public static UPCGSettings GetSettings(FPCGContext Context) { return default; }
	///<summary>GetActorData</summary>
	public static UPCGData GetActorData(FPCGContext Context) { return default; }
	///<summary>GetInputData</summary>
	public static UPCGData GetInputData(FPCGContext Context) { return default; }
	///<summary>GetComponent</summary>
	public static UPCGComponent GetComponent(FPCGContext Context) { return default; }
	///<summary>GetOriginalComponent</summary>
	public static UPCGComponent GetOriginalComponent(FPCGContext Context) { return default; }
	///<summary>SetExtents</summary>
	public static void SetExtents(FPCGPoint InPoint,FVector InExtents) {}
	///<summary>GetExtents</summary>
	public static FVector GetExtents(FPCGPoint InPoint) { return default; }
	///<summary>SetLocalCenter</summary>
	public static void SetLocalCenter(FPCGPoint InPoint,FVector InLocalCenter) {}
	///<summary>GetLocalCenter</summary>
	public static FVector GetLocalCenter(FPCGPoint InPoint) { return default; }
	///<summary>GetTransformedBounds</summary>
	public static FBox GetTransformedBounds(FPCGPoint InPoint) { return default; }
	///<summary>GetActorBoundsPCG</summary>
	public static FBox GetActorBoundsPCG(AActor InActor,bool bIgnorePCGCreatedComponents/*=true*/) { return default; }
	///<summary>GetActorLocalBoundsPCG</summary>
	public static FBox GetActorLocalBoundsPCG(AActor InActor,bool bIgnorePCGCreatedComponents/*=true*/) { return default; }
	///<summary>CreatePCGDataFromActor</summary>
	public static UPCGData CreatePCGDataFromActor(AActor InActor,bool bParseActor/*=true*/) { return default; }
	///<summary>GetInterpolatedPCGLandscapeLayerWeights</summary>
	public static TArray<FPCGLandscapeLayerWeight> GetInterpolatedPCGLandscapeLayerWeights(UObject WorldContextObject,FVector Location) { return default; }
	///<summary>GetTaskId</summary>
	public static long GetTaskId(FPCGContext Context) { return default; }
}
