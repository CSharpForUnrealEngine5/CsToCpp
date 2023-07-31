#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Beam/ParticleModuleBeamBase.h")]
///<summary>The method to use in determining the source/target tangent.</summary>
public enum Beam2SourceTargetTangentMethod {
	PEB2STTM_Direct=0,
	PEB2STTM_UserSet=1,
	PEB2STTM_Distribution=2,
	PEB2STTM_Emitter=3,
	PEB2STTM_MAX=4,
}
