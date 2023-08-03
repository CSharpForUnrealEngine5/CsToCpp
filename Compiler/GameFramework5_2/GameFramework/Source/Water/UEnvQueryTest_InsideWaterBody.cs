#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnvQueryTest_InsideWaterBody.h")]
public partial class UEnvQueryTest_InsideWaterBody : UEnvQueryTest {
	public static UClass StaticClass() {return default;}
	///<summary>Whether waves should be taken into account in the query.</summary>
	public bool bIncludeWaves;
	///<summary>Use the simple (faster) version of waves computation.</summary>
	public bool bSimpleWaves;
	///<summary>Whether water body exclusion volumes should be taken into account in the query.</summary>
	public bool bIgnoreExclusionVolumes;
}
