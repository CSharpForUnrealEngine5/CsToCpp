namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Extension that allows per-system data to be held on the widget blueprint, and per-system logic to be executed during compilation</summary>
[CppInclude("WidgetBlueprintExtension.h")]
public partial class UWidgetBlueprintExtension : UBlueprintExtension {
	public static UClass StaticClass() {return default;}
}
