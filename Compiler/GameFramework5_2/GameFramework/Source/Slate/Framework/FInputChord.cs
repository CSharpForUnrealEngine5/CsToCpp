namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An Input Chord is a key and the modifier keys that are to be held with it.</summary>
[CppInclude("Framework/Commands/InputChord.h")]
public partial struct FInputChord {
	public FKey Key;
	public bool bShift;
	public bool bCtrl;
	public bool bAlt;
	public bool bCmd;
}
