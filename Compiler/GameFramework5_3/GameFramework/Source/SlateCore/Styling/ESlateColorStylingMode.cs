namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Styling/SlateColor.h")]
///<summary>Enumerates types of color values that can be held by Slate color.</summary>
public enum ESlateColorStylingMode {
	UseColor_Specified=0,
	UseColor_ColorTable=1,
	UseColor_Foreground=2,
	UseColor_Foreground_Subdued=3,
	UseColor_UseStyle=4,
}
