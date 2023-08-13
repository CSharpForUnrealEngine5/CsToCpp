namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayTaskResource.h")]
public partial class UGameplayTaskResource : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Overrides AutoResourceID. -1 means auto ID will be applied</summary>
	public int ManualResourceID;
	///<summary>AutoResourceID</summary>
	public short AutoResourceID;
	///<summary>bManuallySetID</summary>
	public bool bManuallySetID;
}
