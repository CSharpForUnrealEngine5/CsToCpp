namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/WorldPartition.h")]
public partial class UWorldPartition : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>EditorHash</summary>
	public UWorldPartitionEditorHash EditorHash;
	///<summary>Class of WorldPartitionStreamingPolicy to be used to manage world partition streaming.</summary>
	public UClass WorldPartitionStreamingPolicyClass;
	///<summary>Used to know if it&#39;s the first time streaming is enabled on this world.</summary>
	public bool bStreamingWasEnabled;
	///<summary>ActorDescContainer</summary>
	public UActorDescContainer ActorDescContainer;
	///<summary>RuntimeHash</summary>
	public UWorldPartitionRuntimeHash RuntimeHash;
	///<summary>Enables streaming for this world.</summary>
	public bool bEnableStreaming;
	///<summary>ServerStreamingMode</summary>
	public EWorldPartitionServerStreamingMode ServerStreamingMode;
	///<summary>ServerStreamingOutMode</summary>
	public EWorldPartitionServerStreamingOutMode ServerStreamingOutMode;
	///<summary>Default HLOD layer</summary>
	public UHLODLayer DefaultHLODLayer;
	///<summary>DataLayerManager</summary>
	public UDataLayerManager DataLayerManager;
	///<summary>StreamingPolicy</summary>
	public UWorldPartitionStreamingPolicy StreamingPolicy;
	///<summary>RegisteredEditorLoaderAdapters</summary>
	public TSet<UWorldPartitionEditorLoaderAdapter> RegisteredEditorLoaderAdapters;
}
