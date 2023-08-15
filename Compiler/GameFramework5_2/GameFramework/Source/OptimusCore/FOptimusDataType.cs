namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OptimusDataType.h")]
public partial struct FOptimusDataType {
	public FName TypeName;
	public FText DisplayName;
	public FShaderValueTypeHandle ShaderValueType;
	public int ShaderValueSize;
	public FName TypeCategory;
	public TWeakObjectPtr<UObject> TypeObject;
	public bool bHasCustomPinColor;
	public FLinearColor CustomPinColor;
	public EOptimusDataTypeUsageFlags UsageFlags;
	public EOptimusDataTypeFlags TypeFlags;
}
