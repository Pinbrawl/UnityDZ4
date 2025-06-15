using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System.Collections;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private string _string1;
    [SerializeField] private string _string2;
    [SerializeField] private float _time;

    private void Awake()
    {
        _text.text = _string1;

        StartCoroutine(Change());
    }

    private IEnumerator Change()
    {
        var waitTime = new WaitForSecondsRealtime(_time);

        _text.DOText(_string2, _time);
        yield return waitTime;

        _text.DOText(" " + _string1, _time).SetRelative();
        yield return waitTime;

        _text.DOText(_string2, _time, true, ScrambleMode.All);
        yield return waitTime;

        _text.DOText(_string1, _time);
        yield return waitTime;

        _text.DOText(" " + _string2, _time).SetRelative();
        yield return waitTime;

        _text.DOText(_string1, _time, true, ScrambleMode.All);
        yield return waitTime;

        yield return Change();
    }
}
