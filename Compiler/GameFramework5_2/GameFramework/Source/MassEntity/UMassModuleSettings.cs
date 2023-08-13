namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A common parrent for Mass&#39;s per-module settings. Classes extending this class will automatically get registered</summary>
[CppInclude("MassSettings.h")]
public partial class UMassModuleSettings : UObject {
	public static UClass StaticClass() {return default;}
}
