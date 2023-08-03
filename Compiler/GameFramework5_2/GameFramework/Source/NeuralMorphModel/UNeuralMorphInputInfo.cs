#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The neural morph model&#39;s input info that contains all the data about the inputs to the network.</summary>
[CppInclude("NeuralMorphInputInfo.h")]
public partial class UNeuralMorphInputInfo : UMLDeformerInputInfo {
	public static UClass StaticClass() {return default;}
	///<summary>The groups of bones that generate morph targets together.</summary>
	public TArray<FNeuralMorphBoneGroup> BoneGroups;
	///<summary>The groups of curves that generate morph targets together.</summary>
	public TArray<FNeuralMorphCurveGroup> CurveGroups;
}
