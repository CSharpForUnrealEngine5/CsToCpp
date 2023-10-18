namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Specific class to handle color mixing using 4 channels (rgb, cmy, rgbw).</summary>
[CppInclude("DMXFixtureComponentColor.h")]
public partial class UDMXFixtureComponentColor : UDMXFixtureComponent {
	public static UClass StaticClass() {return default;}
	///<summary>DMXChannel1</summary>
	public FDMXAttributeName DMXChannel1;
	///<summary>DMXChannel2</summary>
	public FDMXAttributeName DMXChannel2;
	///<summary>DMXChannel3</summary>
	public FDMXAttributeName DMXChannel3;
	///<summary>DMXChannel4</summary>
	public FDMXAttributeName DMXChannel4;
	///<summary>Sets the color of the component. Note DMX Fixture Component Color does not support interpolation</summary>
	public void SetColorNoInterp(FLinearColor NewColor) {}
}
