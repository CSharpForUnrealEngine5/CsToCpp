namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A blend profile is a set of per-bone scales that can be used in transitions and blend lists</summary>
[CppInclude("Animation/BlendProfile.h")]
public partial class UBlendProfile : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The skeleton that owns this profile</summary>
	public USkeleton OwningSkeleton;
	///<summary>List of blend scale entries</summary>
	public TArray<FBlendProfileBoneEntry> ProfileEntries;
	///<summary>Blend Profile Mode. Read EBlendProfileMode for more details</summary>
	public EBlendProfileMode Mode;
}
