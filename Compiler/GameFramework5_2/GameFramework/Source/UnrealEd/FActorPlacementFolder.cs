namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldFolders.h")]
public partial struct FActorPlacementFolder {
	public FName Path;
	public TWeakObjectPtr<UObject> RootObjectPtr;
	public FGuid ActorFolderGuid;
}
