#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>NeuralNetworkInference (NNI) is Unreal Engine&#39;s framework for running deep learning and neural network inference. It is focused on:</summary>
[CppInclude("NeuralNetwork.h")]
public partial class UNeuralNetwork : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The neural device type of the network. It defines whether the network will use CPU or GPU acceleration hardware during inference (on Run).</summary>
	public ENeuralDeviceType DeviceType;
	///<summary>It defines whether Run() will expect the input data in CPU memory (Run will upload the memory to the GPU) or GPU memory (no upload needed).</summary>
	public ENeuralDeviceType InputDeviceType;
	///<summary>It defines whether Run() will return the output data in CPU memory (Run will download the memory to the CPU) or GPU (no download needed).</summary>
	public ENeuralDeviceType OutputDeviceType;
	///<summary>It defines whether UNeuralNetwork::Run() will block the thread until completed (Synchronous), or whether it will run on a background thread,</summary>
	public ENeuralSynchronousMode SynchronousMode;
	///<summary>If SynchronousMode is Asynchronous, this variable will define whether the callback delegate is called from the game thread (highly</summary>
	public ENeuralThreadMode ThreadModeDelegateForAsyncRunCompleted;
	///<summary>Original model file path from which this UNeuralNetwork was loaded from.</summary>
	public string ModelFullFilePath;
	///<summary>Whether this UNeuralNetwork instance has loaded a valid network model already, i.e., whether Load() was called and returned true.</summary>
	public bool bIsLoaded;
	///<summary>A buffer of memory representing the ONNX model. It is equivalent to the serialization of the ONNX file.</summary>
	public TArray<byte> ModelReadFromFileInBytes;
	///<summary>Whether some of the FNeuralTensor of InputTensor have flexible/variable dimensions. E.g., this is useful for variable batch size.</summary>
	public TArray<bool> AreInputTensorSizesVariable;
	///<summary>Importing data and options used for loading the network.</summary>
	public UAssetImportData AssetImportData;
}
