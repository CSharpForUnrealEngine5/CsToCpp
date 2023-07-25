#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/UMGSequenceTickManager.h")]
///<summary>An automatically created global object that will manage all widget animations.</summary>
public partial class UUMGSequenceTickManager : UObject {
// UMGSequenceTickManager
	public TMap<TWeakObjectPtr<UUserWidget>,FSequenceTickManagerWidgetData> WeakUserWidgetData;
	public UMovieSceneEntitySystemLinker Linker;
}
