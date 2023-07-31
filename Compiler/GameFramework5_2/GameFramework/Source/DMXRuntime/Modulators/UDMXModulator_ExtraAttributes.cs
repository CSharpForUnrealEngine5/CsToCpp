#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Adds attributes that are not received (e.g. because DMX was generated from PixelMapping) to the DMX signal</summary>
[CppInclude("Modulators/DMXModulator_ExtraAttributes.h")]
public partial class UDMXModulator_ExtraAttributes : UDMXModulator {
	///<summary>Adds the attributes with their values to the Output if they don&#39;t exist, or replaces them with the values specified</summary>
	public TMap<FDMXAttributeName,float> ExtraAttributeNameToNormalizedValueMap;
}
