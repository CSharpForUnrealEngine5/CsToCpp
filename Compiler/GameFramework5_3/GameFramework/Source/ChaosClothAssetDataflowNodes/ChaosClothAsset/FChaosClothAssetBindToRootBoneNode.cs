namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Bind an entire mesh to the single root bone of the current skeleton set on the cloth collection.</summary>
[CppInclude("ChaosClothAsset/BindToRootBoneNode.h")]
public partial struct FChaosClothAssetBindToRootBoneNode {
	public FManagedArrayCollection Collection;
	public bool bBindSimMesh;
	public bool bBindRenderMesh;
}
