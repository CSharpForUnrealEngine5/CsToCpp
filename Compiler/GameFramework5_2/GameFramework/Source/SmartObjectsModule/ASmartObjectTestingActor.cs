#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Debug actor to test SmartObjects.</summary>
[CppInclude("SmartObjectTestingActor.h")]
public partial class ASmartObjectTestingActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>Can be used in Editor world to initialize SmartObject runtime with running the simulation</summary>
	public  void DebugInitializeSubsystemRuntime() {}
	///<summary>Can be used in Editor world to cleanup SmartObject runtime after using debug initialization</summary>
	public  void DebugCleanupSubsystemRuntime() {}
	///<summary>RunTests</summary>
	public  void RunTests() {}
	///<summary>ResetTests</summary>
	public  void ResetTests() {}
	///<summary>Tests</summary>
	public TArray<USmartObjectTest> Tests;
	///<summary>RenderingComponent</summary>
	public USmartObjectTestRenderingComponent RenderingComponent;
	///<summary>SmartObjectSubsystem</summary>
	public USmartObjectSubsystem SmartObjectSubsystem;
	///<summary>bRunTestsEachFrame</summary>
	public bool bRunTestsEachFrame;
}
