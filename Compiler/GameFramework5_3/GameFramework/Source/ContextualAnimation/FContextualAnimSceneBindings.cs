namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContextualAnimTypes.h")]
public partial struct FContextualAnimSceneBindings {
	public byte Id;
	public UContextualAnimSceneAsset SceneAsset;
	public int SectionIdx;
	public int AnimSetIdx;
	public TArray<FContextualAnimSceneBinding> Data;
}
