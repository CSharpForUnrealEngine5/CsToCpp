namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Metadata/PCGMetadata.h")]
public partial class UPCGMetadata : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Initializes the metadata from a parent metadata, if any (can be null). Copies attributes and values.</summary>
	public void Initialize(UPCGMetadata InParent) {}
	///<summary>Initializes the metadata from a parent metadata. Copies attributes and values.</summary>
	public void InitializeWithAttributeFilter(UPCGMetadata InParent,TSet<FName> InFilteredAttributes,EPCGMetadataFilterMode InFilterMode/*=EPCGMetadataFilterMode.ExcludeAttributes*/) {}
	///<summary>Initializes the metadata from a parent metadata by copying all attributes to it.</summary>
	public void InitializeAsCopy(UPCGMetadata InMetadataToCopy) {}
	///<summary>Initializes the metadata from a parent metadata by copy filtered attributes only to it</summary>
	public void InitializeAsCopyWithAttributeFilter(UPCGMetadata InMetadataToCopy,TSet<FName> InFilteredAttributes,EPCGMetadataFilterMode InFilterMode/*=EPCGMetadataFilterMode.ExcludeAttributes*/) {}
	///<summary>Creates missing attributes from another metadata if they are not currently present - note that this does not copy values</summary>
	public void AddAttributes(UPCGMetadata InOther) {}
	///<summary>Creates missing attributes from another metadata if they are not currently present - note that this does not copy values.</summary>
	public void AddAttributesFiltered(UPCGMetadata InOther,TSet<FName> InFilteredAttributes,EPCGMetadataFilterMode InFilterMode/*=EPCGMetadataFilterMode.ExcludeAttributes*/) {}
	///<summary>Creates missing attribute from another metadata if it is not currently present - note that this does not copy values</summary>
	public void AddAttribute(UPCGMetadata InOther,FName AttributeName) {}
	///<summary>Copies attributes from another metadata, including entries &amp; values. Warning: this is intended when dealing with the same data set</summary>
	public void CopyAttributes(UPCGMetadata InOther) {}
	///<summary>Copies an attribute from another metadata, including entries &amp; values. Warning: this is intended when dealing with the same data set</summary>
	public void CopyAttribute(UPCGMetadata InOther,FName AttributeToCopy,FName NewAttributeName) {}
	///<summary>Create new streams</summary>
	public void CreateInteger32Attribute(FName AttributeName,int DefaultValue,bool bAllowsInterpolation,bool bOverrideParent/*=true*/) {}
	///<summary>CreateInteger64Attribute</summary>
	public void CreateInteger64Attribute(FName AttributeName,long DefaultValue,bool bAllowsInterpolation,bool bOverrideParent/*=true*/) {}
	///<summary>CreateFloatAttribute</summary>
	public void CreateFloatAttribute(FName AttributeName,float DefaultValue,bool bAllowsInterpolation,bool bOverrideParent/*=true*/) {}
	///<summary>CreateDoubleAttribute</summary>
	public void CreateDoubleAttribute(FName AttributeName,double DefaultValue,bool bAllowsInterpolation,bool bOverrideParent/*=true*/) {}
	///<summary>CreateVectorAttribute</summary>
	public void CreateVectorAttribute(FName AttributeName,FVector DefaultValue,bool bAllowsInterpolation,bool bOverrideParent/*=true*/) {}
	///<summary>CreateVector4Attribute</summary>
	public void CreateVector4Attribute(FName AttributeName,FVector4 DefaultValue,bool bAllowsInterpolation,bool bOverrideParent/*=true*/) {}
	///<summary>CreateVector2Attribute</summary>
	public void CreateVector2Attribute(FName AttributeName,FVector2D DefaultValue,bool bAllowsInterpolation,bool bOverrideParent/*=true*/) {}
	///<summary>CreateRotatorAttribute</summary>
	public void CreateRotatorAttribute(FName AttributeName,FRotator DefaultValue,bool bAllowsInterpolation,bool bOverrideParent/*=true*/) {}
	///<summary>CreateQuatAttribute</summary>
	public void CreateQuatAttribute(FName AttributeName,FQuat DefaultValue,bool bAllowsInterpolation,bool bOverrideParent/*=true*/) {}
	///<summary>CreateTransformAttribute</summary>
	public void CreateTransformAttribute(FName AttributeName,FTransform DefaultValue,bool bAllowsInterpolation,bool bOverrideParent/*=true*/) {}
	///<summary>CreateStringAttribute</summary>
	public void CreateStringAttribute(FName AttributeName,string DefaultValue,bool bAllowsInterpolation,bool bOverrideParent/*=true*/) {}
	///<summary>CreateBoolAttribute</summary>
	public void CreateBoolAttribute(FName AttributeName,bool DefaultValue,bool bAllowsInterpolation,bool bOverrideParent/*=true*/) {}
	///<summary>HasAttribute</summary>
	public bool HasAttribute(FName AttributeName) { return default; }
	///<summary>HasCommonAttributes</summary>
	public bool HasCommonAttributes(UPCGMetadata InMetadata) { return default; }
	///<summary>GetAttributes</summary>
	public void GetAttributes(TArray<FName> AttributeNames,TArray<EPCGMetadataTypes> AttributeTypes) {}
	///<summary>Delete/Hide attribute // Due to stream inheriting, we might want to consider &quot;hiding&quot; parent stream and deleting local streams only</summary>
	public void DeleteAttribute(FName AttributeName) {}
	///<summary>Copy attribute</summary>
	public bool CopyExistingAttribute(FName AttributeToCopy,FName NewAttributeName,bool bKeepParent/*=true*/) { return default; }
	///<summary>Rename attribute</summary>
	public bool RenameAttribute(FName AttributeToRename,FName NewAttributeName) { return default; }
	///<summary>Clear/Reinit attribute</summary>
	public void ClearAttribute(FName AttributeToClear) {}
	///<summary>Adds a unique entry key to the metadata</summary>
	public long AddEntry(long ParentEntryKey/*=-1*/) { return default; }
	///<summary>Blueprint-friend versions</summary>
	public void MergeAttributesByKey(long KeyA,UPCGMetadata MetadataA,long KeyB,UPCGMetadata MetadataB,long TargetKey,EPCGMetadataOp Op,long OutKey) {}
	///<summary>ResetWeightedAttributesByKey</summary>
	public void ResetWeightedAttributesByKey(long TargetKey,long OutKey) {}
	///<summary>AccumulateWeightedAttributesByKey</summary>
	public void AccumulateWeightedAttributesByKey(long Key,UPCGMetadata Metadata,float Weight,bool bSetNonInterpolableAttributes,long TargetKey,long OutKey) {}
	///<summary>SetAttributesByKey</summary>
	public void SetAttributesByKey(long Key,UPCGMetadata InMetadata,long TargetKey,long OutKey) {}
	///<summary>MergePointAttributes</summary>
	public void MergePointAttributes(FPCGPoint PointA,UPCGMetadata MetadataA,FPCGPoint PointB,UPCGMetadata MetadataB,FPCGPoint TargetPoint,EPCGMetadataOp Op) {}
	///<summary>SetPointAttributes</summary>
	public void SetPointAttributes(FPCGPoint Point,UPCGMetadata Metadata,FPCGPoint OutPoint) {}
	///<summary>ResetPointWeightedAttributes</summary>
	public void ResetPointWeightedAttributes(FPCGPoint OutPoint) {}
	///<summary>AccumulatePointWeightedAttributes</summary>
	public void AccumulatePointWeightedAttributes(FPCGPoint InPoint,UPCGMetadata InMetadata,float Weight,bool bSetNonInterpolableAttributes,FPCGPoint OutPoint) {}
	///<summary>Parent</summary>
	public UPCGMetadata Parent;
	///<summary>Set of parents kept for streams relationship and GC collection</summary>
	public TSet<TWeakObjectPtr<UPCGMetadata>> OtherParents;
}
