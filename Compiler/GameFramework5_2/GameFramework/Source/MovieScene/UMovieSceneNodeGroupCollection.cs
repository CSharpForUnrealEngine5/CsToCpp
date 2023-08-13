namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure that represents a collection of NodeGroups</summary>
[CppInclude("MovieScene.h")]
public partial class UMovieSceneNodeGroupCollection : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>NodeGroups</summary>
	public TArray<UMovieSceneNodeGroup> NodeGroups;
}
