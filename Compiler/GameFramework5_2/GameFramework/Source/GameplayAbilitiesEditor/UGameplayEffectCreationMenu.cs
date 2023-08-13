namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Container to hold EventKeywords for PIE testing</summary>
[CppInclude("GameplayEffectCreationMenu.h")]
public partial class UGameplayEffectCreationMenu : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Definitions</summary>
	public TArray<FGameplayEffectCreationData> Definitions;
}
