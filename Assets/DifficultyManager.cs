using UnityEngine;

public class DifficultyManager : MonoBehaviour
{
    public PingPongLauncher launcher;
    public MetricsBoardUI metricsBoard;
    public GameObject beginnerButton;
    public GameObject intermediateButton;
    public GameObject advancedButton;


    public void SetBeginner()
    {
        launcher.difficulty = Difficulty.Beginner;
        launcher.SendMessage("ApplyDifficulty");
        metricsBoard.SetDifficulty(Difficulty.Beginner);
        HighlightButton(Difficulty.Beginner);
    }

    public void SetIntermediate()
    {
        launcher.difficulty = Difficulty.Intermediate;
        launcher.SendMessage("ApplyDifficulty");
        metricsBoard.SetDifficulty(Difficulty.Intermediate);
        HighlightButton(Difficulty.Intermediate);
    }

    public void SetAdvanced()
    {
        launcher.difficulty = Difficulty.Advanced;
        launcher.SendMessage("ApplyDifficulty");
        metricsBoard.SetDifficulty(Difficulty.Advanced);
        HighlightButton(Difficulty.Advanced);
    }

    // We'll fill this in next
    private void HighlightButton(Difficulty difficulty)
    {
        // Reset all colors
        SetButtonColor(beginnerButton, Color.white);
        SetButtonColor(intermediateButton, Color.white);
        SetButtonColor(advancedButton, Color.white);

        // Highlight the selected one
        switch (difficulty)
        {
            case Difficulty.Beginner:
                SetButtonColor(beginnerButton, Color.green);
                break;

            case Difficulty.Intermediate:
                SetButtonColor(intermediateButton, Color.yellow);
                break;

            case Difficulty.Advanced:
                SetButtonColor(advancedButton, Color.red);
                break;
        }
    }

    private void SetButtonColor(GameObject button, Color color)
    {
        var image = button.GetComponent<UnityEngine.UI.Image>();
        if (image != null)
            image.color = color;
    }

}
