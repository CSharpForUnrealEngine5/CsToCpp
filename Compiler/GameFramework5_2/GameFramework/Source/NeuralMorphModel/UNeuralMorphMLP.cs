namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An MLP neural network.</summary>
[CppInclude("NeuralMorphNetwork.h")]
public partial class UNeuralMorphMLP : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The network weights and biases of the main network.</summary>
	public TArray<UNeuralMorphMLPLayer> Layers;
}
