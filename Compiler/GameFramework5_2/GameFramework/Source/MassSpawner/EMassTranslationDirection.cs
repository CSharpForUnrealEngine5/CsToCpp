#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassTranslator.h")]
public enum EMassTranslationDirection {
	None=0,
	InitializationOnly=1,
	ActorToMass=-1,
	MassToActor=-1,
	BothWays=-1,
}
