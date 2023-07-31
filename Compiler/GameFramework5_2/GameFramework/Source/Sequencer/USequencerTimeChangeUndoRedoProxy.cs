#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SequencerTimeChangeUndoRedoProxy.h")]
public partial class USequencerTimeChangeUndoRedoProxy : UObject {
	///<summary>Time</summary>
	public FQualifiedFrameTime Time;
	///<summary>no TOptional UPROPERTY so use this instead</summary>
	public bool bTimeWasSet;
}
