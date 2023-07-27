#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/PCGSpatialData.h")]
///<summary>"Concrete" data base class for PCG generation</summary>
public partial class UPCGSpatialData : UPCGData {
// PCGSpatialData
	public  int GetDimension() { return default; }
	public  FBox GetBounds() { return default; }
	public  FBox GetStrictBounds() { return default; }
	public  FVector GetNormal() { return default; }
	public  float GetDensityAtPosition(FVector InPosition) { return default; }
	public  UPCGPointData ToPointData() { return default; }
	public  UPCGPointData ToPointDataWithContext(FPCGContext Context) { return default; }
	public  bool SamplePoint(FTransform Transform,FBox Bounds,FPCGPoint OutPoint,UPCGMetadata OutMetadata) { return default; }
	public  bool ProjectPoint(FTransform InTransform,FBox InBounds,FPCGProjectionParams InParams,FPCGPoint OutPoint,UPCGMetadata OutMetadata) { return default; }
	public  bool HasNonTrivialTransform() { return default; }
	public  UPCGIntersectionData IntersectWith(UPCGSpatialData InOther) { return default; }
	public  UPCGSpatialData ProjectOn(UPCGSpatialData InOther,FPCGProjectionParams InParams/*=new FPCGProjectionParams()*/) { return default; }
	public  UPCGUnionData UnionWith(UPCGSpatialData InOther) { return default; }
	public  UPCGDifferenceData Subtract(UPCGSpatialData InOther) { return default; }
	public  UPCGMetadata ConstMetadata() { return default; }
	public  UPCGMetadata MutableMetadata() { return default; }
	public  UPCGMetadata CreateEmptyMetadata() { return default; }
	public  void InitializeFromData(UPCGSpatialData InSource,UPCGMetadata InMetadataParentOverride/*=nullptr*/,bool bInheritMetadata/*=true*/,bool bInheritAttributes/*=true*/) {}
	public TWeakObjectPtr<AActor> TargetActor;
	public bool bKeepZeroDensityPoints;
	public UPCGMetadata Metadata;
}
