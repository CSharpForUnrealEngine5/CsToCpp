#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Converts Attributes from CMY to RGB.</summary>
[CppInclude("Modulators/DMXModulator_CMYtoRGB.h")]
public partial class UDMXModulator_CMYtoRGB : UDMXModulator {
	///<summary>The name of the attribute that is converted from Cyan to Red</summary>
	public FDMXAttributeName AttributeCyanToRed;
	///<summary>The name of the attribute that is converted from Magenta to Green</summary>
	public FDMXAttributeName AttributeMagentaToGreen;
	///<summary>The name of the attribute that is converted from Yellow to Blue</summary>
	public FDMXAttributeName AttributeYellowToBlue;
}
