namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Static data for Animation purposes. Contains data about bones that shouldn&#39;t change every frame.</summary>
[CppInclude("Roles/LiveLinkAnimationTypes.h")]
public partial struct FLiveLinkSkeletonStaticData {
	public TArray<string> BoneNames;
	public TArray<int> BoneParents;
}
