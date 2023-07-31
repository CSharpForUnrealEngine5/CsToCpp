#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for custom modulators. Override Modulate and ModulateMatrix functions in the blueprints to implement functionality.</summary>
[CppInclude("Modulators/DMXModulator.h")]
public partial class UDMXModulator : UObject {
	///<summary>Modulate</summary>
	public  void Modulate(UDMXEntityFixturePatch FixturePatch,TMap<FDMXAttributeName,float> InNormalizedAttributeValues,TMap<FDMXAttributeName,float> OutNormalizedAttributeValues) {}
	///<summary>ModulateMatrix</summary>
	public  void ModulateMatrix(UDMXEntityFixturePatch FixturePatch,TArray<FDMXNormalizedAttributeValueMap> InNormalizedMatrixAttributeValues,TArray<FDMXNormalizedAttributeValueMap> OutNormalizedMatrixAttributeValues) {}
}
