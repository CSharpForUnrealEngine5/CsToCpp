namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StyleSheet/CommonStyleSheetTypes.h")]
public partial class UCommonStyleSheetTypeFontTypeface : UCommonStyleSheetTypeBase {
	public static UClass StaticClass() {return default;}
	///<summary>FIXME: Should be used instead of SlateFontInfo but no time to do the customization</summary>
	public FSlateFontInfo Typeface;
}
