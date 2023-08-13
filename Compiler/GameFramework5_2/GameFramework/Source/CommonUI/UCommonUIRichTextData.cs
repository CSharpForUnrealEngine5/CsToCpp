namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Derive from this class for rich text data per game</summary>
[CppInclude("CommonUIRichTextData.h")]
public partial class UCommonUIRichTextData : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>InlineIconSet</summary>
	public UDataTable InlineIconSet;
}
