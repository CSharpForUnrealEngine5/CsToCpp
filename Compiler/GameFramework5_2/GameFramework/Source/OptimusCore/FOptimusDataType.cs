namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OptimusDataType.h")]
public partial struct FOptimusDataType {
	public string TypeName;
	public FText DisplayName;
	public FShaderValueTypeHandle ShaderValueType;
	public int ShaderValueSize;
	public string TypeCategory;
	public TWeakObjectPtr<UObject> TypeObject;
	public bool bHasCustomPinColor;
	public FLinearColor CustomPinColor;
	public EOptimusDataTypeUsageFlags UsageFlags;
	public EOptimusDataTypeFlags TypeFlags;
}
