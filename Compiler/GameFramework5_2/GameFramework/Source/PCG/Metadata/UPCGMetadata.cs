#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Metadata/PCGMetadata.h")]
public partial class UPCGMetadata : UObject {
// PCGMetadata
	public void Initialize(UObject InParent) {}
	public void InitializeWithAttributeFilter(UObject InParent,TSet<string> InFilteredAttributes,EPCGMetadataFilterMode InFilterMode/*=EPCGMetadataFilterMode.ExcludeAttributes*/) {}
	public void InitializeAsCopy(UObject InMetadataToCopy) {}
	public void InitializeAsCopyWithAttributeFilter(UObject InMetadataToCopy,TSet<string> InFilteredAttributes,EPCGMetadataFilterMode InFilterMode/*=EPCGMetadataFilterMode.ExcludeAttributes*/) {}
	public void AddAttributes(UObject InOther) {}
	public void AddAttributesFiltered(UObject InOther,TSet<string> InFilteredAttributes,EPCGMetadataFilterMode InFilterMode/*=EPCGMetadataFilterMode.ExcludeAttributes*/) {}
	public void AddAttribute(UObject InOther,string AttributeName) {}
	public void CopyAttributes(UObject InOther) {}
	public void CopyAttribute(UObject InOther,string AttributeToCopy,string NewAttributeName) {}
	public void CreateInteger32Attribute(string AttributeName,int DefaultValue,bool bAllowsInterpolation,bool bOverrideParent/*=true*/) {}
	public void CreateInteger64Attribute(string AttributeName,long DefaultValue,bool bAllowsInterpolation,bool bOverrideParent/*=true*/) {}
	public void CreateFloatAttribute(string AttributeName,float DefaultValue,bool bAllowsInterpolation,bool bOverrideParent/*=true*/) {}
	public void CreateDoubleAttribute(string AttributeName,double DefaultValue,bool bAllowsInterpolation,bool bOverrideParent/*=true*/) {}
	public void CreateVectorAttribute(string AttributeName,FVector DefaultValue,bool bAllowsInterpolation,bool bOverrideParent/*=true*/) {}
	public void CreateVector4Attribute(string AttributeName,FVector4 DefaultValue,bool bAllowsInterpolation,bool bOverrideParent/*=true*/) {}
	public void CreateVector2Attribute(string AttributeName,FVector2D DefaultValue,bool bAllowsInterpolation,bool bOverrideParent/*=true*/) {}
	public void CreateRotatorAttribute(string AttributeName,FRotator DefaultValue,bool bAllowsInterpolation,bool bOverrideParent/*=true*/) {}
	public void CreateQuatAttribute(string AttributeName,FQuat DefaultValue,bool bAllowsInterpolation,bool bOverrideParent/*=true*/) {}
	public void CreateTransformAttribute(string AttributeName,FTransform DefaultValue,bool bAllowsInterpolation,bool bOverrideParent/*=true*/) {}
	public void CreateStringAttribute(string AttributeName,string DefaultValue,bool bAllowsInterpolation,bool bOverrideParent/*=true*/) {}
	public void CreateBoolAttribute(string AttributeName,bool DefaultValue,bool bAllowsInterpolation,bool bOverrideParent/*=true*/) {}
	public bool HasAttribute(string AttributeName) { return default; }
	public bool HasCommonAttributes(UObject InMetadata) { return default; }
	public void GetAttributes(TArray<string> AttributeNames,TArray<EPCGMetadataTypes> AttributeTypes) {}
	public void DeleteAttribute(string AttributeName) {}
	public bool CopyExistingAttribute(string AttributeToCopy,string NewAttributeName,bool bKeepParent/*=true*/) { return default; }
	public bool RenameAttribute(string AttributeToRename,string NewAttributeName) { return default; }
	public void ClearAttribute(string AttributeToClear) {}
	public long AddEntry(long ParentEntryKey/*=-1*/) { return default; }
	public void MergeAttributesByKey(long KeyA,UObject MetadataA,long KeyB,UObject MetadataB,long TargetKey,EPCGMetadataOp Op,long OutKey) {}
	public void ResetWeightedAttributesByKey(long TargetKey,long OutKey) {}
	public void AccumulateWeightedAttributesByKey(long Key,UObject Metadata,float Weight,bool bSetNonInterpolableAttributes,long TargetKey,long OutKey) {}
	public void SetAttributesByKey(long Key,UObject InMetadata,long TargetKey,long OutKey) {}
	public void MergePointAttributes(FPCGPoint PointA,UObject MetadataA,FPCGPoint PointB,UObject MetadataB,FPCGPoint TargetPoint,EPCGMetadataOp Op) {}
	public void SetPointAttributes(FPCGPoint Point,UObject Metadata,FPCGPoint OutPoint) {}
	public void ResetPointWeightedAttributes(FPCGPoint OutPoint) {}
	public void AccumulatePointWeightedAttributes(FPCGPoint InPoint,UObject InMetadata,float Weight,bool bSetNonInterpolableAttributes,FPCGPoint OutPoint) {}
	public UPCGMetadata Parent;
	public TSet<TWeakObjectPtr<UPCGMetadata>> OtherParents;
}
