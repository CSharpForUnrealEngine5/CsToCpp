namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Framework/Styling/ButtonWidgetStyle.h")]
public partial class UButtonWidgetStyle : USlateWidgetStyleContainerBase {
	public static UClass StaticClass() {return default;}
	///<summary>The actual data describing the button&#39;s appearance.</summary>
	public FButtonStyle ButtonStyle;
}
