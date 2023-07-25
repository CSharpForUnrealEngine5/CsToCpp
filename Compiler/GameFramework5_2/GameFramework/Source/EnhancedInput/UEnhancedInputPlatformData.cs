#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnhancedInputPlatformSettings.h")]
///<summary>A base class that can be used to store platform specific data for Enhanced Input.</summary>
public partial class UEnhancedInputPlatformData : UObject {
// EnhancedInputPlatformData
	public UObject GetContextRedirect(UObject InContext) { return default; }
	public TMap<UInputMappingContext,UInputMappingContext> MappingContextRedirects;
}
