#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/PCGSpatialData.h")]
///<summary>"Concrete" data base class for PCG generation</summary>
public partial class UPCGSpatialData : UPCGData {
// PCGSpatialData
	public int GetDimension() { return default; }
	public FBox GetBounds() { return default; }
	public FBox GetStrictBounds() { return default; }
	public FVector GetNormal() { return default; }
	public float GetDensityAtPosition(FVector InPosition) { return default; }
	public UObject ToPointData() { return default; }
	public UObject ToPointDataWithContext(FPCGContext Context) { return default; }
	public bool SamplePoint(FTransform Transform,FBox Bounds,FPCGPoint OutPoint,UObject OutMetadata) { return default; }
	public bool ProjectPoint(FTransform InTransform,FBox InBounds,FPCGProjectionParams InParams,FPCGPoint OutPoint,UObject OutMetadata) { return default; }
	public bool HasNonTrivialTransform() { return default; }
	public UObject IntersectWith(UObject InOther) { return default; }
	public UObject ProjectOn(UObject InOther,FPCGProjectionParams InParams/*=new FPCGProjectionParams()*/) { return default; }
	public UObject UnionWith(UObject InOther) { return default; }
	public UObject Subtract(UObject InOther) { return default; }
	public UObject ConstMetadata() { return default; }
	public UObject MutableMetadata() { return default; }
	public UObject CreateEmptyMetadata() { return default; }
	public void InitializeFromData(UObject InSource,UObject InMetadataParentOverride/*=nullptr*/,bool bInheritMetadata/*=true*/,bool bInheritAttributes/*=true*/) {}
	public TWeakObjectPtr<AActor> TargetActor;
	public bool bKeepZeroDensityPoints;
	public UPCGMetadata Metadata;
}
