namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Direct base class for all UE objects</summary>
[CppInclude("UObject/NoExportTypes.h")]
public partial class UObject  {
	public static UClass StaticClass() {return default;}
	///<summary>Executes some portion of the ubergraph.</summary>
	public void ExecuteUbergraph(int EntryPoint) {}
}
