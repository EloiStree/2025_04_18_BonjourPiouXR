using UnityEditor;

public class FindMissingScriptsEditorWindow : EditorWindow
{
    [MenuItem("ꬲ🧰/Toolbox/Find Missing Script", false, 10)]
    static void ShowWindow()
    {
        FindMissingScriptMono.StaticFindAllMissingScripts();
    }


}
