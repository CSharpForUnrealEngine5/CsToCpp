#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NeuralMorphNetwork.h")]
///<summary>A fully connected layer, which contains the weights and biases for those connections.</summary>
public partial class UNeuralMorphMLPLayer : UObject {
// NeuralMorphMLPLayer
	public int NumInputs;
	public int NumOutputs;
	public int Depth;
	public TArray<float> Weights;
	public TArray<float> Biases;
}
