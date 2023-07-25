#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Enum used to indicate what type of timeline signature a function matches.</summary>
public enum ETimelineSigType {
	ETS_EventSignature=0,
	ETS_FloatSignature=1,
	ETS_VectorSignature=2,
	ETS_LinearColorSignature=3,
	ETS_InvalidSignature=4,
	ETS_MAX=5,
}
