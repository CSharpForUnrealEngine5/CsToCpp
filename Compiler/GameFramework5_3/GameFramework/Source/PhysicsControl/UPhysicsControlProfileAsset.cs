namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Asset for storing Physics Control Profiles. These will contain data that define:</summary>
[CppInclude("PhysicsControlProfileAsset.h")]
public partial class UPhysicsControlProfileAsset : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Placeholder for testing/developing</summary>
	public void Log() {}
	///<summary>The skeletal mesh to use for generating controls and previewing. If it turns out this</summary>
	public TSoftObjectPtr<USkeletalMesh> PreviewSkeletalMesh;
	///<summary>Placeholder for testing/developing</summary>
	public float TestValue;
}
