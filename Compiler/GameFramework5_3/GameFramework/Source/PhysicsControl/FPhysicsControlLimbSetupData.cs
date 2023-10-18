namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Setup data that is used to create the representation of a single limb. A limb is an array of</summary>
[CppInclude("PhysicsControlLimbData.h")]
public partial struct FPhysicsControlLimbSetupData {
	public FName LimbName;
	public FName StartBone;
	public bool bIncludeParentBone;
}
