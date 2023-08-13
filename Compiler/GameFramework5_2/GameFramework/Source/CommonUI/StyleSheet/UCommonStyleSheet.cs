namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>PROTOTYPE: DO NOT USE!!!</summary>
[CppInclude("StyleSheet/CommonStyleSheet.h")]
public partial class UCommonStyleSheet : UDataAsset {
	public static UClass StaticClass() {return default;}
	///<summary>Properties</summary>
	public TArray<UCommonStyleSheetTypeBase> Properties;
	///<summary>ImportedStyleSheets</summary>
	public TArray<UCommonStyleSheet> ImportedStyleSheets;
}
