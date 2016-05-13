public var skin : GUISkin;
public var texturebutton : Texture;
function OnGUI()
{
    GUI.skin = skin;
    if (GUI.Button(new Rect(200, 200, 100, 100), texturebutton))
    {
        Application.LoadLevel("3");
    }
}