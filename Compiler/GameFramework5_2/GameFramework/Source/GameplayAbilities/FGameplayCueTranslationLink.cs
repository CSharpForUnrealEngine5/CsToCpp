#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents a translation from one FGameplayCueTranslatorNode to many others. You will have one of these links per UGameplayCueTranslator that can translate a node.</summary>
[CppInclude("GameplayCueTranslator.h")]
public partial struct FGameplayCueTranslationLink {
	public UGameplayCueTranslator RulesCDO;
}
