namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/PreviewMeshCollectionFactory.h")]
public partial class UPreviewMeshCollectionFactory : UFactory {
	public static UClass StaticClass() {return default;}
	///<summary>The current skeleton we are creating collections for</summary>
	public TWeakObjectPtr<USkeleton> CurrentSkeleton;
}
