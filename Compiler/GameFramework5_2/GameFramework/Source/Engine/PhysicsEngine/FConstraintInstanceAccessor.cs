namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Wrapping type around instance pointer to be returned per value in Blueprints</summary>
[CppInclude("PhysicsEngine/ConstraintInstance.h")]
public partial struct FConstraintInstanceAccessor {
	public TWeakObjectPtr<UObject> Owner;
	public uint Index;
}
