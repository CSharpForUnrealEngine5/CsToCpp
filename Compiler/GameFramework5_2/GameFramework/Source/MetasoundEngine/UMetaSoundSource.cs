#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MetasoundSource.h")]
///<summary>This Metasound type can be played as an audio source.</summary>
public partial class UMetaSoundSource : USoundWaveProcedural {
// MetaSoundSource
	public FMetasoundFrontendDocument RootMetasoundDocument;
	public TSet<string> ReferencedAssetClassKeys;
	public TSet<UObject> ReferencedAssetClassObjects;
	public TSet<FSoftObjectPath> ReferenceAssetClassCache;
	public UMetasoundEditorGraphBase Graph;
	public EMetasoundSourceAudioFormat OutputFormat;
	public FGuid AssetClassID;
	public string RegistryInputTypes;
	public string RegistryOutputTypes;
	public int RegistryVersionMajor;
	public int RegistryVersionMinor;
	public bool bIsPreset;
}
