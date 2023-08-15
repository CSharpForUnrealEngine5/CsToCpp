namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Custom property node that you&#39;d like to expand pin by reflecting internal instance (we call TargetInstance here)</summary>
[CppInclude("Animation/AnimNode_CustomProperty.h")]
public partial struct FAnimNode_CustomProperty {
	public TArray<FName> SourcePropertyNames;
	public TArray<FName> DestPropertyNames;
	public UObject TargetInstance;
	public UObject SourceInstance;
}
