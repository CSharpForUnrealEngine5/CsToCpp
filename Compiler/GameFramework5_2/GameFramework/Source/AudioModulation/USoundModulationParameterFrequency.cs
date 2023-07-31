#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Modulation Parameter that scales normalized, unitless value to logarithmic frequency unit space with provided minimum and maximum.</summary>
[CppInclude("SoundModulationParameter.h")]
public partial class USoundModulationParameterFrequency : USoundModulationParameterFrequencyBase {
	///<summary>Unit minimum of modulator. Minimum is only enforced at modulation destination.</summary>
	public float UnitMin;
	///<summary>Unit maximum of modulator. Maximum is only enforced at modulation destination.</summary>
	public float UnitMax;
}
