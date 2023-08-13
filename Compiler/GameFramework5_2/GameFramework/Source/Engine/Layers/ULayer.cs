namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Layers/Layer.h")]
public partial class ULayer : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The display name of the layer</summary>
	public string LayerName;
	///<summary>Whether actors associated with the layer are visible in the viewport</summary>
	public bool bIsVisible;
	///<summary>Basic stats regarding the number of Actors and their types currently assigned to the Layer</summary>
	public TArray<FLayerActorStats> ActorStats;
}
