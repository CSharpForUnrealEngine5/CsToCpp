#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SoundModulationParameter.h")]
public partial class USoundModulationParameterVolume : USoundModulationParameter {
	public static UClass StaticClass() {return default;}
	///<summary>Minimum volume of parameter. Only enforced at modulation destination.</summary>
	public float MinVolume;
}
