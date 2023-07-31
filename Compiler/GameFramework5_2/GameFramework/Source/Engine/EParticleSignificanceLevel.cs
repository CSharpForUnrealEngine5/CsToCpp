#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ParticleHelper.h")]
///<summary>A level of significance for a particle system. Used by game code to enable/disable emitters progressively as they move away from the camera or are occluded/off screen.</summary>
public enum EParticleSignificanceLevel {
	Low=0,
	Medium=1,
	High=2,
	Critical=3,
	Num=4,
}
