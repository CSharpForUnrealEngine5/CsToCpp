#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct used to update a blueprint property with a gameplay tag count.</summary>
[CppInclude("GameplayEffectTypes.h")]
public partial struct FGameplayTagBlueprintPropertyMapping {
	public FGameplayTag TagToMap;
	public object PropertyToEdit;
	public string PropertyName;
	public FGuid PropertyGuid;
}
