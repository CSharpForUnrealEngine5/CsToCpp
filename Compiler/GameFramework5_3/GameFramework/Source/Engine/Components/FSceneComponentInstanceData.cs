namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Component instance cached data base class for scene components.</summary>
[CppInclude("Components/SceneComponent.h")]
public partial struct FSceneComponentInstanceData {
	public TMap<USceneComponent,FTransform> AttachedInstanceComponents;
}
