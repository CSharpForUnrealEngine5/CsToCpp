namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* ---- All properties must be EditDefaultsOnly, BlueprintReadOnly !!! -----</summary>
[CppInclude("CommonBorder.h")]
public partial class UCommonBorderStyle : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The brush for the background of the border</summary>
	public FSlateBrush Background;
	///<summary>GetBackgroundBrush</summary>
	public void GetBackgroundBrush(FSlateBrush Brush) {}
}
