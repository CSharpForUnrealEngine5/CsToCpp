#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayTagColumn.h")]
public partial class UDEPRECATED_ChooserColumnGameplayTag : UObject {
	///<summary>InputValue</summary>
	public object /*InputValue*/ InputValue;
	///<summary>TagMatchType</summary>
	public EGameplayContainerMatchType TagMatchType;
	///<summary>array of results (cells for this column for each row in the table)</summary>
	public TArray<FGameplayTagContainer> RowValues;
}
