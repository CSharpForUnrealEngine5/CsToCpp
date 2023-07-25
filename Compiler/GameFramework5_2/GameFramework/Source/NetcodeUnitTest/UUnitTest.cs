#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UnitTest.h")]
///<summary>Base class for all unit tests</summary>
public partial class UUnitTest : UUnitTestBase {
// UnitTest
	public ulong PeakMemoryUsage;
	public float TimeToPeakMem;
	public float LastExecutionTime;
	public TArray<UUnitTask> UnitTasks;
	public EUnitTestVerification VerificationState;
}
