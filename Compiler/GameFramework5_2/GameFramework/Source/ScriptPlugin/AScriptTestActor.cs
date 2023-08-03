#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Test Actor. To be removed at some point.</summary>
[CppInclude("ScriptTestActor.h")]
public partial class AScriptTestActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>TestString</summary>
	public string TestString;
	///<summary>TestValue</summary>
	public float TestValue;
	///<summary>TestBool</summary>
	public bool TestBool;
	///<summary>TestFunction</summary>
	public  float TestFunction(float InValue,float InFactor,bool bMultiply) { return default; }
}
