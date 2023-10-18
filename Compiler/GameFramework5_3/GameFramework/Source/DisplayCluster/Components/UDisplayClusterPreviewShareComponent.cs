namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>nDisplay Viewport preview share component</summary>
[CppInclude("Components/DisplayClusterPreviewShareComponent.h")]
public partial class UDisplayClusterPreviewShareComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Sets the sharing mode</summary>
	public void SetMode(EDisplayClusterPreviewShareMode NewMode) {}
	///<summary>Sets the unique name, which should match between sender and receiver of viewport textures</summary>
	public void SetUniqueName(string NewUniqueName) {}
	///<summary>Current sharing mode of this component</summary>
	public EDisplayClusterPreviewShareMode Mode;
	///<summary>Current unique name of this component, which should match between sender and receiver of viewport textures</summary>
	public string UniqueName;
	///<summary>The source nDisplay actor to pull the preview from</summary>
	public TSoftObjectPtr<ADisplayClusterRootActor> SourceNDisplayActor;
	///<summary>Type of Icvfx camera sync to be performed between the Source nDisplay actor and the owner of this component</summary>
	public EDisplayClusterPreviewShareIcvfxSync IcvfxCamerasSyncType;
	///<summary>Media Outputs associated with the given viewport unique names</summary>
	public TMap<string,UMediaOutput> MediaOutputs;
	///<summary>Media Captures associated with the given viewport unique names</summary>
	public TMap<string,UMediaCapture> MediaCaptures;
	///<summary>Media Sources associated with the given viewport unique names</summary>
	public TMap<string,UMediaSource> MediaSources;
	///<summary>Media Players associated with the given viewport unique names</summary>
	public TMap<string,UMediaPlayer> MediaPlayers;
	///<summary>Media Textures associated with the given viewport unique names</summary>
	public TMap<string,UMediaTexture> MediaTextures;
	///<summary>Cache of original Texture Replace Source Textures associated with the given viewport unique names. Used when restoring the original state</summary>
	public TMap<string,UTexture> OriginalSourceTextures;
	///<summary>Cache of original Texture Replace enable boolean associated with the given viewport unique names. Used when restoring the original state</summary>
	public TMap<string,bool> OriginalTextureReplaces;
}
