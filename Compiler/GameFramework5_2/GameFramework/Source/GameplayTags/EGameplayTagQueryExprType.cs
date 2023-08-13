namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayTagContainer.h")]
///<summary>Enumerates the list of supported query expression types.</summary>
[CppEnumInNamespace]
public enum EGameplayTagQueryExprType {
	Undefined=0,
	AnyTagsMatch=1,
	AllTagsMatch=2,
	NoTagsMatch=3,
	AnyExprMatch=4,
	AllExprMatch=5,
	NoExprMatch=6,
}
