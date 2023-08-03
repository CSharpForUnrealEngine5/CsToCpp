#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A data driven table for applying gameplay effects based on tag count. This allows designers to map a</summary>
[CppInclude("GameplayTagResponseTable.h")]
public partial class UGameplayTagReponseTable : UDataAsset {
	public static UClass StaticClass() {return default;}
	///<summary>Entries</summary>
	public TArray<FGameplayTagResponseTableEntry> Entries;
	///<summary>TagResponseEvent</summary>
	public  void TagResponseEvent(FGameplayTag Tag,int NewCount,UAbilitySystemComponent ASC,int idx) {}
}
