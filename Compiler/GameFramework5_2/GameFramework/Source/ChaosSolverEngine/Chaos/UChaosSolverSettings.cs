#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings class for the Chaos Solver</summary>
[CppInclude("Chaos/ChaosSolverSettings.h")]
public partial class UChaosSolverSettings : UDeveloperSettings {
	///<summary>The class to use when auto-creating a default chaos solver actor</summary>
	public FSoftClassPath DefaultChaosSolverActorClass;
}
