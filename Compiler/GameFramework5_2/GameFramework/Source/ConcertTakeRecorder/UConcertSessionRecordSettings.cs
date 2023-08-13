namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertTakeRecorderMessages.h")]
public partial class UConcertSessionRecordSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>LocalSettings</summary>
	public FTakeRecordSettings LocalSettings;
	///<summary>RemoteSettings</summary>
	public TArray<FConcertClientRecordSetting> RemoteSettings;
}
