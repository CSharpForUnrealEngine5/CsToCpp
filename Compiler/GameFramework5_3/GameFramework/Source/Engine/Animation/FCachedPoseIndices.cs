namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Wrapper struct as we dont support nested containers</summary>
[CppInclude("Animation/AnimClassInterface.h")]
public partial struct FCachedPoseIndices {
	public TArray<int> OrderedSavedPoseNodeIndices;
}
