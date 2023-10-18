namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A reference object for an Optimus data type to use in UObjects and other UStruct-like things</summary>
[CppInclude("OptimusDataType.h")]
public partial struct FOptimusDataTypeRef {
	public FName TypeName;
	public TWeakObjectPtr<UObject> TypeObject;
}
