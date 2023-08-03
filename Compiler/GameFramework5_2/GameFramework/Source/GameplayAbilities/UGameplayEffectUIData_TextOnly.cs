#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UI data that contains only text. This is mostly used as an example of a subclass of UGameplayEffectUIData.</summary>
[CppInclude("GameplayEffectUIData_TextOnly.h")]
public partial class UGameplayEffectUIData_TextOnly : UGameplayEffectUIData {
	public static UClass StaticClass() {return default;}
	///<summary>Description</summary>
	public string Description;
}
