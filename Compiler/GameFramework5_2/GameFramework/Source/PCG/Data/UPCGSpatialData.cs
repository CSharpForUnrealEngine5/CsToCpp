namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>&quot;Concrete&quot; data base class for PCG generation</summary>
[CppInclude("Data/PCGSpatialData.h")]
public partial class UPCGSpatialData : UPCGData {
	public static UClass StaticClass() {return default;}
	///<summary>Returns the dimension of the data type, which has nothing to do with the dimension of its points</summary>
	public virtual int GetDimension() { return default; }
	///<summary>Returns the full bounds (including density fall-off) of the data</summary>
	public virtual FBox GetBounds() { return default; }
	///<summary>Returns the bounds in which the density is always 1</summary>
	public virtual FBox GetStrictBounds() { return default; }
	///<summary>Returns the expected data normal (for surfaces) or eventual projection axis (for volumes)</summary>
	public virtual FVector GetNormal() { return default; }
	///<summary>Computes the density at a given location</summary>
	public virtual float GetDensityAtPosition(FVector InPosition) { return default; }
	///<summary>Discretizes the data into points</summary>
	public UPCGPointData ToPointData() { return default; }
	///<summary>ToPointDataWithContext</summary>
	public UPCGPointData ToPointDataWithContext(FPCGContext Context) { return default; }
	///<summary>Sample rotation, scale and other attributes from this data at the query position. Returns true if Transform location and Bounds overlaps this data.</summary>
	public virtual bool SamplePoint(FTransform Transform,FBox Bounds,FPCGPoint OutPoint,UPCGMetadata OutMetadata) { return default; }
	///<summary>Project the query point onto this data, and sample point and metadata information at the projected position. Returns true if successful.</summary>
	public virtual bool ProjectPoint(FTransform InTransform,FBox InBounds,FPCGProjectionParams InParams,FPCGPoint OutPoint,UPCGMetadata OutMetadata) { return default; }
	///<summary>Returns true if the data has a non-trivial transform</summary>
	public virtual bool HasNonTrivialTransform() { return default; }
	///<summary>Returns a specialized data to intersect with another data</summary>
	public virtual UPCGIntersectionData IntersectWith(UPCGSpatialData InOther) { return default; }
	///<summary>Returns a specialized data to project this on another data of equal or higher dimension. Returns copy of this data if projection fails.</summary>
	public virtual UPCGSpatialData ProjectOn(UPCGSpatialData InOther,FPCGProjectionParams InParams/*=new FPCGProjectionParams()*/) { return default; }
	///<summary>Returns a specialized data to union this with another data</summary>
	public virtual UPCGUnionData UnionWith(UPCGSpatialData InOther) { return default; }
	///<summary>Subtract</summary>
	public virtual UPCGDifferenceData Subtract(UPCGSpatialData InOther) { return default; }
	///<summary>ConstMetadata</summary>
	public UPCGMetadata ConstMetadata() { return default; }
	///<summary>MutableMetadata</summary>
	public UPCGMetadata MutableMetadata() { return default; }
	///<summary>CreateEmptyMetadata</summary>
	public UPCGMetadata CreateEmptyMetadata() { return default; }
	///<summary>InitializeFromData</summary>
	public void InitializeFromData(UPCGSpatialData InSource,UPCGMetadata InMetadataParentOverride/*=nullptr*/,bool bInheritMetadata/*=true*/,bool bInheritAttributes/*=true*/) {}
	///<summary>TargetActor</summary>
	public TWeakObjectPtr<AActor> TargetActor;
	///<summary>bKeepZeroDensityPoints</summary>
	public bool bKeepZeroDensityPoints;
	///<summary>Not accessible through blueprint to make sure the constness is preserved</summary>
	public UPCGMetadata Metadata;
}
