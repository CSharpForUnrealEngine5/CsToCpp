namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>For a general overview of NeuralNetworkInference (NNI), including documentation and code samples, @see UNeuralNetwork, the main class of NNI.</summary>
[CppInclude("NeuralTensor.h")]
public partial struct FNeuralTensor {
	public ENeuralDataType DataType;
	public TArray<long> Sizes;
	public long Volume;
	public string Name;
	public ENeuralTensorType TensorType;
	public TArray<byte> UnderlyingUInt8ArrayData;
	public bool bEnableGPU;
}
