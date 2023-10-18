namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UAudioRequirementPreset - A reusable GameplayTagQuery for audio</summary>
[CppInclude("AudioGameplayRequirements.h")]
public partial class UAudioRequirementPreset : UDataAsset {
	public static UClass StaticClass() {return default;}
	///<summary>Query</summary>
	public FGameplayTagQuery Query;
}
