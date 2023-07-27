#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Modulators/DMXModulator.h")]
///<summary>Base class for custom modulators. Override Modulate and ModulateMatrix functions in the blueprints to implement functionality.</summary>
public partial class UDMXModulator : UObject {
// DMXModulator
	public  void Modulate(UDMXEntityFixturePatch FixturePatch,TMap<FDMXAttributeName,float> InNormalizedAttributeValues,TMap<FDMXAttributeName,float> OutNormalizedAttributeValues) {}
	public  void ModulateMatrix(UDMXEntityFixturePatch FixturePatch,TArray<FDMXNormalizedAttributeValueMap> InNormalizedMatrixAttributeValues,TArray<FDMXNormalizedAttributeValueMap> OutNormalizedMatrixAttributeValues) {}
}
