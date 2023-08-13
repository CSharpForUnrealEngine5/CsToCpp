namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayTagsK2Node_SwitchGameplayTag.h")]
public partial class UGameplayTagsK2Node_SwitchGameplayTag : UK2Node_Switch {
	public static UClass StaticClass() {return default;}
	///<summary>PinTags</summary>
	public TArray<FGameplayTag> PinTags;
	///<summary>UPROPERTY(EditAnywhere, Category = PinOptions)</summary>
	public TArray<string> PinNames;
}
