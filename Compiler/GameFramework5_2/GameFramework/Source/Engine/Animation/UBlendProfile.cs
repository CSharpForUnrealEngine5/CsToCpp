#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/BlendProfile.h")]
///<summary>A blend profile is a set of per-bone scales that can be used in transitions and blend lists</summary>
public partial class UBlendProfile : UObject {
// BlendProfile
	public USkeleton OwningSkeleton;
	public TArray<FBlendProfileBoneEntry> ProfileEntries;
	public EBlendProfileMode Mode;
}
