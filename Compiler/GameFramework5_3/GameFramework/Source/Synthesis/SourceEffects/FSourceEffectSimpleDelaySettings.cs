namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SourceEffects/SourceEffectSimpleDelay.h")]
public partial struct FSourceEffectSimpleDelaySettings {
	public float SpeedOfSound;
	public float DelayAmount;
	public float DryAmount;
	public float WetAmount;
	public float Feedback;
	public bool bDelayBasedOnDistance;
	public bool bUseDistanceOverride;
}
