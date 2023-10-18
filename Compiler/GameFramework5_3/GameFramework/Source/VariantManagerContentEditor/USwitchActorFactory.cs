namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The only purpose of this class is to trigger a slightly different code path within</summary>
[CppInclude("SwitchActorFactory.h")]
public partial class USwitchActorFactory : UActorFactory {
	public static UClass StaticClass() {return default;}
}
