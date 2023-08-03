#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnvironmentQuery/Tests/EnvQueryTest_Dot.h")]
public partial class UEnvQueryTest_Dot : UEnvQueryTest {
	public static UClass StaticClass() {return default;}
	///<summary>defines direction of first line used by test</summary>
	public FEnvDirection LineA;
	///<summary>defines direction of second line used by test</summary>
	public FEnvDirection LineB;
	///<summary>TestMode</summary>
	public EEnvTestDot TestMode;
	///<summary>If true, this test uses the absolute value of the dot product rather than the dot product itself.  Useful</summary>
	public bool bAbsoluteValue;
}
