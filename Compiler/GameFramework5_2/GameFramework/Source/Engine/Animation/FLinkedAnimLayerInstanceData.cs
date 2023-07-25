#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimSubsystem_SharedLinkedAnimLayers.h")]
///<summary>Linked layer instance info</summary>
public partial struct FLinkedAnimLayerInstanceData {
// LinkedAnimLayerInstanceData
	public UAnimInstance Instance;
	public TMap<string,TWeakObjectPtr<UAnimInstance>> LinkedFunctions;
}
