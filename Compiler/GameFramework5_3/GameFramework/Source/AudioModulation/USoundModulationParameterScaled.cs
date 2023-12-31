namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Linearly scaled value between unit minimum and maximum.</summary>
[CppInclude("SoundModulationParameter.h")]
public partial class USoundModulationParameterScaled : USoundModulationParameter {
	public static UClass StaticClass() {return default;}
	///<summary>Unit minimum of modulator. Minimum is only enforced at modulation destination.</summary>
	public float UnitMin;
	///<summary>Unit maximum of modulator. Maximum is only enforced at modulation destination.</summary>
	public float UnitMax;
}
