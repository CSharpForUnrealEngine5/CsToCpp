#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NeuralTensor.h")]
///<summary>For a general overview of NeuralNetworkInference (NNI), including documentation and code samples, @see UNeuralNetwork, the main class of NNI.</summary>
public partial struct FNeuralTensor {
// NeuralTensor
	public ENeuralDataType DataType;
	public TArray<long> Sizes;
	public long Volume;
	public string Name;
	public ENeuralTensorType TensorType;
	public TArray<byte> UnderlyingUInt8ArrayData;
	public bool bEnableGPU;
}
