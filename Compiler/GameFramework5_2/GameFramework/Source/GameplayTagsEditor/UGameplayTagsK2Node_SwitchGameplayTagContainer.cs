namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayTagsK2Node_SwitchGameplayTagContainer.h")]
public partial class UGameplayTagsK2Node_SwitchGameplayTagContainer : UK2Node_Switch {
	public static UClass StaticClass() {return default;}
	///<summary>PinContainers</summary>
	public TArray<FGameplayTagContainer> PinContainers;
	///<summary>UPROPERTY(EditAnywhere, Category = PinOptions)</summary>
	public TArray<FName> PinNames;
}
