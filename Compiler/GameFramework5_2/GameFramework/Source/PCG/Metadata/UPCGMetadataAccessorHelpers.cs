#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Metadata/PCGMetadataAccessor.h")]
public partial class UPCGMetadataAccessorHelpers : UBlueprintFunctionLibrary {
// PCGMetadataAccessorHelpers
	public static int GetInteger32AttributeByMetadataKey(long Key,UPCGMetadata Metadata,string AttributeName) { return default; }
	public static void SetInteger32AttributeByMetadataKey(long Key,UPCGMetadata Metadata,string AttributeName,int Value) {}
	public static long GetInteger64AttributeByMetadataKey(long Key,UPCGMetadata Metadata,string AttributeName) { return default; }
	public static void SetInteger64AttributeByMetadataKey(long Key,UPCGMetadata Metadata,string AttributeName,long Value) {}
	public static float GetFloatAttributeByMetadataKey(long Key,UPCGMetadata Metadata,string AttributeName) { return default; }
	public static void SetFloatAttributeByMetadataKey(long Key,UPCGMetadata Metadata,string AttributeName,float Value) {}
	public static double GetDoubleAttributeByMetadataKey(long Key,UPCGMetadata Metadata,string AttributeName) { return default; }
	public static void SetDoubleAttributeByMetadataKey(long Key,UPCGMetadata Metadata,string AttributeName,double Value) {}
	public static FVector GetVectorAttributeByMetadataKey(long Key,UPCGMetadata Metadata,string AttributeName) { return default; }
	public static void SetVectorAttributeByMetadataKey(long Key,UPCGMetadata Metadata,string AttributeName,FVector Value) {}
	public static FVector4 GetVector4AttributeByMetadataKey(long Key,UPCGMetadata Metadata,string AttributeName) { return default; }
	public static void SetVector4AttributeByMetadataKey(long Key,UPCGMetadata Metadata,string AttributeName,FVector4 Value) {}
	public static FVector2D GetVector2AttributeByMetadataKey(long Key,UPCGMetadata Metadata,string AttributeName) { return default; }
	public static void SetVector2AttributeByMetadataKey(long Key,UPCGMetadata Metadata,string AttributeName,FVector2D Value) {}
	public static FRotator GetRotatorAttributeByMetadataKey(long Key,UPCGMetadata Metadata,string AttributeName) { return default; }
	public static void SetRotatorAttributeByMetadataKey(long Key,UPCGMetadata Metadata,string AttributeName,FRotator Value) {}
	public static FQuat GetQuatAttributeByMetadataKey(long Key,UPCGMetadata Metadata,string AttributeName) { return default; }
	public static void SetQuatAttributeByMetadataKey(long Key,UPCGMetadata Metadata,string AttributeName,FQuat Value) {}
	public static FTransform GetTransformAttributeByMetadataKey(long Key,UPCGMetadata Metadata,string AttributeName) { return default; }
	public static void SetTransformAttributeByMetadataKey(long Key,UPCGMetadata Metadata,string AttributeName,FTransform Value) {}
	public static string GetStringAttributeByMetadataKey(long Key,UPCGMetadata Metadata,string AttributeName) { return default; }
	public static void SetStringAttributeByMetadataKey(long Key,UPCGMetadata Metadata,string AttributeName,string Value) {}
	public static bool GetBoolAttributeByMetadataKey(long Key,UPCGMetadata Metadata,string AttributeName) { return default; }
	public static void SetBoolAttributeByMetadataKey(long Key,UPCGMetadata Metadata,string AttributeName,bool Value) {}
	public static bool SetAttributeFromPropertyByMetadataKey(long Key,UPCGMetadata Metadata,string AttributeName,UObject Object,string PropertyName) { return default; }
	public static bool HasAttributeSetByMetadataKey(long Key,UPCGMetadata Metadata,string AttributeName) { return default; }
	public static void CopyPoint(FPCGPoint InPoint,FPCGPoint OutPoint,bool bCopyMetadata/*=true*/,UPCGMetadata InMetadata/*=nullptr*/,UPCGMetadata OutMetadata/*=nullptr*/) {}
	public static void InitializeMetadata(FPCGPoint Point,UPCGMetadata Metadata,FPCGPoint ParentPoint,UPCGMetadata ParentMetadata/*=nullptr*/) {}
	public static int GetInteger32Attribute(FPCGPoint Point,UPCGMetadata Metadata,string AttributeName) { return default; }
	public static void SetInteger32Attribute(FPCGPoint Point,UPCGMetadata Metadata,string AttributeName,int Value) {}
	public static long GetInteger64Attribute(FPCGPoint Point,UPCGMetadata Metadata,string AttributeName) { return default; }
	public static void SetInteger64Attribute(FPCGPoint Point,UPCGMetadata Metadata,string AttributeName,long Value) {}
	public static float GetFloatAttribute(FPCGPoint Point,UPCGMetadata Metadata,string AttributeName) { return default; }
	public static void SetFloatAttribute(FPCGPoint Point,UPCGMetadata Metadata,string AttributeName,float Value) {}
	public static double GetDoubleAttribute(FPCGPoint Point,UPCGMetadata Metadata,string AttributeName) { return default; }
	public static void SetDoubleAttribute(FPCGPoint Point,UPCGMetadata Metadata,string AttributeName,double Value) {}
	public static FVector GetVectorAttribute(FPCGPoint Point,UPCGMetadata Metadata,string AttributeName) { return default; }
	public static void SetVectorAttribute(FPCGPoint Point,UPCGMetadata Metadata,string AttributeName,FVector Value) {}
	public static FVector4 GetVector4Attribute(FPCGPoint Point,UPCGMetadata Metadata,string AttributeName) { return default; }
	public static void SetVector4Attribute(FPCGPoint Point,UPCGMetadata Metadata,string AttributeName,FVector4 Value) {}
	public static FVector2D GetVector2Attribute(FPCGPoint Point,UPCGMetadata Metadata,string AttributeName) { return default; }
	public static void SetVector2Attribute(FPCGPoint Point,UPCGMetadata Metadata,string AttributeName,FVector2D Value) {}
	public static FRotator GetRotatorAttribute(FPCGPoint Point,UPCGMetadata Metadata,string AttributeName) { return default; }
	public static void SetRotatorAttribute(FPCGPoint Point,UPCGMetadata Metadata,string AttributeName,FRotator Value) {}
	public static FQuat GetQuatAttribute(FPCGPoint Point,UPCGMetadata Metadata,string AttributeName) { return default; }
	public static void SetQuatAttribute(FPCGPoint Point,UPCGMetadata Metadata,string AttributeName,FQuat Value) {}
	public static FTransform GetTransformAttribute(FPCGPoint Point,UPCGMetadata Metadata,string AttributeName) { return default; }
	public static void SetTransformAttribute(FPCGPoint Point,UPCGMetadata Metadata,string AttributeName,FTransform Value) {}
	public static string GetStringAttribute(FPCGPoint Point,UPCGMetadata Metadata,string AttributeName) { return default; }
	public static void SetStringAttribute(FPCGPoint Point,UPCGMetadata Metadata,string AttributeName,string Value) {}
	public static bool GetBoolAttribute(FPCGPoint Point,UPCGMetadata Metadata,string AttributeName) { return default; }
	public static void SetBoolAttribute(FPCGPoint Point,UPCGMetadata Metadata,string AttributeName,bool Value) {}
	public static bool HasAttributeSet(FPCGPoint Point,UPCGMetadata Metadata,string AttributeName) { return default; }
}
