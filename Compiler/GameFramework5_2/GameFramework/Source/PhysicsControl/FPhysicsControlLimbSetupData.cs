#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Setup data that is used to create the representation of a single limb. A limb is an array of</summary>
[CppInclude("PhysicsControlLimbData.h")]
public partial struct FPhysicsControlLimbSetupData {
	public string LimbName;
	public string StartBone;
	public bool bIncludeParentBone;
}
