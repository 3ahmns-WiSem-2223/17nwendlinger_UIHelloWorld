using UnityEngine;
using UnityEngine.UI;

public class CalculatorScript : MonoBehaviour
{
    public Text numberText;
    private int score;

    private void Start()
    {
        numberText.text = "";
    }

    private void Update()
    {
        numberText.text = "" + score;
    }

    public void PlusNumber()
    {
        score = score + 1;
    }

    public void MinusNumber()
    {
        score = score - 1;
    }

    public void Double()
    {
        score = score * 2;
    }
}
