#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayTagResponseTable.h")]
///<summary>A data driven table for applying gameplay effects based on tag count. This allows designers to map a</summary>
public partial class UGameplayTagReponseTable : UDataAsset {
// GameplayTagReponseTable
	public TArray<FGameplayTagResponseTableEntry> Entries;
	public  void TagResponseEvent(FGameplayTag Tag,int NewCount,UAbilitySystemComponent ASC,int idx) {}
}
