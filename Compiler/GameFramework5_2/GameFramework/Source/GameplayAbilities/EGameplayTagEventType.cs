namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayEffectTypes.h")]
///<summary>Rather a tag was added or removed, used in callbacks</summary>
[CppEnumInNamespace]
public enum EGameplayTagEventType {
	NewOrRemoved=0,
	AnyCountChange=1,
}
