#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct to be re-used when you need to show constants types for a metadata type</summary>
[CppInclude("Metadata/PCGMetadataTypesConstantStruct.h")]
public partial struct FPCGMetadataTypesConstantStruct {
	public EPCGMetadataTypes Type;
	public EPCGMetadataTypesConstantStructStringMode StringMode;
	public float FloatValue;
	public int Int32Value;
	public double DoubleValue;
	public long IntValue;
	public FVector2D Vector2Value;
	public FVector VectorValue;
	public FVector4 Vector4Value;
	public FQuat QuatValue;
	public FTransform TransformValue;
	public string StringValue;
	public bool BoolValue;
	public FRotator RotatorValue;
	public string NameValue;
	public FSoftClassPath SoftClassPathValue;
	public FSoftObjectPath SoftObjectPathValue;
	public bool bAllowsTypeChange;
}
