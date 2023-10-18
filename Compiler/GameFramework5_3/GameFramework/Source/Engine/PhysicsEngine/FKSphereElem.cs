namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Sphere shape used for collision</summary>
[CppInclude("PhysicsEngine/SphereElem.h")]
public partial struct FKSphereElem {
	public FMatrix TM_DEPRECATED;
	public FVector Center;
	public float Radius;
}
