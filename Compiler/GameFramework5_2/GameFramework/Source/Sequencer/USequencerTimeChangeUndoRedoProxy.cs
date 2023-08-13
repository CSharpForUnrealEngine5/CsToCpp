namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SequencerTimeChangeUndoRedoProxy.h")]
public partial class USequencerTimeChangeUndoRedoProxy : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Time</summary>
	public FQualifiedFrameTime Time;
	///<summary>no TOptional UPROPERTY so use this instead</summary>
	public bool bTimeWasSet;
}
