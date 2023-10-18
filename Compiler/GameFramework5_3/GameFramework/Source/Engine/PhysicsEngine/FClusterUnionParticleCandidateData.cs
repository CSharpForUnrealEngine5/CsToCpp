namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>For every possible particle that could ever possibly be added into the cluster union,</summary>
[CppInclude("PhysicsEngine/ClusterUnionComponent.h")]
public partial struct FClusterUnionParticleCandidateData {
	public TWeakObjectPtr<UPrimitiveComponent> Component;
	public int BoneId;
}
