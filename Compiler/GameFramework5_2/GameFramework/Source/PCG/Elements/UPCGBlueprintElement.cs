#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGExecuteBlueprint.h")]
public partial class UPCGBlueprintElement : UObject {
// PCGBlueprintElement
	public  void ExecuteWithContext(FPCGContext InContext,FPCGDataCollection Input,FPCGDataCollection Output) {}
	public  void Execute(FPCGDataCollection Input,FPCGDataCollection Output) {}
	public  bool PointLoopBody(FPCGContext InContext,UPCGPointData InData,FPCGPoint InPoint,FPCGPoint OutPoint,UPCGMetadata OutMetadata) { return default; }
	public  TArray<FPCGPoint> VariableLoopBody(FPCGContext InContext,UPCGPointData InData,FPCGPoint InPoint,UPCGMetadata OutMetadata) { return default; }
	public  bool NestedLoopBody(FPCGContext InContext,UPCGPointData InOuterData,UPCGPointData InInnerData,FPCGPoint InOuterPoint,FPCGPoint InInnerPoint,FPCGPoint OutPoint,UPCGMetadata OutMetadata) { return default; }
	public  bool IterationLoopBody(FPCGContext InContext,long Iteration,UPCGSpatialData InA,UPCGSpatialData InB,FPCGPoint OutPoint,UPCGMetadata OutMetadata) { return default; }
	public  void PointLoop(FPCGContext InContext,UPCGPointData InData,UPCGPointData OutData,UPCGPointData OptionalOutData/*=nullptr*/) {}
	public  void VariableLoop(FPCGContext InContext,UPCGPointData InData,UPCGPointData OutData,UPCGPointData OptionalOutData/*=nullptr*/) {}
	public  void NestedLoop(FPCGContext InContext,UPCGPointData InOuterData,UPCGPointData InInnerData,UPCGPointData OutData,UPCGPointData OptionalOutData/*=nullptr*/) {}
	public  void IterationLoop(FPCGContext InContext,long NumIterations,UPCGPointData OutData,UPCGSpatialData OptionalA/*=nullptr*/,UPCGSpatialData OptionalB/*=nullptr*/,UPCGPointData OptionalOutData/*=nullptr*/) {}
	public  string NodeTitleOverride() { return default; }
	public  FLinearColor NodeColorOverride() { return default; }
	public  EPCGSettingsType NodeTypeOverride() { return default; }
	public  TSet<string> InputLabels() { return default; }
	public  TSet<string> OutputLabels() { return default; }
	public  int GetSeed(FPCGContext InContext) { return default; }
	public  FRandomStream GetRandomStream(FPCGContext InContext) { return default; }
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
