#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OptimusDataType.h")]
public partial struct FOptimusDataType {
// OptimusDataType
	public string TypeName;
	public string DisplayName;
	public FShaderValueTypeHandle ShaderValueType;
	public int ShaderValueSize;
	public string TypeCategory;
	public TWeakObjectPtr<UObject> TypeObject;
	public bool bHasCustomPinColor;
	public FLinearColor CustomPinColor;
	public EOptimusDataTypeUsageFlags UsageFlags;
	public EOptimusDataTypeFlags TypeFlags;
}
