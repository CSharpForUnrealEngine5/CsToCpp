namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MultiUser/ConsoleVariableSyncData.h")]
public partial class UConcertCVarConfig : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>LocalSettings</summary>
	public FConcertCVarSettings LocalSettings;
	///<summary>RemoteDetails</summary>
	public TArray<FConcertCVarDetails> RemoteDetails;
}
