#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Uses the border style template defined in CommonUI project settings by default</summary>
[CppInclude("CommonBorder.h")]
public partial class UCommonBorder : UBorder {
	public static UClass StaticClass() {return default;}
	///<summary>SetStyle</summary>
	public  void SetStyle(UClass InStyle) {}
	///<summary>References the border style to use</summary>
	public UClass Style;
	///<summary>Turning this on will cause the safe zone size to be removed from this borders content padding down to the minimum specified</summary>
	public bool bReducePaddingBySafezone;
	///<summary>The minimum padding we will reduce to when the safezone grows</summary>
	public FMargin MinimumPadding;
	///<summary>Used to track widgets that were created before changing the default style pointer to null</summary>
	public bool bStyleNoLongerNeedsConversion;
}
