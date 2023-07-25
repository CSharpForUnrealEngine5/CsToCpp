#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARTypes.h")]
///<summary>Represents a hierarchy of a human pose skeleton tracked by the AR system</summary>
public partial struct FARSkeletonDefinition {
// ARSkeletonDefinition
	public int NumJoints;
	public TArray<string> JointNames;
	public TArray<int> ParentIndices;
}
