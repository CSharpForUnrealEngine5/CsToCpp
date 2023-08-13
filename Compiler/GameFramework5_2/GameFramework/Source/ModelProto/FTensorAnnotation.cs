namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Level 3 - FTensorAnnotation</summary>
[CppInclude("ModelProto.h")]
public partial struct FTensorAnnotation {
	public string TensorName;
	public TArray<FStringStringEntryProto> QuantParameterTensorNames;
}
