namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/ConcertTransportLogSettings.h")]
public partial class UConcertTransportLogSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>How to displayed FConcertLog::Timestamp</summary>
	public ETimeFormat TimestampTimeFormat;
}
