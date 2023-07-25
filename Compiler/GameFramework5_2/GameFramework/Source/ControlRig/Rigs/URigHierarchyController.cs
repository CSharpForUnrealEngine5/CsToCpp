#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Rigs/RigHierarchyController.h")]
public partial class URigHierarchyController : UObject {
// RigHierarchyController
	public UObject GetHierarchy() { return default; }
	public void SetHierarchy(UObject InHierarchy) {}
	public bool SelectElement(FRigElementKey InKey,bool bSelect/*=true*/,bool bClearSelection/*=false*/) { return default; }
	public bool DeselectElement(FRigElementKey InKey) { return default; }
	public bool SetSelection(TArray<FRigElementKey> InKeys,bool bPrintPythonCommand/*=false*/) { return default; }
	public bool ClearSelection() { return default; }
	public FRigElementKey AddBone(string InName,FRigElementKey InParent,FTransform InTransform,bool bTransformInGlobal/*=true*/,ERigBoneType InBoneType/*=ERigBoneType.User*/,bool bSetupUndo/*=false*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public FRigElementKey AddNull(string InName,FRigElementKey InParent,FTransform InTransform,bool bTransformInGlobal/*=true*/,bool bSetupUndo/*=false*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public FRigElementKey AddControl_ForBlueprint(string InName,FRigElementKey InParent,FRigControlSettings InSettings,FRigControlValue InValue,bool bSetupUndo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public FRigElementKey AddAnimationChannel_ForBlueprint(string InName,FRigElementKey InParentControl,FRigControlSettings InSettings,bool bSetupUndo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public FRigElementKey AddCurve(string InName,float InValue/*=0.0f*/,bool bSetupUndo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public FRigElementKey AddRigidBody(string InName,FRigElementKey InParent,FRigRigidBodySettings InSettings,FTransform InLocalTransform,bool bSetupUndo/*=false*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public FRigControlSettings GetControlSettings(FRigElementKey InKey) { return default; }
	public bool SetControlSettings(FRigElementKey InKey,FRigControlSettings InSettings,bool bSetupUndo/*=false*/) { return default; }
	public TArray<FRigElementKey> ImportBones(UObject InSkeleton,string InNameSpace/*=NAME_None*/,bool bReplaceExistingBones/*=true*/,bool bRemoveObsoleteBones/*=true*/,bool bSelectBones/*=false*/,bool bSetupUndo/*=false*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public TArray<FRigElementKey> ImportBonesFromAsset(string InAssetPath,string InNameSpace/*=NAME_None*/,bool bReplaceExistingBones/*=true*/,bool bRemoveObsoleteBones/*=true*/,bool bSelectBones/*=false*/,bool bSetupUndo/*=false*/) { return default; }
	public TArray<FRigElementKey> ImportCurves(UObject InSkeleton,string InNameSpace/*=NAME_None*/,bool bSelectCurves/*=false*/,bool bSetupUndo/*=false*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public TArray<FRigElementKey> ImportCurvesFromAsset(string InAssetPath,string InNameSpace/*=NAME_None*/,bool bSelectCurves/*=false*/,bool bSetupUndo/*=false*/) { return default; }
	public string ExportSelectionToText() { return default; }
	public string ExportToText(TArray<FRigElementKey> InKeys) { return default; }
	public TArray<FRigElementKey> ImportFromText(string InContent,bool bReplaceExistingElements/*=false*/,bool bSelectNewElements/*=true*/,bool bSetupUndo/*=false*/,bool bPrintPythonCommands/*=false*/) { return default; }
	public bool RemoveElement(FRigElementKey InElement,bool bSetupUndo/*=false*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public FRigElementKey RenameElement(FRigElementKey InElement,string InName,bool bSetupUndo/*=false*/,bool bPrintPythonCommand/*=false*/,bool bClearSelection/*=true*/) { return default; }
	public bool ReorderElement(FRigElementKey InElement,int InIndex,bool bSetupUndo/*=false*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public string SetDisplayName(FRigElementKey InControl,string InDisplayName,bool bRenameElement/*=false*/,bool bSetupUndo/*=false*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public bool AddParent(FRigElementKey InChild,FRigElementKey InParent,float InWeight/*=0.0f*/,bool bMaintainGlobalTransform/*=true*/,bool bSetupUndo/*=false*/) { return default; }
	public bool RemoveParent(FRigElementKey InChild,FRigElementKey InParent,bool bMaintainGlobalTransform/*=true*/,bool bSetupUndo/*=false*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public bool RemoveAllParents(FRigElementKey InChild,bool bMaintainGlobalTransform/*=true*/,bool bSetupUndo/*=false*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public bool SetParent(FRigElementKey InChild,FRigElementKey InParent,bool bMaintainGlobalTransform/*=true*/,bool bSetupUndo/*=false*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public TArray<FRigElementKey> DuplicateElements(TArray<FRigElementKey> InKeys,bool bSelectNewElements/*=true*/,bool bSetupUndo/*=false*/,bool bPrintPythonCommands/*=false*/) { return default; }
	public TArray<FRigElementKey> MirrorElements(TArray<FRigElementKey> InKeys,FRigVMMirrorSettings InSettings,bool bSelectNewElements/*=true*/,bool bSetupUndo/*=false*/,bool bPrintPythonCommands/*=false*/) { return default; }
	public bool bReportWarningsAndErrors;
	public TArray<string> GeneratePythonCommands() { return default; }
	public TWeakObjectPtr<URigHierarchy> Hierarchy;
}
