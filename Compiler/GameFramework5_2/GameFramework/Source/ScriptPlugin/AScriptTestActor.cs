#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ScriptTestActor.h")]
///<summary>Test Actor. To be removed at some point.</summary>
public partial class AScriptTestActor : AActor {
// ScriptTestActor
	public string TestString;
	public float TestValue;
	public bool TestBool;
	public float TestFunction(float InValue,float InFactor,bool bMultiply) { return default; }
}
