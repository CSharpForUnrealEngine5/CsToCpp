namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>NNE Runtime format</summary>
[CppInclude("NNECoreRuntimeFormat.h")]
public partial struct FNNERuntimeFormat {
	public TArray<FNNEFormatTensorDesc> Tensors;
	public TArray<FNNEFormatOperatorDesc> Operators;
	public TArray<byte> TensorData;
}
