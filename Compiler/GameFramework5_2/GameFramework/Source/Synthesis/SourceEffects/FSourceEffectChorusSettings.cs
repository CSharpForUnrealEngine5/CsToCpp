#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SourceEffects/SourceEffectChorus.h")]
public partial struct FSourceEffectChorusSettings {
	public float Depth;
	public float Frequency;
	public float Feedback;
	public float WetLevel;
	public float DryLevel;
	public float Spread;
	public FSoundModulationDestinationSettings DepthModulation;
	public FSoundModulationDestinationSettings FrequencyModulation;
	public FSoundModulationDestinationSettings FeedbackModulation;
	public FSoundModulationDestinationSettings WetModulation;
	public FSoundModulationDestinationSettings DryModulation;
	public FSoundModulationDestinationSettings SpreadModulation;
}
