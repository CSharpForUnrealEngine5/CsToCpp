#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The specialized neural network for the Neural Morph Model.</summary>
[CppInclude("NeuralMorphNetwork.h")]
public partial class UNeuralMorphNetwork : UObject {
	///<summary>The MLP that acts as main network.</summary>
	public UNeuralMorphMLP MainMLP;
	///<summary>The MLP for the bone and curve groups, when in local mode.</summary>
	public UNeuralMorphMLP GroupMLP;
	///<summary>The means of the input values, used to normalize inputs.</summary>
	public TArray<float> InputMeans;
	///<summary>The standard deviation of the input values, used to normalize inputs.</summary>
	public TArray<float> InputStd;
	///<summary>The mode of the network, either local or global.</summary>
	public ENeuralMorphMode Mode;
	///<summary>The number of morph targets per bone, if set Mode == Local, otherwise ignored.</summary>
	public int NumMorphsPerBone;
	///<summary>The number of bones that were input.</summary>
	public int NumBones;
	///<summary>The number of curves that were input.</summary>
	public int NumCurves;
	///<summary>The number of floats per curve.</summary>
	public int NumFloatsPerCurve;
	///<summary>The number of groups. This is a group of bones/curves that create their own morphs.</summary>
	public int NumGroups;
	///<summary>The number of items (bones/curves) per group.</summary>
	public int NumItemsPerGroup;
}
