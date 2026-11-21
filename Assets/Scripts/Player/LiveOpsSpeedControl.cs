using UnityEngine;

public class LiveOpsSpeedControl : MonoBehaviour
{
    private PlatformPlayer playerMovement;
    public void Configure(PlatformPlayer movement) => playerMovement = movement;
    private void OnGUI()
    {
        if (playerMovement == null) return;
        float x = Mathf.Max(12f, Screen.width - 260f);
        GUI.Box(new Rect(x, 12f, 248f, 112f), "LIVE OPS - Runtime configuration");
        GUI.Label(new Rect(x + 12f, 42f, 220f, 24f), "Move speed: " + playerMovement.CurrentMoveSpeed.ToString("0.0"));
        if (GUI.Button(new Rect(x + 12f, 72f, 105f, 30f), "Slower (-)"))
            playerMovement.SetMoveSpeed(playerMovement.CurrentMoveSpeed - 1f);
        if (GUI.Button(new Rect(x + 129f, 72f, 105f, 30f), "Faster (+)"))
            playerMovement.SetMoveSpeed(playerMovement.CurrentMoveSpeed + 1f);
    }
}
