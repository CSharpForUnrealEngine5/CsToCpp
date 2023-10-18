namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/SoundWaveLoadingBehavior.h")]
///<summary>Only used when stream caching is enabled. Determines how we are going to load or retain a given audio asset.</summary>
public enum ESoundWaveLoadingBehavior {
	Inherited=0,
	RetainOnLoad=1,
	PrimeOnLoad=2,
	LoadOnDemand=3,
	ForceInline=4,
	Uninitialized=255,
}
