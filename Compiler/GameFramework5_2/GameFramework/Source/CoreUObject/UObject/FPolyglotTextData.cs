#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Polyglot data that may be registered to the text localization manager at runtime.</summary>
[CppInclude("UObject/NoExportTypes.h")]
public partial struct FPolyglotTextData {
	public ELocalizedTextSourceCategory Category;
	public string NativeCulture;
	public string Namespace;
	public string Key;
	public string NativeString;
	public TMap<string,string> LocalizedStrings;
	public bool bIsMinimalPatch;
	public string CachedText;
}
