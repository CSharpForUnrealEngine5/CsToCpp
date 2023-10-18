namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/ParticleSystemComponent.h")]
///<summary>Particle system replay state</summary>
public enum ParticleReplayState {
	PRS_Disabled=0,
	PRS_Capturing=1,
	PRS_Replaying=2,
	PRS_MAX=3,
}
