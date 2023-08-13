namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TranslationUnit.h")]
public partial class UTranslationUnit : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The localization namespace for this translation</summary>
	public string Namespace;
	///<summary>The localization key for this translation</summary>
	public string Key;
	///<summary>Original text from the source language</summary>
	public string Source;
	///<summary>Translations</summary>
	public string Translation;
	///<summary>Contexts the source was found in</summary>
	public TArray<FTranslationContextInfo> Contexts;
	///<summary>Whether the changes have been reviewed</summary>
	public bool HasBeenReviewed;
	///<summary>If this Translation Unit had a different translation before import, it will be stored here</summary>
	public string TranslationBeforeImport;
	///<summary>Optional: Which Locres File this translation is in</summary>
	public string LocresPath;
}
