#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A fully connected layer, which contains the weights and biases for those connections.</summary>
[CppInclude("NeuralMorphNetwork.h")]
public partial class UNeuralMorphMLPLayer : UObject {
	///<summary>The weight matrix number of inputs (rows).</summary>
	public int NumInputs;
	///<summary>The weight matrix number of outputs (columns).</summary>
	public int NumOutputs;
	///<summary>The number of instances of inputs and outputs.</summary>
	public int Depth;
	///<summary>A 2D array of weights. The number of weights equals NumRows x NumColumns x Depth.</summary>
	public TArray<float> Weights;
	///<summary>The biases. The number of biases will be the same as the number of columns multiplied by the depth.</summary>
	public TArray<float> Biases;
}
