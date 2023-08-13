namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Converts Attributes from RGB to CMY</summary>
[CppInclude("Modulators/DMXModulator_RGBtoCMY.h")]
public partial class UDMXModulator_RGBtoCMY : UDMXModulator {
	public static UClass StaticClass() {return default;}
	///<summary>The name of the attribute that is converted from Red to Cyan</summary>
	public FDMXAttributeName AttributeRedToCyan;
	///<summary>The name of the attribute that is converted from Green to Magenta</summary>
	public FDMXAttributeName AttributeGreenToMagenta;
	///<summary>The name of the attribute that is converted from Blue to Yellow</summary>
	public FDMXAttributeName AttributeBlueToYellow;
}
