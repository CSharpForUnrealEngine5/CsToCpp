#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Modulators/DMXModulator_ExtraCellAttributes.h")]
///<summary>Adds matrix attributes that are not received (e.g. because DMX was generated from PixelMapping) to the DMX signal</summary>
public partial class UDMXModulator_ExtraCellAttributes : UDMXModulator {
// DMXModulator_ExtraCellAttributes
	public TMap<FDMXAttributeName,float> ExtraAttributeNameToNormalizedValueMap;
}
