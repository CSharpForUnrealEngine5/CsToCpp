namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayCueInterface.h")]
public partial struct FActiveGameplayCueContainer {
	public TArray<FActiveGameplayCue> GameplayCues;
	public UAbilitySystemComponent Owner;
}
