#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FSubmixEffectFilterSettings</summary>
[CppInclude("SubmixEffects/SubmixEffectFilter.h")]
public partial struct FSubmixEffectFilterSettings {
	public ESubmixFilterType FilterType;
	public ESubmixFilterAlgorithm FilterAlgorithm;
	public float FilterFrequency;
	public float FilterQ;
}
