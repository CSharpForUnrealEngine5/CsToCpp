#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GenlockedTimecodeProvider.h")]
///<summary>This timecode provider base class will try to use the engine genlock sync to adjust its count.</summary>
public partial class UGenlockedTimecodeProvider : UTimecodeProvider {
// GenlockedTimecodeProvider
	public bool bUseGenlockToCount;
}
