#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MultiUser/ConsoleVariableSyncData.h")]
public partial class UConcertCVarConfig : UObject {
// ConcertCVarConfig
	public FConcertCVarSettings LocalSettings;
	public TArray<FConcertCVarDetails> RemoteDetails;
}
