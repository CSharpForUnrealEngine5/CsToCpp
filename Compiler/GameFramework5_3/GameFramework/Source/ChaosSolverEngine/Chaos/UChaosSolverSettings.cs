namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings class for the Chaos Solver</summary>
[CppInclude("Chaos/ChaosSolverSettings.h")]
public partial class UChaosSolverSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>The class to use when auto-creating a default chaos solver actor</summary>
	public FSoftClassPath DefaultChaosSolverActorClass;
}
