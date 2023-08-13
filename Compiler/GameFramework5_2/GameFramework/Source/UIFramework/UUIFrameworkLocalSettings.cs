namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UIFLocalSettings.h")]
public partial class UUIFrameworkLocalSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>The image to render for when a requested resource is inaccessible.</summary>
	public TSoftObjectPtr<UObject> ErrorResource;
	///<summary>The image to render while a resource is loading.</summary>
	public TSoftObjectPtr<UObject> LoadingResource;
}
