#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This asset type is used for Metasound assets that can only be used as nodes in other Metasound graphs.</summary>
[CppInclude("Metasound.h")]
public partial class UMetaSoundPatch : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>RootMetaSoundDocument</summary>
	public FMetasoundFrontendDocument RootMetaSoundDocument;
	///<summary>ReferencedAssetClassKeys</summary>
	public TSet<string> ReferencedAssetClassKeys;
	///<summary>ReferencedAssetClassObjects</summary>
	public TSet<UObject> ReferencedAssetClassObjects;
	///<summary>ReferenceAssetClassCache</summary>
	public TSet<FSoftObjectPath> ReferenceAssetClassCache;
	///<summary>Graph</summary>
	public UMetasoundEditorGraphBase Graph;
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
