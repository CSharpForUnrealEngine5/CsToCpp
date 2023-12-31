namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UnitTest.h")]
///<summary>The different stages that unit tests can be reset to - a global/non-locally-customizable list, for now</summary>
public enum EUnitTestResetStage {
	None=0,
	FullReset=1,
	ResetConnection=2,
	ResetExecute=3,
}
