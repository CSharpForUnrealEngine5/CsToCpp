#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsEngine/ConstraintInstance.h")]
///<summary>Wrapping type around instance pointer to be returned per value in Blueprints</summary>
public partial struct FConstraintInstanceAccessor {
// ConstraintInstanceAccessor
	public TWeakObjectPtr<UObject> Owner;
	public uint Index;
}
