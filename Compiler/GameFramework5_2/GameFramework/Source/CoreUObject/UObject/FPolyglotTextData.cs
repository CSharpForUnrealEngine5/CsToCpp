#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UObject/NoExportTypes.h")]
///<summary>Polyglot data that may be registered to the text localization manager at runtime.</summary>
public partial struct FPolyglotTextData {
// PolyglotTextData
	public ELocalizedTextSourceCategory Category;
	public string NativeCulture;
	public string Namespace;
	public string Key;
	public string NativeString;
	public TMap<string,string> LocalizedStrings;
	public bool bIsMinimalPatch;
	public string CachedText;
}
