#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An automatically created global object that will manage all widget animations.</summary>
[CppInclude("Animation/UMGSequenceTickManager.h")]
public partial class UUMGSequenceTickManager : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>WeakUserWidgetData</summary>
	public TMap<TWeakObjectPtr<UUserWidget>,FSequenceTickManagerWidgetData> WeakUserWidgetData;
	///<summary>Linker</summary>
	public UMovieSceneEntitySystemLinker Linker;
}
