#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UnrealEd/CollisionAutomationTests.h")]
public partial class UCollisionAutomationTestConfigData : UObject {
// CollisionAutomationTestConfigData
	public TArray<FCollisionTestEntry> ComponentSweepMultiTests;
	public TArray<FCollisionTestEntry> LineTraceSingleByChannelTests;
	public TArray<FCollisionPerfTest> LineTracePerformanceTests;
}
