namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraEffectType.h")]
///<summary>Controls how often should we update scalability states for these effects.</summary>
public enum ENiagaraScalabilityUpdateFrequency {
	SpawnOnly=0,
	Low=1,
	Medium=2,
	High=3,
	Continuous=4,
}
