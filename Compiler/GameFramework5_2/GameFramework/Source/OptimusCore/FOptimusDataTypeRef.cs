#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OptimusDataType.h")]
///<summary>A reference object for an Optimus data type to use in UObjects and other UStruct-like things</summary>
public partial struct FOptimusDataTypeRef {
// OptimusDataTypeRef
	public string TypeName;
	public TWeakObjectPtr<UObject> TypeObject;
}
