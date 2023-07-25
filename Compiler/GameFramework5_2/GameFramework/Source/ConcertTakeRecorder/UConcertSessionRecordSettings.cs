#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertTakeRecorderMessages.h")]
public partial class UConcertSessionRecordSettings : UObject {
// ConcertSessionRecordSettings
	public FTakeRecordSettings LocalSettings;
	public TArray<FConcertClientRecordSetting> RemoteSettings;
}
