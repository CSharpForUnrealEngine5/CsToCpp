#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/Determinism/PCGDeterminismTestsCommon.h")]
///<summary>This will include multiple values of different meanings, but we use an enum to facilitate data passing</summary>
public enum EDeterminismLevel {
	None=0,
	NoDeterminism=-1,
	Basic=-1,
	OrderOrthogonal=-1,
	OrderConsistent=-1,
	OrderIndependent=-1,
	Deterministic=-1,
}
