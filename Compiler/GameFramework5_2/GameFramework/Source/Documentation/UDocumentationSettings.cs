#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DocumentationSettings.h")]
public partial class UDocumentationSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Array of base URLs for documentation links that are loaded on startup</summary>
	public TArray<FDocumentationBaseUrl> DocumentationBaseUrls;
}
