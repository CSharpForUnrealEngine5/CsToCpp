#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents a hierarchy of a human pose skeleton tracked by the AR system</summary>
[CppInclude("ARTypes.h")]
public partial struct FARSkeletonDefinition {
	public int NumJoints;
	public TArray<string> JointNames;
	public TArray<int> ParentIndices;
}
