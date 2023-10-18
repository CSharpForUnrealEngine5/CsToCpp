namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Linked layer instance info</summary>
[CppInclude("Animation/AnimSubsystem_SharedLinkedAnimLayers.h")]
public partial struct FLinkedAnimLayerInstanceData {
	public UAnimInstance Instance;
	public TMap<FName,TWeakObjectPtr<UAnimInstance>> LinkedFunctions;
}
