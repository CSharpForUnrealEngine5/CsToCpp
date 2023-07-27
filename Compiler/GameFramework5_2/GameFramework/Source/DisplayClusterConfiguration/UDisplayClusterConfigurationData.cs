#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DisplayClusterConfigurationTypes.h")]
///<summary>/</summary>
public partial class UDisplayClusterConfigurationData : UDisplayClusterConfigurationData_Base {
// DisplayClusterConfigurationData
	public  UDisplayClusterConfigurationViewport GetViewport(string NodeId,string ViewportId) { return default; }
	public  bool AssignPostprocess(string NodeId,string PostprocessId,string Type,TMap<string,string> Parameters,int Order/*=-1*/) { return default; }
	public  bool RemovePostprocess(string NodeId,string PostprocessId) { return default; }
	public  bool GetPostprocess(string NodeId,string PostprocessId,FDisplayClusterConfigurationPostprocess OutPostprocess) { return default; }
	public  bool GetProjectionPolicy(string NodeId,string ViewportId,FDisplayClusterConfigurationProjection OutProjection) { return default; }
	public  void GetReferencedMeshNames(TArray<string> OutMeshNames) {}
	public FDisplayClusterConfigurationInfo Info;
	public UDisplayClusterConfigurationScene Scene;
	public UDisplayClusterConfigurationCluster Cluster;
	public TMap<string,string> CustomParameters;
	public FDisplayClusterConfigurationDiagnostics Diagnostics;
	public FDisplayClusterConfigurationRenderFrame RenderFrameSettings;
	public FDisplayClusterConfigurationICVFX_StageSettings StageSettings;
	public bool bFollowLocalPlayerCamera;
	public bool bExitOnEsc;
	public bool bOverrideViewportsFromExternalConfig;
	public FDisplayClusterConfigurationGlobalMediaSettings MediaSettings;
	public string PathToConfig;
	public string ImportedPath;
	public FDisplayClusterEditorPropertyReference DefaultFrameSizeRef;
}
