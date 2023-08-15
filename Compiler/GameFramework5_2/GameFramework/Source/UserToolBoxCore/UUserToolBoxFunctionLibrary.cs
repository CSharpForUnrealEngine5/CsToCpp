namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UserToolBoxFunctionLibrary.h")]
public partial class UUserToolBoxFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>GetBrushById</summary>
	public static FSlateBrush GetBrushById(string Name) { return default; }
	///<summary>GetAllSlateStyle</summary>
	public static TArray<FName> GetAllSlateStyle() { return default; }
	///<summary>GetBrushByStyleAndId</summary>
	public static FSlateBrush GetBrushByStyleAndId(FName StyleName,FName Id) { return default; }
}
