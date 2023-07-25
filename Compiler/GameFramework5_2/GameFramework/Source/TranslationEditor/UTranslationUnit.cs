#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TranslationUnit.h")]
public partial class UTranslationUnit : UObject {
// TranslationUnit
	public string Namespace;
	public string Key;
	public string Source;
	public string Translation;
	public TArray<FTranslationContextInfo> Contexts;
	public bool HasBeenReviewed;
	public string TranslationBeforeImport;
	public string LocresPath;
}
