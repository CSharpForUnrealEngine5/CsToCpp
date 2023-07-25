#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NeuralMorphNetwork.h")]
///<summary>The specialized neural network for the Neural Morph Model.</summary>
public partial class UNeuralMorphNetwork : UObject {
// NeuralMorphNetwork
	public UNeuralMorphMLP MainMLP;
	public UNeuralMorphMLP GroupMLP;
	public TArray<float> InputMeans;
	public TArray<float> InputStd;
	public ENeuralMorphMode Mode;
	public int NumMorphsPerBone;
	public int NumBones;
	public int NumCurves;
	public int NumFloatsPerCurve;
	public int NumGroups;
	public int NumItemsPerGroup;
}
