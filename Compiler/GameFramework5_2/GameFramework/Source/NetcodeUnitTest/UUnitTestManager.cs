#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UnitTestManager.h")]
///<summary>Manages centralized execution and tracking of unit tests, as well as handling console commands,</summary>
public partial class UUnitTestManager : UObject {
// UnitTestManager
	public bool bCapUnitTestCount;
	public byte MaxUnitTestCount;
	public bool bCapUnitTestMemory;
	public byte MaxMemoryPercent;
	public byte AutoCloseMemoryPercent;
	public byte MaxAutoCloseCount;
	public uint UnitTestSessionCount;
	public TArray<UClass> PendingUnitTests;
	public TArray<UUnitTest> ActiveUnitTests;
	public TArray<UUnitTest> FinishedUnitTests;
}
