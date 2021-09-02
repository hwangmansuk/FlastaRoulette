using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class TitleController : MonoBehaviour
{
    [SerializeField] private Image _logo;
    [SerializeField] private SceneManagerController _sceneMgr;
    private Sequence _seq;
    private void Awake()
    {
        _logo.color = new Color(1f, 1f, 1f, 0f);
    }

    private void Start()
    {
        if (_seq != null) _seq.Kill();
        _seq = DOTween.Sequence();

        _seq
            .AppendInterval(1f)
            .Append(
            _logo.DOFade(1f, 2f).SetEase(Ease.OutCirc).OnComplete(() =>
            {
                _sceneMgr.MoveToScene("01_MainMenu");
            }));
    }

}
