namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayTagResponseTable.h")]
public partial struct FGameplayTagReponsePair {
	public FGameplayTag Tag;
	public UClass ResponseGameplayEffect;
	public TArray<UClass> ResponseGameplayEffects;
	public int SoftCountCap;
}
