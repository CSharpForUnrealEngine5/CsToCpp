namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Override this class in order to make an additional track filter available in Sequencer</summary>
[CppInclude("SequencerTrackFilterExtension.h")]
public partial class USequencerTrackFilterExtension : UObject {
	public static UClass StaticClass() {return default;}
}
