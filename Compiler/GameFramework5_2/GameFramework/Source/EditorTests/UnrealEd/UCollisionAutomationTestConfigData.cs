#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UnrealEd/CollisionAutomationTests.h")]
public partial class UCollisionAutomationTestConfigData : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>ComponentSweepMultiTests</summary>
	public TArray<FCollisionTestEntry> ComponentSweepMultiTests;
	///<summary>LineTraceSingleByChannelTests</summary>
	public TArray<FCollisionTestEntry> LineTraceSingleByChannelTests;
	///<summary>LineTracePerformanceTests</summary>
	public TArray<FCollisionPerfTest> LineTracePerformanceTests;
}
