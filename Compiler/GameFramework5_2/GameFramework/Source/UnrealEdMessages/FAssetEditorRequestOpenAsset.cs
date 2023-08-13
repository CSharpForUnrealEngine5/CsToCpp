namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a message for opening an asset in the asset browser.</summary>
[CppInclude("AssetEditorMessages.h")]
public partial struct FAssetEditorRequestOpenAsset {
	public string AssetName;
}
