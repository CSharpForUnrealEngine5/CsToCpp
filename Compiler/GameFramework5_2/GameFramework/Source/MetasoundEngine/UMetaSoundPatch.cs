#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Metasound.h")]
///<summary>This asset type is used for Metasound assets that can only be used as nodes in other Metasound graphs.</summary>
public partial class UMetaSoundPatch : UObject {
// MetaSoundPatch
	public FMetasoundFrontendDocument RootMetaSoundDocument;
	public TSet<string> ReferencedAssetClassKeys;
	public TSet<UObject> ReferencedAssetClassObjects;
	public TSet<FSoftObjectPath> ReferenceAssetClassCache;
	public UMetasoundEditorGraphBase Graph;
	public FGuid AssetClassID;
	public string RegistryInputTypes;
	public string RegistryOutputTypes;
	public int RegistryVersionMajor;
	public int RegistryVersionMinor;
	public bool bIsPreset;
}
