#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Rigs/RigHierarchyController.h")]
public partial class URigHierarchyController : UObject {
	///<summary>Returns the hierarchy currently linked to this controller</summary>
	public  URigHierarchy GetHierarchy() { return default; }
	///<summary>Sets the hierarchy currently linked to this controller</summary>
	public  void SetHierarchy(URigHierarchy InHierarchy) {}
	///<summary>Selects or deselects an element in the hierarchy</summary>
	public  bool SelectElement(FRigElementKey InKey,bool bSelect/*=true*/,bool bClearSelection/*=false*/) { return default; }
	///<summary>Deselects or deselects an element in the hierarchy</summary>
	public  bool DeselectElement(FRigElementKey InKey) { return default; }
	///<summary>Sets the selection based on a list of keys</summary>
	public  bool SetSelection(TArray<FRigElementKey> InKeys,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Clears the selection</summary>
	public  bool ClearSelection() { return default; }
	///<summary>Adds a bone to the hierarchy</summary>
	public  FRigElementKey AddBone(string InName,FRigElementKey InParent,FTransform InTransform,bool bTransformInGlobal/*=true*/,ERigBoneType InBoneType/*=ERigBoneType.User*/,bool bSetupUndo/*=false*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Adds a null to the hierarchy</summary>
	public  FRigElementKey AddNull(string InName,FRigElementKey InParent,FTransform InTransform,bool bTransformInGlobal/*=true*/,bool bSetupUndo/*=false*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Adds a control to the hierarchy</summary>
	public  FRigElementKey AddControl_ForBlueprint(string InName,FRigElementKey InParent,FRigControlSettings InSettings,FRigControlValue InValue,bool bSetupUndo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Adds a control to the hierarchy</summary>
	public  FRigElementKey AddAnimationChannel_ForBlueprint(string InName,FRigElementKey InParentControl,FRigControlSettings InSettings,bool bSetupUndo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Adds a curve to the hierarchy</summary>
	public  FRigElementKey AddCurve(string InName,float InValue/*=0.0f*/,bool bSetupUndo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Adds a rigidbody to the hierarchy</summary>
	public  FRigElementKey AddRigidBody(string InName,FRigElementKey InParent,FRigRigidBodySettings InSettings,FTransform InLocalTransform,bool bSetupUndo/*=false*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Returns the control settings of a given control</summary>
	public  FRigControlSettings GetControlSettings(FRigElementKey InKey) { return default; }
	///<summary>Sets a control&#39;s settings given a control key</summary>
	public  bool SetControlSettings(FRigElementKey InKey,FRigControlSettings InSettings,bool bSetupUndo/*=false*/) { return default; }
	///<summary>Imports an existing skeleton to the hierarchy</summary>
	public  TArray<FRigElementKey> ImportBones(USkeleton InSkeleton,string InNameSpace/*=NAME_None*/,bool bReplaceExistingBones/*=true*/,bool bRemoveObsoleteBones/*=true*/,bool bSelectBones/*=false*/,bool bSetupUndo/*=false*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Imports an existing skeleton to the hierarchy</summary>
	public  TArray<FRigElementKey> ImportBonesFromAsset(string InAssetPath,string InNameSpace/*=NAME_None*/,bool bReplaceExistingBones/*=true*/,bool bRemoveObsoleteBones/*=true*/,bool bSelectBones/*=false*/,bool bSetupUndo/*=false*/) { return default; }
	///<summary>Imports all curves from a skeleton to the hierarchy</summary>
	public  TArray<FRigElementKey> ImportCurves(USkeleton InSkeleton,string InNameSpace/*=NAME_None*/,bool bSelectCurves/*=false*/,bool bSetupUndo/*=false*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Imports all curves from a skeleton to the hierarchy</summary>
	public  TArray<FRigElementKey> ImportCurvesFromAsset(string InAssetPath,string InNameSpace/*=NAME_None*/,bool bSelectCurves/*=false*/,bool bSetupUndo/*=false*/) { return default; }
	///<summary>Exports the selected items to text</summary>
	public  string ExportSelectionToText() { return default; }
	///<summary>Exports a list of items to text</summary>
	public  string ExportToText(TArray<FRigElementKey> InKeys) { return default; }
	///<summary>Imports the content of a text buffer to the hierarchy</summary>
	public  TArray<FRigElementKey> ImportFromText(string InContent,bool bReplaceExistingElements/*=false*/,bool bSelectNewElements/*=true*/,bool bSetupUndo/*=false*/,bool bPrintPythonCommands/*=false*/) { return default; }
	///<summary>Removes an existing element from the hierarchy</summary>
	public  bool RemoveElement(FRigElementKey InElement,bool bSetupUndo/*=false*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Renames an existing element in the hierarchy</summary>
	public  FRigElementKey RenameElement(FRigElementKey InElement,string InName,bool bSetupUndo/*=false*/,bool bPrintPythonCommand/*=false*/,bool bClearSelection/*=true*/) { return default; }
	///<summary>Changes the element&#39;s index within its default parent (or the top level)</summary>
	public  bool ReorderElement(FRigElementKey InElement,int InIndex,bool bSetupUndo/*=false*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Sets the display name on a control</summary>
	public  string SetDisplayName(FRigElementKey InControl,string InDisplayName,bool bRenameElement/*=false*/,bool bSetupUndo/*=false*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Adds a new parent to an element. For elements that allow only one parent the parent will be replaced (Same as ::SetParent).</summary>
	public  bool AddParent(FRigElementKey InChild,FRigElementKey InParent,float InWeight/*=0.0f*/,bool bMaintainGlobalTransform/*=true*/,bool bSetupUndo/*=false*/) { return default; }
	///<summary>Removes an existing parent from an element in the hierarchy. For elements that allow only one parent the element will be unparented (same as ::RemoveAllParents)</summary>
	public  bool RemoveParent(FRigElementKey InChild,FRigElementKey InParent,bool bMaintainGlobalTransform/*=true*/,bool bSetupUndo/*=false*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Removes all parents from an element in the hierarchy.</summary>
	public  bool RemoveAllParents(FRigElementKey InChild,bool bMaintainGlobalTransform/*=true*/,bool bSetupUndo/*=false*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Sets a new parent to an element. For elements that allow more than one parent the parent list will be replaced.</summary>
	public  bool SetParent(FRigElementKey InChild,FRigElementKey InParent,bool bMaintainGlobalTransform/*=true*/,bool bSetupUndo/*=false*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Duplicate the given elements</summary>
	public  TArray<FRigElementKey> DuplicateElements(TArray<FRigElementKey> InKeys,bool bSelectNewElements/*=true*/,bool bSetupUndo/*=false*/,bool bPrintPythonCommands/*=false*/) { return default; }
	///<summary>Mirrors the given elements</summary>
	public  TArray<FRigElementKey> MirrorElements(TArray<FRigElementKey> InKeys,FRigVMMirrorSettings InSettings,bool bSelectNewElements/*=true*/,bool bSetupUndo/*=false*/,bool bPrintPythonCommands/*=false*/) { return default; }
	///<summary>bReportWarningsAndErrors</summary>
	public bool bReportWarningsAndErrors;
	///<summary>GeneratePythonCommands</summary>
	public  TArray<string> GeneratePythonCommands() { return default; }
	///<summary>Hierarchy</summary>
	public TWeakObjectPtr<URigHierarchy> Hierarchy;
}
