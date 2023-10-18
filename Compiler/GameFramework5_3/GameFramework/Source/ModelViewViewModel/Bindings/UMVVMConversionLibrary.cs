namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Bindings/MVVMConversionLibrary.h")]
public partial class UMVVMConversionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Converts a bool to a slate visibility.</summary>
	public static ESlateVisibility Conv_BoolToSlateVisibility(bool bIsVisible,ESlateVisibility TrueVisibility/*=ESlateVisibility.Visible*/,ESlateVisibility FalseVisibility/*=ESlateVisibility.Collapsed*/) { return default; }
}
