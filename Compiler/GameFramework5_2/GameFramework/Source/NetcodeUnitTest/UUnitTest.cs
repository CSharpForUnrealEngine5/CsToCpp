#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for all unit tests</summary>
[CppInclude("UnitTest.h")]
public partial class UUnitTest : UUnitTestBase {
	///<summary>Stores stats on the highest-ever reported memory usage, for this unit test - for estimating memory usage</summary>
	public ulong PeakMemoryUsage;
	///<summary>The amount of time it takes to reach &#39;PeakMemoryUsage&#39; (or within 90% of its value)</summary>
	public float TimeToPeakMem;
	///<summary>The amount of time it took to execute the unit test the last time it was run</summary>
	public float LastExecutionTime;
	///<summary>UnitTask&#39;s which must be run before different stages of the unit test can execute</summary>
	public TArray<UUnitTask> UnitTasks;
	///<summary>Whether or not the success or failure of the current unit test has been verified</summary>
	public EUnitTestVerification VerificationState;
}
