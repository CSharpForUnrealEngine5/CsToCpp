#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Wrapper struct as we dont support nested containers</summary>
[CppInclude("Animation/AnimClassInterface.h")]
public partial struct FCachedPoseIndices {
	public TArray<int> OrderedSavedPoseNodeIndices;
}
