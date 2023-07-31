#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>NNE Runtime format</summary>
[CppInclude("NNECoreRuntimeFormat.h")]
public partial struct FNNERuntimeFormat {
	public TArray<FNNEFormatTensorDesc> Tensors;
	public TArray<FNNEFormatOperatorDesc> Operators;
	public TArray<byte> TensorData;
}
