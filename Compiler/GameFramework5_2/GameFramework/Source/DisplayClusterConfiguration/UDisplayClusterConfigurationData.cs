#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>/</summary>
[CppInclude("DisplayClusterConfigurationTypes.h")]
public partial class UDisplayClusterConfigurationData : UDisplayClusterConfigurationData_Base {
	///<summary>Viewports API</summary>
	public  UDisplayClusterConfigurationViewport GetViewport(string NodeId,string ViewportId) { return default; }
	///<summary>Update\Create node postprocess</summary>
	public  bool AssignPostprocess(string NodeId,string PostprocessId,string Type,TMap<string,string> Parameters,int Order/*=-1*/) { return default; }
	///<summary>RemovePostprocess</summary>
	public  bool RemovePostprocess(string NodeId,string PostprocessId) { return default; }
	///<summary>GetPostprocess</summary>
	public  bool GetPostprocess(string NodeId,string PostprocessId,FDisplayClusterConfigurationPostprocess OutPostprocess) { return default; }
	///<summary>GetProjectionPolicy</summary>
	public  bool GetProjectionPolicy(string NodeId,string ViewportId,FDisplayClusterConfigurationProjection OutProjection) { return default; }
	///<summary>Return all references to meshes from policy, and other</summary>
	public  void GetReferencedMeshNames(TArray<string> OutMeshNames) {}
	///<summary>Info</summary>
	public FDisplayClusterConfigurationInfo Info;
	///<summary>Scene</summary>
	public UDisplayClusterConfigurationScene Scene;
	///<summary>Cluster</summary>
	public UDisplayClusterConfigurationCluster Cluster;
	///<summary>CustomParameters</summary>
	public TMap<string,string> CustomParameters;
	///<summary>Diagnostics</summary>
	public FDisplayClusterConfigurationDiagnostics Diagnostics;
	///<summary>RenderFrameSettings</summary>
	public FDisplayClusterConfigurationRenderFrame RenderFrameSettings;
	///<summary>StageSettings</summary>
	public FDisplayClusterConfigurationICVFX_StageSettings StageSettings;
	///<summary>bFollowLocalPlayerCamera</summary>
	public bool bFollowLocalPlayerCamera;
	///<summary>bExitOnEsc</summary>
	public bool bExitOnEsc;
	///<summary>bOverrideViewportsFromExternalConfig</summary>
	public bool bOverrideViewportsFromExternalConfig;
	///<summary>MediaSettings</summary>
	public FDisplayClusterConfigurationGlobalMediaSettings MediaSettings;
	///<summary>PathToConfig</summary>
	public string PathToConfig;
	///<summary>The path used when originally importing.</summary>
	public string ImportedPath;
	///<summary>DefaultFrameSizeRef</summary>
	public FDisplayClusterEditorPropertyReference DefaultFrameSizeRef;
}
