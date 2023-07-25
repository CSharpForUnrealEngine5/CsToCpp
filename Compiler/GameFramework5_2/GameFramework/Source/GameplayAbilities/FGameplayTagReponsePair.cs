#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayTagResponseTable.h")]
public partial struct FGameplayTagReponsePair {
// GameplayTagReponsePair
	public FGameplayTag Tag;
	public UClass ResponseGameplayEffect;
	public TArray<UClass> ResponseGameplayEffects;
	public int SoftCountCap;
}
