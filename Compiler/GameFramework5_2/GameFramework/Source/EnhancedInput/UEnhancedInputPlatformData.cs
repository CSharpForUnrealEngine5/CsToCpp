namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A base class that can be used to store platform specific data for Enhanced Input.</summary>
[CppInclude("EnhancedInputPlatformSettings.h")]
public partial class UEnhancedInputPlatformData : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Returns a pointer to the desired redirect mapping context. If there isn&#39;t one, then this returns InContext.</summary>
	public UInputMappingContext GetContextRedirect(UInputMappingContext InContext) { return default; }
	///<summary>Maps one Input Mapping Context to another. This can be used to replace</summary>
	public TMap<UInputMappingContext,UInputMappingContext> MappingContextRedirects;
}
