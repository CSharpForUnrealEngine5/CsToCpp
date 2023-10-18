namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents a hierarchy of a human pose skeleton tracked by the AR system</summary>
[CppInclude("ARTypes.h")]
public partial struct FARSkeletonDefinition {
	public int NumJoints;
	public TArray<FName> JointNames;
	public TArray<int> ParentIndices;
}
