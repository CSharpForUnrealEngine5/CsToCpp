namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NNECoreRuntimeFormat.h")]
public partial struct FNNEFormatOperatorDesc {
	public string TypeName;
	public TArray<uint> InTensors;
	public TArray<uint> OutTensors;
	public TArray<FNNEFormatAttributeDesc> Attributes;
}
