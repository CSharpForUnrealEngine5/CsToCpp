#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NNECoreRuntimeFormat.h")]
public partial struct FNNEFormatOperatorDesc {
// NNEFormatOperatorDesc
	public string TypeName;
	public TArray<uint> InTensors;
	public TArray<uint> OutTensors;
	public TArray<FNNEFormatAttributeDesc> Attributes;
}
