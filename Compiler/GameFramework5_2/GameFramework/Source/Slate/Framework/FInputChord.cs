#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Framework/Commands/InputChord.h")]
///<summary>An Input Chord is a key and the modifier keys that are to be held with it.</summary>
public partial struct FInputChord {
// InputChord
	public FKey Key;
	public bool bShift;
	public bool bCtrl;
	public bool bAlt;
	public bool bCmd;
}
