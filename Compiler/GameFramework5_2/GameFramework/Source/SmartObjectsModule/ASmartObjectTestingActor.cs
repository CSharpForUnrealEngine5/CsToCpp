#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SmartObjectTestingActor.h")]
///<summary>Debug actor to test SmartObjects.</summary>
public partial class ASmartObjectTestingActor : AActor {
// SmartObjectTestingActor
	public void DebugInitializeSubsystemRuntime() {}
	public void DebugCleanupSubsystemRuntime() {}
	public void RunTests() {}
	public void ResetTests() {}
	public TArray<USmartObjectTest> Tests;
	public USmartObjectTestRenderingComponent RenderingComponent;
	public USmartObjectSubsystem SmartObjectSubsystem;
	public bool bRunTestsEachFrame;
}
