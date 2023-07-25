#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NNECoreRuntimeFormat.h")]
///<summary>NNE Runtime format</summary>
public partial struct FNNERuntimeFormat {
// NNERuntimeFormat
	public TArray<FNNEFormatTensorDesc> Tensors;
	public TArray<FNNEFormatOperatorDesc> Operators;
	public TArray<byte> TensorData;
}
