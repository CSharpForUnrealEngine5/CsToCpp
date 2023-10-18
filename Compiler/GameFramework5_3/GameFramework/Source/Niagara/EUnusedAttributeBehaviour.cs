namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraScript.h")]
///<summary>Defines what will happen to unused attributes when a script is run.</summary>
public enum EUnusedAttributeBehaviour {
	Copy=0,
	Zero=1,
	None=2,
	MarkInvalid=3,
	PassThrough=4,
}
