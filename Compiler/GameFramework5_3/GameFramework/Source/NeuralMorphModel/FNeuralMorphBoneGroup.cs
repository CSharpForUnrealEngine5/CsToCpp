namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A group of bones, which can generate morph targets together.</summary>
[CppInclude("NeuralMorphTypes.h")]
public partial struct FNeuralMorphBoneGroup {
	public FName GroupName;
	public TArray<FBoneReference> BoneNames;
}
