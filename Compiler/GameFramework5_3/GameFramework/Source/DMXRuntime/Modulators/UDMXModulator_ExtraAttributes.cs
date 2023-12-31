namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Adds attributes that are not received (e.g. because DMX was generated from PixelMapping) to the DMX signal</summary>
[CppInclude("Modulators/DMXModulator_ExtraAttributes.h")]
public partial class UDMXModulator_ExtraAttributes : UDMXModulator {
	public static UClass StaticClass() {return default;}
	///<summary>Adds the attributes with their values to the Output if they don&#39;t exist, or replaces them with the values specified</summary>
	public TMap<FDMXAttributeName,float> ExtraAttributeNameToNormalizedValueMap;
}
