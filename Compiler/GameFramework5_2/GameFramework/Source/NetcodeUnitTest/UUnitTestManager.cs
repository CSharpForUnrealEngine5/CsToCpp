#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Manages centralized execution and tracking of unit tests, as well as handling console commands,</summary>
[CppInclude("UnitTestManager.h")]
public partial class UUnitTestManager : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Whether or not to cap the maximum number of unit tests that can be active at any given time</summary>
	public bool bCapUnitTestCount;
	///<summary>Specifies the maximum number of unit tests that can be run at any given time</summary>
	public byte MaxUnitTestCount;
	///<summary>Whether or not to cap active unit tests, based on memory usage</summary>
	public bool bCapUnitTestMemory;
	///<summary>When total physical memory usage, as a percentage, reaches this limit, no new unit tests can be started</summary>
	public byte MaxMemoryPercent;
	///<summary>As above, but when reaching this limit, recently started unit test(s) will be terminated/re-queued, to get back within limits</summary>
	public byte AutoCloseMemoryPercent;
	///<summary>Limits the number of auto-aborts a particular unit test will allow, before it is no longer accepted for re-queueing</summary>
	public byte MaxAutoCloseCount;
	///<summary>The number of recorded sessions where UE has run unit tests (max one per each run of the UE process)</summary>
	public uint UnitTestSessionCount;
	///<summary>Holds a list of unit tests pending execution</summary>
	public TArray<UClass> PendingUnitTests;
	///<summary>Holds a list of currently active unit tests</summary>
	public TArray<UUnitTest> ActiveUnitTests;
	///<summary>Unit tests which are finished, and are kept around until printing the final summary</summary>
	public TArray<UUnitTest> FinishedUnitTests;
}
