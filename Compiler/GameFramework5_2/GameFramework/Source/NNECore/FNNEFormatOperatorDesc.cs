#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NNECoreRuntimeFormat.h")]
public partial struct FNNEFormatOperatorDesc {
	public string TypeName;
	public TArray<uint> InTensors;
	public TArray<uint> OutTensors;
	public TArray<FNNEFormatAttributeDesc> Attributes;
}
