namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGExecuteBlueprint.h")]
public partial class UPCGBlueprintElement : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>~End UObject interface</summary>
	public void ExecuteWithContext(FPCGContext InContext,FPCGDataCollection Input,FPCGDataCollection Output) {}
	///<summary>Execute</summary>
	public void Execute(FPCGDataCollection Input,FPCGDataCollection Output) {}
	///<summary>PointLoopBody</summary>
	public bool PointLoopBody(FPCGContext InContext,UPCGPointData InData,FPCGPoint InPoint,FPCGPoint OutPoint,UPCGMetadata OutMetadata) { return default; }
	///<summary>VariableLoopBody</summary>
	public TArray<FPCGPoint> VariableLoopBody(FPCGContext InContext,UPCGPointData InData,FPCGPoint InPoint,UPCGMetadata OutMetadata) { return default; }
	///<summary>NestedLoopBody</summary>
	public bool NestedLoopBody(FPCGContext InContext,UPCGPointData InOuterData,UPCGPointData InInnerData,FPCGPoint InOuterPoint,FPCGPoint InInnerPoint,FPCGPoint OutPoint,UPCGMetadata OutMetadata) { return default; }
	///<summary>IterationLoopBody</summary>
	public bool IterationLoopBody(FPCGContext InContext,long Iteration,UPCGSpatialData InA,UPCGSpatialData InB,FPCGPoint OutPoint,UPCGMetadata OutMetadata) { return default; }
	///<summary>Calls the PointLoopBody function on all points</summary>
	public void PointLoop(FPCGContext InContext,UPCGPointData InData,UPCGPointData OutData,UPCGPointData OptionalOutData/*=nullptr*/) {}
	///<summary>Calls the VariableLoopBody function on all points, each call can return a variable number of points</summary>
	public void VariableLoop(FPCGContext InContext,UPCGPointData InData,UPCGPointData OutData,UPCGPointData OptionalOutData/*=nullptr*/) {}
	///<summary>Calls the NestedLoopBody function on all nested loop pairs (e.g. (o, i) for all o in Outer, i in Inner)</summary>
	public void NestedLoop(FPCGContext InContext,UPCGPointData InOuterData,UPCGPointData InInnerData,UPCGPointData OutData,UPCGPointData OptionalOutData/*=nullptr*/) {}
	///<summary>Calls the IterationLoopBody a fixed number of times, optional parameters are used to potentially initialized the Out Data, but otherwise are used to remove the need to have variables</summary>
	public void IterationLoop(FPCGContext InContext,long NumIterations,UPCGPointData OutData,UPCGSpatialData OptionalA/*=nullptr*/,UPCGSpatialData OptionalB/*=nullptr*/,UPCGPointData OptionalOutData/*=nullptr*/) {}
	///<summary>Override for the default node name</summary>
	public FName NodeTitleOverride() { return default; }
	///<summary>NodeColorOverride</summary>
	public FLinearColor NodeColorOverride() { return default; }
	///<summary>NodeTypeOverride</summary>
	public EPCGSettingsType NodeTypeOverride() { return default; }
	///<summary>Override for the IsCacheable node property when it depends on the settings in your node</summary>
	public bool IsCacheableOverride() { return default; }
	///<summary>ApplyPreconfiguredSettings</summary>
	public void ApplyPreconfiguredSettings(FPCGPreConfiguredSettingsInfo InPreconfigureInfo) {}
	///<summary>Returns the labels of custom input pins only</summary>
	public TSet<FName> CustomInputLabels() { return default; }
	///<summary>Returns the labels of custom output pins only</summary>
	public TSet<FName> CustomOutputLabels() { return default; }
	///<summary>GetInputPins</summary>
	public TArray<FPCGPinProperties> GetInputPins() { return default; }
	///<summary>GetOutputPins</summary>
	public TArray<FPCGPinProperties> GetOutputPins() { return default; }
	///<summary>Returns true if there is an input pin with the matching label. If found, will copy the pin properties in OutFoundPin</summary>
	public bool GetInputPinByLabel(FName InPinLabel,FPCGPinProperties OutFoundPin) { return default; }
	///<summary>Returns true if there is an output pin with the matching label. If found, will copy the pin properties in OutFoundPin</summary>
	public bool GetOutputPinByLabel(FName InPinLabel,FPCGPinProperties OutFoundPin) { return default; }
	///<summary>Gets the seed from the associated settings &amp; source component</summary>
	public int GetSeed(FPCGContext InContext) { return default; }
	///<summary>Creates a random stream from the settings &amp; source component</summary>
	public FRandomStream GetRandomStream(FPCGContext InContext) { return default; }
	///<summary>Retrieves the execution context - note that this will not be valid outside of the Execute functions</summary>
	public FPCGContext GetContext() { return default; }
	///<summary>Controls whether results can be cached so we can bypass execution if the inputs &amp; settings are the same in a subsequent execution.</summary>
	public bool bIsCacheable;
	///<summary>In cases where your node is non-cacheable but is likely to yield the same results on subsequent executions, this controls whether we will do a deep &amp; computationally intensive CRC computation (true),</summary>
	public bool bComputeFullDataCrc;
	///<summary>Controls whether this node execution can be run from a non-game thread. This is not related to the Loop functions provided/implemented in this class, which should always run on any thread.</summary>
	public bool bCanBeMultithreaded;
	///<summary>InputPinLabels_DEPRECATED</summary>
	public TSet<FName> InputPinLabels_DEPRECATED;
	///<summary>OutputPinLabels_DEPRECATED</summary>
	public TSet<FName> OutputPinLabels_DEPRECATED;
	///<summary>CustomInputPins</summary>
	public TArray<FPCGPinProperties> CustomInputPins;
	///<summary>CustomOutputPins</summary>
	public TArray<FPCGPinProperties> CustomOutputPins;
	///<summary>bHasDefaultInPin</summary>
	public bool bHasDefaultInPin;
	///<summary>bHasDefaultOutPin</summary>
	public bool bHasDefaultOutPin;
	///<summary>bExposeToLibrary</summary>
	public bool bExposeToLibrary;
	///<summary>bEnablePreconfiguredSettings</summary>
	public bool bEnablePreconfiguredSettings;
	///<summary>bOnlyExposePreconfiguredSettings</summary>
	public bool bOnlyExposePreconfiguredSettings;
	///<summary>PreconfiguredInfo</summary>
	public TArray<FPCGPreConfiguredSettingsInfo> PreconfiguredInfo;
	///<summary>Category</summary>
	public FText Category;
	///<summary>Description</summary>
	public FText Description;
	///<summary>DependencyParsingDepth</summary>
	public int DependencyParsingDepth;
}
