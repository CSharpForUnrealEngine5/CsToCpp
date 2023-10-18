namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Tests an RPC crash caused by empty FText&#39;s, as reported on the UDN here:</summary>
[CppInclude("UnitTests/FTextCrash.h")]
public partial class UFTextCrash : UClientUnitTest {
	public static UClass StaticClass() {return default;}
}
