namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosFlesh/ChaosDeformableTypes.h")]
public enum EDeformableExecutionModel {
	Chaos_Deformable_PrePhysics=0,
	Chaos_Deformable_DuringPhysics=1,
	Chaos_Deformable_PostPhysics=2,
	Chaos_Max=3,
}
