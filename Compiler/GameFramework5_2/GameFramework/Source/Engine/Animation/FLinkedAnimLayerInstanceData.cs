#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Linked layer instance info</summary>
[CppInclude("Animation/AnimSubsystem_SharedLinkedAnimLayers.h")]
public partial struct FLinkedAnimLayerInstanceData {
	public UAnimInstance Instance;
	public TMap<string,TWeakObjectPtr<UAnimInstance>> LinkedFunctions;
}
