#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Modulation Parameter that scales normalized, unitless value to bipolar range. Mixes multiplicatively.</summary>
[CppInclude("SoundModulationParameter.h")]
public partial class USoundModulationParameterBipolar : USoundModulationParameter {
	///<summary>Unit range of modulator. Range is only enforced at modulation destination.</summary>
	public float UnitRange;
}
