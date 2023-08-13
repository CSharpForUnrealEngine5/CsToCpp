namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RenderGridDeveloperLibrary.h")]
public partial class URenderGridDeveloperLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Returns all render grid assets that currently exist in the project (on disk and in memory).</summary>
	public static TArray<URenderGrid> GetAllRenderGridAssets() { return default; }
	///<summary>Returns the given render grid asset that exists at the given object path (whether it&#39;s on disk or in memory).</summary>
	public static URenderGrid GetRenderGridAsset(string ObjectPath) { return default; }
}
