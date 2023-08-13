namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This is an auxiliary class. See UNeuralNetwork for a high-level wrapper of the whole NeuralNetworkInference plugin. The UNeuralNetwork header</summary>
[CppInclude("NeuralNetworkInferenceQAAsset.h")]
public partial class UNeuralNetworkInferenceQAAsset : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Operators</summary>
	public TMap<string,FNeuralNetworkInferenceQAOperatorAsset> Operators;
}
