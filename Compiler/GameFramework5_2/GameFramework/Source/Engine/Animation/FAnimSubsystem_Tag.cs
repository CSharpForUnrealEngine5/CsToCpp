namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Allows anim nodes to be tagged by name at edit time and retrieved by tag at runtime</summary>
[CppInclude("Animation/AnimSubsystem_Tag.h")]
public partial struct FAnimSubsystem_Tag {
	public TMap<string,int> NodeIndices;
}
