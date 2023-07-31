#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayTagResponseTable.h")]
public partial struct FGameplayTagReponsePair {
	public FGameplayTag Tag;
	public UClass ResponseGameplayEffect;
	public TArray<UClass> ResponseGameplayEffects;
	public int SoftCountCap;
}
