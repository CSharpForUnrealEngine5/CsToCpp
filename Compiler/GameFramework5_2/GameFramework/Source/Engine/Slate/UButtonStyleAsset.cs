namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An asset describing a button&#39;s appearance.</summary>
[CppInclude("Slate/ButtonStyleAsset.h")]
public partial class UButtonStyleAsset : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The actual data describing the button&#39;s appearance.</summary>
	public FButtonStyle ButtonStyle;
}
