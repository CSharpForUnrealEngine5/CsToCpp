namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldFolders.h")]
public partial struct FActorPlacementFolder {
	public string Path;
	public TWeakObjectPtr<UObject> RootObjectPtr;
	public FGuid ActorFolderGuid;
}
