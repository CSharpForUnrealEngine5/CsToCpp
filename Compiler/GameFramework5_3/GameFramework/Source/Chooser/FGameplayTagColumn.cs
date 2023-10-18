namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayTagColumn.h")]
public partial struct FGameplayTagColumn {
	public FInstancedStruct InputValue;
	public EGameplayContainerMatchType TagMatchType;
	public FGameplayTagContainer DefaultRowValue;
	public TArray<FGameplayTagContainer> RowValues;
}
