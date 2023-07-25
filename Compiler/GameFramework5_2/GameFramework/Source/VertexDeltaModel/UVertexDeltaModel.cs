#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VertexDeltaModel.h")]
///<summary>The vertex delta model, which uses a GPU based neural network.</summary>
public partial class UVertexDeltaModel : UMLDeformerGeomCacheModel {
// VertexDeltaModel
	public UNeuralNetwork NNINetwork;
	public int NumHiddenLayers;
	public int NumNeuronsPerLayer;
	public int NumIterations;
	public int BatchSize;
	public float LearningRate;
}
