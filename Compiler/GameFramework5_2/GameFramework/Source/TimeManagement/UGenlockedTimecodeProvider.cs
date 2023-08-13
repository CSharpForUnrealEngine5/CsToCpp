namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This timecode provider base class will try to use the engine genlock sync to adjust its count.</summary>
[CppInclude("GenlockedTimecodeProvider.h")]
public partial class UGenlockedTimecodeProvider : UTimecodeProvider {
	public static UClass StaticClass() {return default;}
	///<summary>Use Genlock Sync to update Timecode count</summary>
	public bool bUseGenlockToCount;
}
