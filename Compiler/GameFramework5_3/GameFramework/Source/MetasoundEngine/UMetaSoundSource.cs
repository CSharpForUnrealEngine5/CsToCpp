namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This Metasound type can be played as an audio source.</summary>
[CppInclude("MetasoundSource.h")]
public partial class UMetaSoundSource : USoundWaveProcedural {
	public static UClass StaticClass() {return default;}
	///<summary>RootMetasoundDocument</summary>
	public FMetasoundFrontendDocument RootMetasoundDocument;
	///<summary>ReferencedAssetClassKeys</summary>
	public TSet<string> ReferencedAssetClassKeys;
	///<summary>ReferencedAssetClassObjects</summary>
	public TSet<UObject> ReferencedAssetClassObjects;
	///<summary>ReferenceAssetClassCache</summary>
	public TSet<FSoftObjectPath> ReferenceAssetClassCache;
	///<summary>Graph</summary>
	public UMetasoundEditorGraphBase Graph;
	///<summary>The output audio format of the metasound source.</summary>
	public EMetaSoundOutputAudioFormat OutputFormat;
	///<summary>AssetClassID</summary>
	public FGuid AssetClassID;
	///<summary>RegistryInputTypes</summary>
	public string RegistryInputTypes;
	///<summary>RegistryOutputTypes</summary>
	public string RegistryOutputTypes;
	///<summary>RegistryVersionMajor</summary>
	public int RegistryVersionMajor;
	///<summary>RegistryVersionMinor</summary>
	public int RegistryVersionMinor;
	///<summary>bIsPreset</summary>
	public bool bIsPreset;
}
