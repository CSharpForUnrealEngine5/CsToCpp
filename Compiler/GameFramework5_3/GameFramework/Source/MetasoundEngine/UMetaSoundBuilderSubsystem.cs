namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The subsystem in charge of tracking MetaSound builders</summary>
[CppInclude("MetasoundBuilderSubsystem.h")]
public partial class UMetaSoundBuilderSubsystem : UEngineSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>NamedBuilders</summary>
	public TMap<FName,UMetaSoundBuilderBase> NamedBuilders;
	///<summary>AssetBuilders</summary>
	public TMap<FName,TWeakObjectPtr<UMetaSoundBuilderBase>> AssetBuilders;
	///<summary>CreatePatchBuilder</summary>
	public UMetaSoundPatchBuilder CreatePatchBuilder(FName BuilderName,EMetaSoundBuilderResult OutResult) { return default; }
	///<summary>CreateSourceBuilder</summary>
	public UMetaSoundSourceBuilder CreateSourceBuilder(FName BuilderName,FMetaSoundBuilderNodeOutputHandle OnPlayNodeOutput,FMetaSoundBuilderNodeInputHandle OnFinishedNodeInput,TArray<FMetaSoundBuilderNodeInputHandle> AudioOutNodeInputs,EMetaSoundBuilderResult OutResult,EMetaSoundOutputAudioFormat OutputFormat/*=EMetaSoundOutputAudioFormat.Mono*/,bool bIsOneShot/*=true*/) { return default; }
	///<summary>CreatePatchPresetBuilder</summary>
	public UMetaSoundPatchBuilder CreatePatchPresetBuilder(FName BuilderName,object /*ReferencedPatchClass*/ ReferencedPatchClass,EMetaSoundBuilderResult OutResult) { return default; }
	///<summary>CreateSourcePresetBuilder</summary>
	public UMetaSoundSourceBuilder CreateSourcePresetBuilder(FName BuilderName,object /*ReferencedSourceClass*/ ReferencedSourceClass,EMetaSoundBuilderResult OutResult) { return default; }
	///<summary>CreateBoolMetaSoundLiteral</summary>
	public FMetasoundFrontendLiteral CreateBoolMetaSoundLiteral(bool Value,FName DataType) { return default; }
	///<summary>CreateBoolArrayMetaSoundLiteral</summary>
	public FMetasoundFrontendLiteral CreateBoolArrayMetaSoundLiteral(TArray<bool> Value,FName DataType) { return default; }
	///<summary>CreateFloatMetaSoundLiteral</summary>
	public FMetasoundFrontendLiteral CreateFloatMetaSoundLiteral(float Value,FName DataType) { return default; }
	///<summary>CreateFloatArrayMetaSoundLiteral</summary>
	public FMetasoundFrontendLiteral CreateFloatArrayMetaSoundLiteral(TArray<float> Value,FName DataType) { return default; }
	///<summary>CreateIntMetaSoundLiteral</summary>
	public FMetasoundFrontendLiteral CreateIntMetaSoundLiteral(int Value,FName DataType) { return default; }
	///<summary>CreateIntArrayMetaSoundLiteral</summary>
	public FMetasoundFrontendLiteral CreateIntArrayMetaSoundLiteral(TArray<int> Value,FName DataType) { return default; }
	///<summary>CreateObjectMetaSoundLiteral</summary>
	public FMetasoundFrontendLiteral CreateObjectMetaSoundLiteral(UObject Value) { return default; }
	///<summary>CreateObjectArrayMetaSoundLiteral</summary>
	public FMetasoundFrontendLiteral CreateObjectArrayMetaSoundLiteral(TArray<UObject> Value) { return default; }
	///<summary>CreateStringMetaSoundLiteral</summary>
	public FMetasoundFrontendLiteral CreateStringMetaSoundLiteral(string Value,FName DataType) { return default; }
	///<summary>CreateStringArrayMetaSoundLiteral</summary>
	public FMetasoundFrontendLiteral CreateStringArrayMetaSoundLiteral(TArray<string> Value,FName DataType) { return default; }
	///<summary>CreateMetaSoundLiteralFromParam</summary>
	public FMetasoundFrontendLiteral CreateMetaSoundLiteralFromParam(FAudioParameter Param) { return default; }
	///<summary>FindBuilder</summary>
	public UMetaSoundBuilderBase FindBuilder(FName BuilderName) { return default; }
	///<summary>FindPatchBuilder</summary>
	public UMetaSoundPatchBuilder FindPatchBuilder(FName BuilderName) { return default; }
	///<summary>FindSourceBuilder</summary>
	public UMetaSoundSourceBuilder FindSourceBuilder(FName BuilderName) { return default; }
	///<summary>IsInterfaceRegistered</summary>
	public bool IsInterfaceRegistered(FName InInterfaceName) { return default; }
	///<summary>Adds builder to subsystem&#39;s registry to make it persistent and easily accessible by multiple systems or Blueprints</summary>
	public void RegisterBuilder(FName BuilderName,UMetaSoundBuilderBase Builder) {}
	///<summary>Adds builder to subsystem&#39;s registry to make it persistent and easily accessible by multiple systems or Blueprints</summary>
	public void RegisterPatchBuilder(FName BuilderName,UMetaSoundPatchBuilder Builder) {}
	///<summary>Adds builder to subsystem&#39;s registry to make it persistent and easily accessible by multiple systems or Blueprints</summary>
	public void RegisterSourceBuilder(FName BuilderName,UMetaSoundSourceBuilder Builder) {}
	///<summary>UnregisterBuilder</summary>
	public bool UnregisterBuilder(FName BuilderName) { return default; }
	///<summary>UnregisterPatchBuilder</summary>
	public bool UnregisterPatchBuilder(FName BuilderName) { return default; }
	///<summary>UnregisterSourceBuilder</summary>
	public bool UnregisterSourceBuilder(FName BuilderName) { return default; }
}
