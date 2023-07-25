#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonBorder.h")]
///<summary>Uses the border style template defined in CommonUI project settings by default</summary>
public partial class UCommonBorder : UBorder {
// CommonBorder
	public void SetStyle(UClass InStyle) {}
	public UClass Style;
	public bool bReducePaddingBySafezone;
	public FMargin MinimumPadding;
	public bool bStyleNoLongerNeedsConversion;
}
