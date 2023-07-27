#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Metadata/PCGMetadata.h")]
public partial class UPCGMetadata : UObject {
// PCGMetadata
	public  void Initialize(UPCGMetadata InParent) {}
	public  void InitializeWithAttributeFilter(UPCGMetadata InParent,TSet<string> InFilteredAttributes,EPCGMetadataFilterMode InFilterMode/*=EPCGMetadataFilterMode.ExcludeAttributes*/) {}
	public  void InitializeAsCopy(UPCGMetadata InMetadataToCopy) {}
	public  void InitializeAsCopyWithAttributeFilter(UPCGMetadata InMetadataToCopy,TSet<string> InFilteredAttributes,EPCGMetadataFilterMode InFilterMode/*=EPCGMetadataFilterMode.ExcludeAttributes*/) {}
	public  void AddAttributes(UPCGMetadata InOther) {}
	public  void AddAttributesFiltered(UPCGMetadata InOther,TSet<string> InFilteredAttributes,EPCGMetadataFilterMode InFilterMode/*=EPCGMetadataFilterMode.ExcludeAttributes*/) {}
	public  void AddAttribute(UPCGMetadata InOther,string AttributeName) {}
	public  void CopyAttributes(UPCGMetadata InOther) {}
	public  void CopyAttribute(UPCGMetadata InOther,string AttributeToCopy,string NewAttributeName) {}
	public  void CreateInteger32Attribute(string AttributeName,int DefaultValue,bool bAllowsInterpolation,bool bOverrideParent/*=true*/) {}
	public  void CreateInteger64Attribute(string AttributeName,long DefaultValue,bool bAllowsInterpolation,bool bOverrideParent/*=true*/) {}
	public  void CreateFloatAttribute(string AttributeName,float DefaultValue,bool bAllowsInterpolation,bool bOverrideParent/*=true*/) {}
	public  void CreateDoubleAttribute(string AttributeName,double DefaultValue,bool bAllowsInterpolation,bool bOverrideParent/*=true*/) {}
	public  void CreateVectorAttribute(string AttributeName,FVector DefaultValue,bool bAllowsInterpolation,bool bOverrideParent/*=true*/) {}
	public  void CreateVector4Attribute(string AttributeName,FVector4 DefaultValue,bool bAllowsInterpolation,bool bOverrideParent/*=true*/) {}
	public  void CreateVector2Attribute(string AttributeName,FVector2D DefaultValue,bool bAllowsInterpolation,bool bOverrideParent/*=true*/) {}
	public  void CreateRotatorAttribute(string AttributeName,FRotator DefaultValue,bool bAllowsInterpolation,bool bOverrideParent/*=true*/) {}
	public  void CreateQuatAttribute(string AttributeName,FQuat DefaultValue,bool bAllowsInterpolation,bool bOverrideParent/*=true*/) {}
	public  void CreateTransformAttribute(string AttributeName,FTransform DefaultValue,bool bAllowsInterpolation,bool bOverrideParent/*=true*/) {}
	public  void CreateStringAttribute(string AttributeName,string DefaultValue,bool bAllowsInterpolation,bool bOverrideParent/*=true*/) {}
	public  void CreateBoolAttribute(string AttributeName,bool DefaultValue,bool bAllowsInterpolation,bool bOverrideParent/*=true*/) {}
	public  bool HasAttribute(string AttributeName) { return default; }
	public  bool HasCommonAttributes(UPCGMetadata InMetadata) { return default; }
	public  void GetAttributes(TArray<string> AttributeNames,TArray<EPCGMetadataTypes> AttributeTypes) {}
	public  void DeleteAttribute(string AttributeName) {}
	public  bool CopyExistingAttribute(string AttributeToCopy,string NewAttributeName,bool bKeepParent/*=true*/) { return default; }
	public  bool RenameAttribute(string AttributeToRename,string NewAttributeName) { return default; }
	public  void ClearAttribute(string AttributeToClear) {}
	public  long AddEntry(long ParentEntryKey/*=-1*/) { return default; }
	public  void MergeAttributesByKey(long KeyA,UPCGMetadata MetadataA,long KeyB,UPCGMetadata MetadataB,long TargetKey,EPCGMetadataOp Op,long OutKey) {}
	public  void ResetWeightedAttributesByKey(long TargetKey,long OutKey) {}
	public  void AccumulateWeightedAttributesByKey(long Key,UPCGMetadata Metadata,float Weight,bool bSetNonInterpolableAttributes,long TargetKey,long OutKey) {}
	public  void SetAttributesByKey(long Key,UPCGMetadata InMetadata,long TargetKey,long OutKey) {}
	public  void MergePointAttributes(FPCGPoint PointA,UPCGMetadata MetadataA,FPCGPoint PointB,UPCGMetadata MetadataB,FPCGPoint TargetPoint,EPCGMetadataOp Op) {}
	public  void SetPointAttributes(FPCGPoint Point,UPCGMetadata Metadata,FPCGPoint OutPoint) {}
	public  void ResetPointWeightedAttributes(FPCGPoint OutPoint) {}
	public  void AccumulatePointWeightedAttributes(FPCGPoint InPoint,UPCGMetadata InMetadata,float Weight,bool bSetNonInterpolableAttributes,FPCGPoint OutPoint) {}
	public UPCGMetadata Parent;
	public TSet<TWeakObjectPtr<UPCGMetadata>> OtherParents;
}
