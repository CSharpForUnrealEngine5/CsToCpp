namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WebAPIUtilities.h")]
public partial class UWebAPIUtilities : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Return the message from the provided response.</summary>
	public static FText GetResponseMessage(FWebAPIMessageResponse MessageResponse) { return default; }
	///<summary>Return the host (only) from the provided Url.</summary>
	public static string GetHostFromUrl(string InUrl) { return default; }
}
