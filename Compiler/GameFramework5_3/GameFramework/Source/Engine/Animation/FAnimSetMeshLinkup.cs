namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This is a mapping table between each bone in a particular skeletal mesh and the tracks of this animation set.</summary>
[CppInclude("Animation/AnimSet.h")]
public partial struct FAnimSetMeshLinkup {
	public TArray<int> BoneToTrackTable;
}
