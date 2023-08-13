namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The significance manager provides a framework for registering objects by tag to each have a significance</summary>
[CppInclude("SignificanceManager.h")]
public partial class USignificanceManager : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Game specific significance class to instantiate</summary>
	public FSoftClassPath SignificanceManagerClassName;
}
