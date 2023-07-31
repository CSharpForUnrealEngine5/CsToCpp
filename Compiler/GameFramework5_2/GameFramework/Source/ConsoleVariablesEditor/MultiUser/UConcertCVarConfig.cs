#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MultiUser/ConsoleVariableSyncData.h")]
public partial class UConcertCVarConfig : UObject {
	///<summary>LocalSettings</summary>
	public FConcertCVarSettings LocalSettings;
	///<summary>RemoteDetails</summary>
	public TArray<FConcertCVarDetails> RemoteDetails;
}
