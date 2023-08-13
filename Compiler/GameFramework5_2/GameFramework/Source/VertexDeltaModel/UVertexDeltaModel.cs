namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The vertex delta model, which uses a GPU based neural network.</summary>
[CppInclude("VertexDeltaModel.h")]
public partial class UVertexDeltaModel : UMLDeformerGeomCacheModel {
	public static UClass StaticClass() {return default;}
	///<summary>The NNI neural network.</summary>
	public UNeuralNetwork NNINetwork;
	///<summary>The number of hidden layers that the neural network model will have.\nHigher numbers will slow down performance but can deal with more complex deformations.</summary>
	public int NumHiddenLayers;
	///<summary>The number of units/neurons per hidden layer. Higher numbers will slow down performance but allow for more complex mesh deformations.</summary>
	public int NumNeuronsPerLayer;
	///<summary>The number of iterations to train the model for.</summary>
	public int NumIterations;
	///<summary>The number of frames per batch when training the model.</summary>
	public int BatchSize;
	///<summary>The learning rate used during the model training.</summary>
	public float LearningRate;
}
