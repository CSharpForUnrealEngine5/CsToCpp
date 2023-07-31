#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContextualAnimTypes.h")]
public partial struct FContextualAnimSceneBindings {
	public byte Id;
	public TWeakObjectPtr<UContextualAnimSceneAsset> SceneAsset;
	public int SectionIdx;
	public int AnimSetIdx;
	public TArray<FContextualAnimSceneBinding> Data;
	public TWeakObjectPtr<UContextualAnimSceneInstance> SceneInstancePtr;
}
