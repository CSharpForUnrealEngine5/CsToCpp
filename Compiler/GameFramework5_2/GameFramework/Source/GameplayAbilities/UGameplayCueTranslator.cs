namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This is the base class for GameplayCue Translators. This is what games must extend from in order to add their own rules.</summary>
[CppInclude("GameplayCueTranslator.h")]
public partial class UGameplayCueTranslator : UObject {
	public static UClass StaticClass() {return default;}
}
