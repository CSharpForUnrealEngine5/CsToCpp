namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data for shared linked anim instances module</summary>
[CppInclude("Animation/AnimSubsystem_SharedLinkedAnimLayers.h")]
public partial struct FAnimSubsystem_SharedLinkedAnimLayers {
	public TArray<FLinkedAnimLayerClassData> ClassesData;
	public TArray<UClass> PersistentClasses;
}
