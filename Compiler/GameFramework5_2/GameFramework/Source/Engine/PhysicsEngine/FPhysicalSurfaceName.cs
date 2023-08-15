namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure that represents the name of physical surfaces.</summary>
[CppInclude("PhysicsEngine/PhysicsSettings.h")]
public partial struct FPhysicalSurfaceName {
	public EPhysicalSurface Type;
	public FName Name;
}
