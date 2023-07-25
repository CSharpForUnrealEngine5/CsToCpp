#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NeuralNetwork.h")]
///<summary>NeuralNetworkInference (NNI) is Unreal Engine's framework for running deep learning and neural network inference. It is focused on:</summary>
public partial class UNeuralNetwork : UObject {
// NeuralNetwork
	public ENeuralDeviceType DeviceType;
	public ENeuralDeviceType InputDeviceType;
	public ENeuralDeviceType OutputDeviceType;
	public ENeuralSynchronousMode SynchronousMode;
	public ENeuralThreadMode ThreadModeDelegateForAsyncRunCompleted;
	public string ModelFullFilePath;
	public bool bIsLoaded;
	public TArray<byte> ModelReadFromFileInBytes;
	public TArray<bool> AreInputTensorSizesVariable;
	public UAssetImportData AssetImportData;
}
