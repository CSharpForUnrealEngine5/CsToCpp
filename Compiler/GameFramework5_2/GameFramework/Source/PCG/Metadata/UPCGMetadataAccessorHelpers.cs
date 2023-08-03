#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Metadata/PCGMetadataAccessor.h")]
public partial class UPCGMetadataAccessorHelpers : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Id-based metadata functions</summary>
	public static int GetInteger32AttributeByMetadataKey(long Key,UPCGMetadata Metadata,string AttributeName) { return default; }
	///<summary>SetInteger32AttributeByMetadataKey</summary>
	public static void SetInteger32AttributeByMetadataKey(long Key,UPCGMetadata Metadata,string AttributeName,int Value) {}
	///<summary>GetInteger64AttributeByMetadataKey</summary>
	public static long GetInteger64AttributeByMetadataKey(long Key,UPCGMetadata Metadata,string AttributeName) { return default; }
	///<summary>SetInteger64AttributeByMetadataKey</summary>
	public static void SetInteger64AttributeByMetadataKey(long Key,UPCGMetadata Metadata,string AttributeName,long Value) {}
	///<summary>GetFloatAttributeByMetadataKey</summary>
	public static float GetFloatAttributeByMetadataKey(long Key,UPCGMetadata Metadata,string AttributeName) { return default; }
	///<summary>SetFloatAttributeByMetadataKey</summary>
	public static void SetFloatAttributeByMetadataKey(long Key,UPCGMetadata Metadata,string AttributeName,float Value) {}
	///<summary>GetDoubleAttributeByMetadataKey</summary>
	public static double GetDoubleAttributeByMetadataKey(long Key,UPCGMetadata Metadata,string AttributeName) { return default; }
	///<summary>SetDoubleAttributeByMetadataKey</summary>
	public static void SetDoubleAttributeByMetadataKey(long Key,UPCGMetadata Metadata,string AttributeName,double Value) {}
	///<summary>GetVectorAttributeByMetadataKey</summary>
	public static FVector GetVectorAttributeByMetadataKey(long Key,UPCGMetadata Metadata,string AttributeName) { return default; }
	///<summary>SetVectorAttributeByMetadataKey</summary>
	public static void SetVectorAttributeByMetadataKey(long Key,UPCGMetadata Metadata,string AttributeName,FVector Value) {}
	///<summary>GetVector4AttributeByMetadataKey</summary>
	public static FVector4 GetVector4AttributeByMetadataKey(long Key,UPCGMetadata Metadata,string AttributeName) { return default; }
	///<summary>SetVector4AttributeByMetadataKey</summary>
	public static void SetVector4AttributeByMetadataKey(long Key,UPCGMetadata Metadata,string AttributeName,FVector4 Value) {}
	///<summary>GetVector2AttributeByMetadataKey</summary>
	public static FVector2D GetVector2AttributeByMetadataKey(long Key,UPCGMetadata Metadata,string AttributeName) { return default; }
	///<summary>SetVector2AttributeByMetadataKey</summary>
	public static void SetVector2AttributeByMetadataKey(long Key,UPCGMetadata Metadata,string AttributeName,FVector2D Value) {}
	///<summary>GetRotatorAttributeByMetadataKey</summary>
	public static FRotator GetRotatorAttributeByMetadataKey(long Key,UPCGMetadata Metadata,string AttributeName) { return default; }
	///<summary>SetRotatorAttributeByMetadataKey</summary>
	public static void SetRotatorAttributeByMetadataKey(long Key,UPCGMetadata Metadata,string AttributeName,FRotator Value) {}
	///<summary>GetQuatAttributeByMetadataKey</summary>
	public static FQuat GetQuatAttributeByMetadataKey(long Key,UPCGMetadata Metadata,string AttributeName) { return default; }
	///<summary>SetQuatAttributeByMetadataKey</summary>
	public static void SetQuatAttributeByMetadataKey(long Key,UPCGMetadata Metadata,string AttributeName,FQuat Value) {}
	///<summary>GetTransformAttributeByMetadataKey</summary>
	public static FTransform GetTransformAttributeByMetadataKey(long Key,UPCGMetadata Metadata,string AttributeName) { return default; }
	///<summary>SetTransformAttributeByMetadataKey</summary>
	public static void SetTransformAttributeByMetadataKey(long Key,UPCGMetadata Metadata,string AttributeName,FTransform Value) {}
	///<summary>GetStringAttributeByMetadataKey</summary>
	public static string GetStringAttributeByMetadataKey(long Key,UPCGMetadata Metadata,string AttributeName) { return default; }
	///<summary>SetStringAttributeByMetadataKey</summary>
	public static void SetStringAttributeByMetadataKey(long Key,UPCGMetadata Metadata,string AttributeName,string Value) {}
	///<summary>GetBoolAttributeByMetadataKey</summary>
	public static bool GetBoolAttributeByMetadataKey(long Key,UPCGMetadata Metadata,string AttributeName) { return default; }
	///<summary>SetBoolAttributeByMetadataKey</summary>
	public static void SetBoolAttributeByMetadataKey(long Key,UPCGMetadata Metadata,string AttributeName,bool Value) {}
	///<summary>SetAttributeFromPropertyByMetadataKey</summary>
	public static bool SetAttributeFromPropertyByMetadataKey(long Key,UPCGMetadata Metadata,string AttributeName,UObject Object,string PropertyName) { return default; }
	///<summary>HasAttributeSetByMetadataKey</summary>
	public static bool HasAttributeSetByMetadataKey(long Key,UPCGMetadata Metadata,string AttributeName) { return default; }
	///<summary>Point functions</summary>
	public static void CopyPoint(FPCGPoint InPoint,FPCGPoint OutPoint,bool bCopyMetadata/*=true*/,UPCGMetadata InMetadata/*=nullptr*/,UPCGMetadata OutMetadata/*=nullptr*/) {}
	///<summary>Assigns a metadata entry key and will copy attribute values if from an unrelated metadata. Note: a null ParentMetadata assumes this is the same as Metadata</summary>
	public static void InitializeMetadata(FPCGPoint Point,UPCGMetadata Metadata,FPCGPoint ParentPoint,UPCGMetadata ParentMetadata/*=nullptr*/) {}
	///<summary>GetInteger32Attribute</summary>
	public static int GetInteger32Attribute(FPCGPoint Point,UPCGMetadata Metadata,string AttributeName) { return default; }
	///<summary>SetInteger32Attribute</summary>
	public static void SetInteger32Attribute(FPCGPoint Point,UPCGMetadata Metadata,string AttributeName,int Value) {}
	///<summary>GetInteger64Attribute</summary>
	public static long GetInteger64Attribute(FPCGPoint Point,UPCGMetadata Metadata,string AttributeName) { return default; }
	///<summary>SetInteger64Attribute</summary>
	public static void SetInteger64Attribute(FPCGPoint Point,UPCGMetadata Metadata,string AttributeName,long Value) {}
	///<summary>GetFloatAttribute</summary>
	public static float GetFloatAttribute(FPCGPoint Point,UPCGMetadata Metadata,string AttributeName) { return default; }
	///<summary>SetFloatAttribute</summary>
	public static void SetFloatAttribute(FPCGPoint Point,UPCGMetadata Metadata,string AttributeName,float Value) {}
	///<summary>GetDoubleAttribute</summary>
	public static double GetDoubleAttribute(FPCGPoint Point,UPCGMetadata Metadata,string AttributeName) { return default; }
	///<summary>SetDoubleAttribute</summary>
	public static void SetDoubleAttribute(FPCGPoint Point,UPCGMetadata Metadata,string AttributeName,double Value) {}
	///<summary>GetVectorAttribute</summary>
	public static FVector GetVectorAttribute(FPCGPoint Point,UPCGMetadata Metadata,string AttributeName) { return default; }
	///<summary>SetVectorAttribute</summary>
	public static void SetVectorAttribute(FPCGPoint Point,UPCGMetadata Metadata,string AttributeName,FVector Value) {}
	///<summary>GetVector4Attribute</summary>
	public static FVector4 GetVector4Attribute(FPCGPoint Point,UPCGMetadata Metadata,string AttributeName) { return default; }
	///<summary>SetVector4Attribute</summary>
	public static void SetVector4Attribute(FPCGPoint Point,UPCGMetadata Metadata,string AttributeName,FVector4 Value) {}
	///<summary>GetVector2Attribute</summary>
	public static FVector2D GetVector2Attribute(FPCGPoint Point,UPCGMetadata Metadata,string AttributeName) { return default; }
	///<summary>SetVector2Attribute</summary>
	public static void SetVector2Attribute(FPCGPoint Point,UPCGMetadata Metadata,string AttributeName,FVector2D Value) {}
	///<summary>GetRotatorAttribute</summary>
	public static FRotator GetRotatorAttribute(FPCGPoint Point,UPCGMetadata Metadata,string AttributeName) { return default; }
	///<summary>SetRotatorAttribute</summary>
	public static void SetRotatorAttribute(FPCGPoint Point,UPCGMetadata Metadata,string AttributeName,FRotator Value) {}
	///<summary>GetQuatAttribute</summary>
	public static FQuat GetQuatAttribute(FPCGPoint Point,UPCGMetadata Metadata,string AttributeName) { return default; }
	///<summary>SetQuatAttribute</summary>
	public static void SetQuatAttribute(FPCGPoint Point,UPCGMetadata Metadata,string AttributeName,FQuat Value) {}
	///<summary>GetTransformAttribute</summary>
	public static FTransform GetTransformAttribute(FPCGPoint Point,UPCGMetadata Metadata,string AttributeName) { return default; }
	///<summary>SetTransformAttribute</summary>
	public static void SetTransformAttribute(FPCGPoint Point,UPCGMetadata Metadata,string AttributeName,FTransform Value) {}
	///<summary>GetStringAttribute</summary>
	public static string GetStringAttribute(FPCGPoint Point,UPCGMetadata Metadata,string AttributeName) { return default; }
	///<summary>SetStringAttribute</summary>
	public static void SetStringAttribute(FPCGPoint Point,UPCGMetadata Metadata,string AttributeName,string Value) {}
	///<summary>GetBoolAttribute</summary>
	public static bool GetBoolAttribute(FPCGPoint Point,UPCGMetadata Metadata,string AttributeName) { return default; }
	///<summary>SetBoolAttribute</summary>
	public static void SetBoolAttribute(FPCGPoint Point,UPCGMetadata Metadata,string AttributeName,bool Value) {}
	///<summary>HasAttributeSet</summary>
	public static bool HasAttributeSet(FPCGPoint Point,UPCGMetadata Metadata,string AttributeName) { return default; }
}
