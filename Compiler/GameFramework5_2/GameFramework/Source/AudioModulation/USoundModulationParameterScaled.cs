#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Linearly scaled value between unit minimum and maximum.</summary>
[CppInclude("SoundModulationParameter.h")]
public partial class USoundModulationParameterScaled : USoundModulationParameter {
	///<summary>Unit minimum of modulator. Minimum is only enforced at modulation destination.</summary>
	public float UnitMin;
	///<summary>Unit maximum of modulator. Maximum is only enforced at modulation destination.</summary>
	public float UnitMax;
}
