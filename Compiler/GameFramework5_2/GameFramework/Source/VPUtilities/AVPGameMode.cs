namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VPGameMode.h")]
public partial class AVPGameMode : AGameMode {
	public static UClass StaticClass() {return default;}
	///<summary>RootActor</summary>
	public AVPRootActor RootActor;
	///<summary>GetRootActor</summary>
	public AVPRootActor GetRootActor() { return default; }
}
