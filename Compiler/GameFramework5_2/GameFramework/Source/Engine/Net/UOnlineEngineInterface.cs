namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Interface class between engine and OnlineSubsystem to remove dependencies between the two</summary>
[CppInclude("Net/OnlineEngineInterface.h")]
public partial class UOnlineEngineInterface : UObject {
	public static UClass StaticClass() {return default;}
}
