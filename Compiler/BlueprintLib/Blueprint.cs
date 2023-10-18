namespace BlueprintLib;

using GameFramework;

public class UBlueprint : UObject
{
    /** 
     * Pointer to the parent class that the generated class should derive from. This *can* be null under rare circumstances, 
     * one such case can be created by creating a blueprint (A) based on another blueprint (B), shutting down the editor, and
     * deleting the parent blueprint. Exported as Alphabetical in GetAssetRegistryTags
     */
    public TSubclassOf<UObject> ParentClass;

    public EBlueprintType BlueprintType;

    public bool bGenerateConstClass;
    public bool bGenerateAbstractClass;
    public bool bDeprecate;
    public EBlueprintStatus Status;
    public string BlueprintDisplayName = "";
    public string BlueprintDescription = "";
    public string BlueprintNamespace  = "";
    public string BlueprintCategory = "";

    // Array of component template objects, used by AddComponent function
    public TArray<TObjectPtr<UActorComponent>> ComponentTemplates;

    //  Array of templates for timelines that should be created
    public TArray<TObjectPtr<UTimelineTemplate>> Timelines;

    /** Set of pages that combine into a single uber-graph */
    public TArray<TObjectPtr<UEdGraph>> UbergraphPages;

    /** Set of functions implemented for this class graphically */
    public TArray<TObjectPtr<UEdGraph>> FunctionGraphs;

    /** Graphs of signatures for delegates */
    public TArray<TObjectPtr<UEdGraph>> DelegateSignatureGraphs;

    /** Set of macros implemented for this class */
    public TArray<TObjectPtr<UEdGraph>> MacroGraphs;

    /** Set of functions actually compiled for this class */
    public TArray<TObjectPtr<UEdGraph>> EventGraphs;

}

public enum EBlueprintType
{
    /** Normal blueprint. */
    BPTYPE_Normal,
    /** Blueprint that is const during execution (no state graph and methods cannot modify member variables). */
    BPTYPE_Const,
    /** Blueprint that serves as a container for macros to be used in other blueprints. */
    BPTYPE_MacroLibrary,
    /** Blueprint that serves as an interface to be implemented by other blueprints. */
    BPTYPE_Interface,
    /** Blueprint that handles level scripting. */
    BPTYPE_LevelScript,
    /** Blueprint that serves as a container for functions to be used in other blueprints. */
    BPTYPE_FunctionLibrary,

    BPTYPE_MAX,
};

public enum EBlueprintStatus
{
    /** Blueprint is in an unknown state. */
    BS_Unknown,
    /** Blueprint has been modified but not recompiled. */
    BS_Dirty,
    /** Blueprint tried but failed to be compiled. */
    BS_Error,
    /** Blueprint has been compiled since it was last modified. */
    BS_UpToDate,
    /** Blueprint is in the process of being created for the first time. */
    BS_BeingCreated,
    /** Blueprint has been compiled since it was last modified. There are warnings. */
    BS_UpToDateWithWarnings,
    BS_MAX,
};