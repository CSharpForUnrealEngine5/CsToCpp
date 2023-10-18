namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayTagColumn.h")]
public partial class UDEPRECATED_ChooserColumnGameplayTag : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>InputValue</summary>
	public object /*InputValue*/ InputValue;
	///<summary>TagMatchType</summary>
	public EGameplayContainerMatchType TagMatchType;
	///<summary>array of results (cells for this column for each row in the table)</summary>
	public TArray<FGameplayTagContainer> RowValues;
}
