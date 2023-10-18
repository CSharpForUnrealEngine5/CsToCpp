namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A group of curves, which can generate morph targets together.</summary>
[CppInclude("NeuralMorphTypes.h")]
public partial struct FNeuralMorphCurveGroup {
	public FName GroupName;
	public TArray<FMLDeformerCurveReference> CurveNames;
}
