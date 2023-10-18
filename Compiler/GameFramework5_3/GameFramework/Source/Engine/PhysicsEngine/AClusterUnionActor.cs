namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A lightweight actor that can be used to own a cluster union component.</summary>
[CppInclude("PhysicsEngine/ClusterUnionActor.h")]
public partial class AClusterUnionActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>GetClusterUnionComponent</summary>
	public UClusterUnionComponent GetClusterUnionComponent() { return default; }
	///<summary>The pivot used while building.</summary>
	public UClusterUnionComponent ClusterUnion;
}
