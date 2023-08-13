namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UnitTask&#39;s are used to implement supporting code for UnitTest&#39;s, for handling complex behind-the-scenes setup prior to test execution</summary>
[CppInclude("UnitTask.h")]
public partial class UUnitTask : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The UnitTest that owns this task</summary>
	public UUnitTest Owner;
}
