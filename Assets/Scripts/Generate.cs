using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Generate : Score
{
    [SerializeField] private Button mathButton;
    [SerializeField] private TMP_Text example, answerText, scoreText;
    [SerializeField] private TMP_InputField textField;
    private int _firstNumber, _secondNumber, _result;
    private char[] simbol = {'+', '-', '*'};

    private void Start()
    {
        mathButton.onClick.AddListener(GenerateMath);
        textField.onEndEdit.AddListener(Check);
    }

    private void Check(string arg0)
    {
        if (int.TryParse(arg0, out var value))
        {
            if (value == _result)
            {
                answerText.text = "Верно";
                StaticHolder.iq++;
                GetScore(scoreText);
            }
            else
                answerText.text = "Не верно. Ответ: " + _result;
        }
           
    }

    private void GenerateMath()
    {
        answerText.text = "";
        _firstNumber = Random.Range(1, StaticHolder.diapazonNumbers);
        _secondNumber = Random.Range(1, StaticHolder.diapazonNumbers);

        var randomIndex = Random.Range(0, simbol.Length);
        var randomOperation = simbol[randomIndex];

        var res = Calculate(_firstNumber, randomOperation, _secondNumber);
        _result = res;
        example.text = $"{_firstNumber} {randomOperation} {_secondNumber} =";
    }

    private int Calculate(int a, char op, int b)
    {
        switch (op)
        {
            case '+':
                return a + b;
            case '-':
                return a - b;
            case '*':
                return a * b;
        }

        return 0;
    }
}
