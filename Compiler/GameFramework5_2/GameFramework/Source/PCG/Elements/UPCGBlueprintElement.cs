#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGExecuteBlueprint.h")]
public partial class UPCGBlueprintElement : UObject {
// PCGBlueprintElement
	public void ExecuteWithContext(FPCGContext InContext,FPCGDataCollection Input,FPCGDataCollection Output) {}
	public void Execute(FPCGDataCollection Input,FPCGDataCollection Output) {}
	public bool PointLoopBody(FPCGContext InContext,UObject InData,FPCGPoint InPoint,FPCGPoint OutPoint,UObject OutMetadata) { return default; }
	public TArray<FPCGPoint> VariableLoopBody(FPCGContext InContext,UObject InData,FPCGPoint InPoint,UObject OutMetadata) { return default; }
	public bool NestedLoopBody(FPCGContext InContext,UObject InOuterData,UObject InInnerData,FPCGPoint InOuterPoint,FPCGPoint InInnerPoint,FPCGPoint OutPoint,UObject OutMetadata) { return default; }
	public bool IterationLoopBody(FPCGContext InContext,long Iteration,UObject InA,UObject InB,FPCGPoint OutPoint,UObject OutMetadata) { return default; }
	public void PointLoop(FPCGContext InContext,UObject InData,UObject OutData,UObject OptionalOutData/*=nullptr*/) {}
	public void VariableLoop(FPCGContext InContext,UObject InData,UObject OutData,UObject OptionalOutData/*=nullptr*/) {}
	public void NestedLoop(FPCGContext InContext,UObject InOuterData,UObject InInnerData,UObject OutData,UObject OptionalOutData/*=nullptr*/) {}
	public void IterationLoop(FPCGContext InContext,long NumIterations,UObject OutData,UObject OptionalA/*=nullptr*/,UObject OptionalB/*=nullptr*/,UObject OptionalOutData/*=nullptr*/) {}
	public string NodeTitleOverride() { return default; }
	public FLinearColor NodeColorOverride() { return default; }
	public EPCGSettingsType NodeTypeOverride() { return default; }
	public TSet<string> InputLabels() { return default; }
	public TSet<string> OutputLabels() { return default; }
	public int GetSeed(FPCGContext InContext) { return default; }
	public FRandomStream GetRandomStream(FPCGContext InContext) { return default; }
	public bool bCreatesArtifacts;
	public bool bCacheable;
	public bool bCanBeMultithreaded;
	public TSet<string> InputPinLabels_DEPRECATED;
	public TSet<string> OutputPinLabels_DEPRECATED;
	public TArray<FPCGPinProperties> CustomInputPins;
	public TArray<FPCGPinProperties> CustomOutputPins;
	public bool bHasDefaultInPin;
	public bool bHasDefaultOutPin;
	public bool bExposeToLibrary;
	public string Category;
	public string Description;
	public int DependencyParsingDepth;
}
